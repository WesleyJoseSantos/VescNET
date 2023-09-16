VescNET
=======

This library can be used to communicate .NET applications to VESC drivers using usb/serial port.

This project is based on [vedderb/bldc_uart_comm_stm32f4_discovery](https://github.com/vedderb/bldc_uart_comm_stm32f4_discovery) repository.

## Table of contents

- [VescNET](#vescnet)
  - [Table of contents](#table-of-contents)
  - [Features](#features)
  - [Usage](#usage)
    - [Build bldc instance](#build-bldc-instance)
    - [Register communication events](#register-communication-events)
    - [Handle connection changed event](#handle-connection-changed-event)
    - [Handle data event:](#handle-data-event)

## Features

 * Read VESC firmware information
 * Get values from VESC
 * Read/Set VESC motor parameters
 * Read/Set VESC app parameters
 * Set Duty Cycle
 * Set Current
 * Set Current Brake
 * Set RPM
 * Set Position
 * Set Handbrake Current
 * Set Servo Position
 * Request Encoder Detection
 * Terminal Commands

## Usage

### Build bldc instance

```csharp
var buffer = new VescNET.Infra.Buffer();
var packetProcess = new PacketProcess();
var packet = new Packet(buffer, packetProcess);
var serial = new SerialPort();
var comm = new BldcSerial(packet, serial);
var bldc = new Bldc(buffer, comm);
```

### Register communication events

```csharp
comm.ConnectionChanged += BldcComm_ConnectionChanged;
comm.OnData += BldcComm_OnData;
```

### Handle connection changed event

```csharp
private void BldcComm_ConnectionChanged(object sender, bool connected)
{
  if (connected)
  {
    Console.log("VESC connected");
  }
  else
  {
    Console.log("VESC disconnected");
  }
}
```

### Handle data event:

```csharp
private void BldcComm_OnData(object sender, VescNET.Domain.DTOs.ReceivedData e)
{
  switch (e.PacketId)
  {
    case CommPacketId.FwVersion:
    case CommPacketId.GetValues:
    case CommPacketId.DetectEncoder:
      Console.log(PacketProcess.PrintData(e));
      break;
    case CommPacketId.GetMcConf:
    {
      Console.log("McConf received");
      var mcConf = e.Data as McConfiguration;
      // handle mcConf
      break;
    }
    case CommPacketId.GetAppConf:
    {
      Console.log("AppConf received");
      var appConf = e.Data as AppConfiguration;
      // handle appConf
      break;
    }
    case CommPacketId.SetMcConf:
      Console.log("Mcconf sended to VESC");
      bldc.GetMcconf();
      break;
    case CommPacketId.SetAppConf:
      Console.log("Appconf sended to VESC");
      bldc.GetAppconf();
      break;
  }
}
```
