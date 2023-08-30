using System;
using VescNET.Domain.DTOs;
using VescNET.Domain.Enums;
using VescNET.Domain.Interfaces;

namespace VescNET.Infra
{
    public class Packet : IPacket
    {
        const int _packetMaxLength = 512;
        const int _packetRxTimeout = 2;

        private ReceivedData _receivedData;
        private IBuffer _buffer;
        private IPacketProcess _packetProcess;

        private int _rxState;
        private int _rxTimeout;
        private uint _payloadLength;
        private byte[] _rxBuf;
        private byte[] _txBuf;
        private uint _rxDataPtr;
        private int _crcLow;
        private int _crcHigh;
        private PacketProcessState _processState;

        public ReceivedData ReceivedData => _receivedData;

        public Packet(IBuffer buffer, IPacketProcess packetProcess) 
        {
            _receivedData = new ReceivedData();
            _rxBuf = new byte[_packetMaxLength];
            _txBuf = new byte[_packetMaxLength + 6];

            _buffer = buffer;
            _packetProcess = packetProcess;

            _buffer.Init(_rxBuf);
        }

        public PacketProcessState ProcessRX(byte @byte)
        {
            switch (_rxState)
            {
                case 0:
                    if(@byte == 2)
                    {
                        // 1 byte PL len
                        _rxState += 2;
                        _rxTimeout = _packetRxTimeout;
                        _rxDataPtr = 0;
                        _payloadLength = 0;
                        _processState = PacketProcessState.Processing;
                    }
                    else if (@byte == 3)
                    {
                        _rxState++;
                        _rxTimeout = _packetRxTimeout;
                        _rxDataPtr = 0;
                        _payloadLength = 0;
                        _processState = PacketProcessState.Processing;
                    }
                    else
                    {
                        _rxState = 0;
                        _processState = PacketProcessState.Idle;
                    }
                    break;

                case 1:
                    _payloadLength = (uint)@byte << 8;
                    _rxState++;
                    _rxTimeout = _packetRxTimeout;
                    break;

                case 2:
                    _payloadLength |= (uint)@byte;
                    if(_payloadLength > 0 && _payloadLength <= _packetMaxLength)
                    {
                        _rxState++;
                        _rxTimeout = _packetRxTimeout;
                    } else
                    {
                        _rxState = 0;
                        _processState = PacketProcessState.Idle;
                    }
                    break;

                case 3:
                    _rxBuf[_rxDataPtr++] = @byte;
                    if(_rxDataPtr ==  _payloadLength)
                    {
                        _rxState++;
                    }
                    _rxTimeout = _packetRxTimeout;
                    break;

                case 4:
                    _crcHigh = @byte;
                    _rxState++;
                    _rxTimeout = _packetRxTimeout;
                    break;

                case 5:
                    _crcLow = @byte;
                    _rxState++;
                    _rxTimeout = _packetRxTimeout;
                    break;

                case 6:
                    if (@byte == 3)
                    {
                        var receivedCrc = _crcHigh << 8 | _crcLow;
                        var calculatedCrc = CRC16.ComputeChecksum(_rxBuf, _payloadLength);
                        if (calculatedCrc == receivedCrc)
                        {
                            _receivedData = _packetProcess.Call(_buffer, _payloadLength);
                            _processState = PacketProcessState.Done;
                        }
                        else
                        {
                            _processState = PacketProcessState.Error;
                        }
                    }
                    else
                    {
                        _processState = PacketProcessState.Error;
                    }
                    _rxState = 0;
                    break;

                default:
                    _rxState = 0;
                    _processState = PacketProcessState.Idle;
                    break;
            }

            return _processState;
        }

        public byte[] ProcessTX(byte[] data)
        {
            if (data.Length > _packetMaxLength) 
            { 
                throw new OverflowException(); 
            }

            int bInd = 0;

            if(data.Length < 256)
            {
                _txBuf[bInd++] = 2;
                _txBuf[bInd++] = (byte)data.Length;
            }
            else
            {
                _txBuf[bInd++] = 3;
                _txBuf[bInd++] = (byte)(data.Length >> 8);
                _txBuf[bInd++] = (byte)(data.Length & 0xff);
            }

            for (int i = 0; i < data.Length; i++)
            {
                _txBuf[bInd++] = data[i];
            }

            ushort crc = CRC16.ComputeChecksum(data);

            _txBuf[bInd++] = (byte)(crc >>  8);
            _txBuf[bInd++] = (byte)(crc & 0xff);
            _txBuf[bInd++] = 3;

            var ret = new byte[bInd];
            Array.Copy(_txBuf, ret, bInd);
            return ret;
        }
    }
}
