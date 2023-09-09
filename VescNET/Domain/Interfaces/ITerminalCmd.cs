using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VescNET.Domain.Interfaces
{
    public interface ITerminalCmd
    {
        //Show this help
        void Help();
        
        //Print pong here to see if the reply works
        void Ping();
        
        //Stop the motor
        void Stop();
        
        //The time the latest ADC interrupt consumed
        void LastAdcDuration();
        
        //The calculated kv of the motor
        void Kv();
        
        //Show memory usage
        void Mem();
        
        //List all threads
        void Threads();
        
        //Prints the current fault code
        void Fault();
        
        //Prints all stored fault codes and conditions when they arrived
        void Faults();
        
        //Prints the current electrical RPM
        void Rpm();
        
        //Prints tachometer value
        void Tacho();
        
        //Prints odometer value
        void Dist();
        
        //Prints tim1 and tim8 settings
        void Tim();
        
        //Prints different voltages
        void Volt();

        //Spin up the motor in COMM_MODE_DELAY and compute its parameters.
        //This test should be performed without load on the motor.
        //Example: param_detect 5.0 600 0.06
        void ParamDetect(float current, int minRpm, float lowDuty);
        
        //Prints some rpm-dep values
        void RpmDep();
        
        //Prints all CAN devices seen on the bus the past second
        void CanDevs();

        //Run the motor at 1Hz on open loop and compute encoder settings
        void FocEncoderDetect(float current);

        //Lock the motor with a current and calculate its resistance
        void MeasureRes(float current);

        //Send short voltage pulses, measure the current and calculate the motor inductance
        void MeasureInd(float duty);

        //Run the motor in BLDC delay mode and measure the flux linkage
        //example measure_linkage 5 0.5 700 0.076
        //tip: measure the resistance with measure_res first
        void MeasureLinkage(float current, float duty, float minErpm, float motorRes);
        
        //Measure the motor resistance and inductance with an incremental adaptive algorithm.
        void MeasureResInd();
        
        //Run the motor with FOC and measure the flux linkage.
        void MeasureLinkageFoc(float duty);

        //Run the motor in openloop FOC and measure the flux linkage
        //example measure_linkage_openloop 5 0.5 1000 0.076 0.000015
        //tip: measure the resistance with measure_res first
        void MeasureLinkageOpenloop(float current, float duty, int erpmPerSec, float motorRes, float motorInd);

        //Print some FOC state variables.
        void FocState();
        
        //Calibrate current and voltage DC offsets.
        void FocDcCal();
        
        //Print some hardware status information.
        void HwStatus();

        //Create an open loop rotating current vector.
        void FocOpenloop(float current, int erpm);

        //Create an open loop rotating voltage vector.
        void FocOpenloopDuty(float duty, int erpm);

        //Enable or disable external NRF51822.
        void NrfExtSetEnabled(bool enabled);

        //Automatically detect FOC sensors, and apply settings on success.
        void FocSensorsDetectApply(float current);

        //Lock the motor with a current for a given time. Time 0 means forever, or
        //or until the heartbeat packets stop.
        void RotorLockOpenloop(float currentA, int timeS, float angleDeg);

        //Detect and apply all motor settings, based on maximum resistive motor power losses.
        void FocDetectApplyAll(float maxPowerLossW);

        //Scan CAN-bus using ping commands, and print all devices that are found.
        void CanScan();

        //Detect and apply all motor settings, based on maximum resistive motor power losses. Also
        //initiates detection in all VESCs found on the CAN-bus.
        void FocDetectApplyAllCan(float maxPowerLossW);

        //Prints the status of the AS5047, AD2S1205, or TS5700N8501 encoder.
        void Encoder();
        
        //Clear error of the TS5700N8501 encoder.)
        void EncoderClearErrors();
        
        //Clear multiturn counter of the TS5700N8501 encoder.)
        void EncoderClearMultiturn();
        
        //Prints how many seconds have passed since boot.
        void Uptime();

        //Rotate motor in open loop and analyze hall sensors.
        void HallAnalyze(float current);

        //Set digital output of IO board.
        void IoBoardSetOutput(int id, int ch, int state);

        //Set pwm output of IO board.
        void IoBoardSetOutputPwm(int id, int ch, int duty);

        //Print CRC values.
        void Crc();
        
        //Reset gate driver faults (if possible).
        void DrvResetFaults();

        //Update position PID offset.
        void UpdatePidPosOffset(float angleNow, int store);

        //Print recent motor events
        void Events();

        //connects virtual motor
        void ConnectVirtualMotor(int ml, int J, int vBus);

        //disconnect virtual motor
        void DisconnectVirtualMotor();

        //FOC Test Print
        void FocTmp();

        //Enable HFI plotting. 0: off, 1: DFT, 2: Raw
        void FocPlotHfiEn(float en);

        //Enable UAVCAN debug prints 0: off 1: errors 2: param getset 3: current calc 4: comms stuff)
        void UavcanDebug(int level);

        //Print the status of the nunchuk app
        void NunchukStatus();
        
        //BlackMagic: Scan SWD
        void BmSwdpScan();

        //BlackMagic: Attach target
        void BmAttach(int index);

        //BlackMagic: Erase flash memory
        void BmFlashErase(string hexAddr, int len);

        //BlackMagic: Show target commands
        void BmTargetHelp();

        //BlackMagic: Run command on target
        void BmTargetCmd(string cmd);

        //BlackMagic: Reset target
        void BmReset();
        
        //BlackMagic: Detach target
        void BmDetach();

        //Output real time values to the experiments graph
        void AppBalanceExperiment(int fieldNumber, int plot);
    }
}

