using System;
using System.IO.Ports;
using Microsoft.SPOT.Hardware;

namespace Gr.NETMF.Hardware.Peach
{
    internal class GR_PEACHHardwareProvider : HardwareProvider
    {
        static GR_PEACHHardwareProvider()
        {
            Microsoft.SPOT.Hardware.HardwareProvider.Register(new GR_PEACHHardwareProvider());
        }

        override public void GetSerialPins(string comPort, out Cpu.Pin rxPin, out Cpu.Pin txPin, out Cpu.Pin ctsPin, out Cpu.Pin rtsPin)
        {
            switch (comPort)
            {
                case "COM1":
                    rxPin = Pins.GPIO_PIN_P2_15;
                    txPin = Pins.GPIO_PIN_P2_14;
                    ctsPin = Pins.GPIO_NONE;
                    rtsPin = Pins.GPIO_NONE;
                    break;
                default:
                    throw new NotSupportedException();
            }
        }

        override public void GetI2CPins(out Cpu.Pin scl, out Cpu.Pin sda)
        {
            scl = Pins.GPIO_PIN_P1_2;
            sda = Pins.GPIO_PIN_P1_3;
        }
    }

    // Specifies identifiers for hardware I/O pins.
    public static class Pins
    {
        //
        internal const Cpu.Pin GPIO_PIN_P1_2 = (Cpu.Pin)0x12;
        internal const Cpu.Pin GPIO_PIN_P1_3 = (Cpu.Pin)0x13;

        internal const Cpu.Pin GPIO_PIN_P1_8 = (Cpu.Pin)0x18;
        internal const Cpu.Pin GPIO_PIN_P1_9 = (Cpu.Pin)0x19;
        internal const Cpu.Pin GPIO_PIN_P1_10 = (Cpu.Pin)0x1a;
        internal const Cpu.Pin GPIO_PIN_P1_11 = (Cpu.Pin)0x1b;
        internal const Cpu.Pin GPIO_PIN_P1_13 = (Cpu.Pin)0x1d;
        internal const Cpu.Pin GPIO_PIN_P1_15 = (Cpu.Pin)0x1f;

        internal const Cpu.Pin GPIO_PIN_P2_14 = (Cpu.Pin)0x2e;
        internal const Cpu.Pin GPIO_PIN_P2_15 = (Cpu.Pin)0x2f;

        internal const Cpu.Pin GPIO_PIN_P4_4 = (Cpu.Pin)0x44;
        internal const Cpu.Pin GPIO_PIN_P4_5 = (Cpu.Pin)0x45;
        internal const Cpu.Pin GPIO_PIN_P4_6 = (Cpu.Pin)0x46;
        internal const Cpu.Pin GPIO_PIN_P4_7 = (Cpu.Pin)0x47;

        internal const Cpu.Pin GPIO_PIN_P6_12 = (Cpu.Pin)0x6c;

        internal const Cpu.Pin GPIO_PIN_P8_11 = (Cpu.Pin)0x8b;
        internal const Cpu.Pin GPIO_PIN_P8_13 = (Cpu.Pin)0x8d;
        internal const Cpu.Pin GPIO_PIN_P8_14 = (Cpu.Pin)0x8e;
        internal const Cpu.Pin GPIO_PIN_P8_15 = (Cpu.Pin)0x8f;

        internal const Cpu.Pin GPIO_PIN_P10_12 = (Cpu.Pin)0xac;
        internal const Cpu.Pin GPIO_PIN_P10_13 = (Cpu.Pin)0xad;
        internal const Cpu.Pin GPIO_PIN_P10_14 = (Cpu.Pin)0xae;
        internal const Cpu.Pin GPIO_PIN_P10_15 = (Cpu.Pin)0xaf;

        //

        public const Cpu.Pin GPIO_PIN_D0 = GPIO_PIN_P2_15;
        public const Cpu.Pin GPIO_PIN_D1 = GPIO_PIN_P2_14;
        public const Cpu.Pin GPIO_PIN_D2 = GPIO_PIN_P4_7;
        public const Cpu.Pin GPIO_PIN_D3 = GPIO_PIN_P4_6;
        public const Cpu.Pin GPIO_PIN_D4 = GPIO_PIN_P4_5;
        public const Cpu.Pin GPIO_PIN_D5 = GPIO_PIN_P4_4;
        public const Cpu.Pin GPIO_PIN_D6 = GPIO_PIN_P8_13;
        public const Cpu.Pin GPIO_PIN_D7 = GPIO_PIN_P8_11;
        public const Cpu.Pin GPIO_PIN_D8 = GPIO_PIN_P8_15;
        public const Cpu.Pin GPIO_PIN_D9 = GPIO_PIN_P8_14;
        public const Cpu.Pin GPIO_PIN_D10 = GPIO_PIN_P10_13;   // SS
        public const Cpu.Pin GPIO_PIN_D11 = GPIO_PIN_P10_14;   // MOSI
        public const Cpu.Pin GPIO_PIN_D12 = GPIO_PIN_P10_15;   // MISO
        public const Cpu.Pin GPIO_PIN_D13 = GPIO_PIN_P10_12;   // CLK

        public const Cpu.Pin GPIO_PIN_SCL = GPIO_PIN_P1_2;
        public const Cpu.Pin GPIO_PIN_SDL = GPIO_PIN_P1_3;

        public const Cpu.Pin GPIO_PIN_A0 = GPIO_PIN_P1_8;
        public const Cpu.Pin GPIO_PIN_A1 = GPIO_PIN_P1_9;
        public const Cpu.Pin GPIO_PIN_A2 = GPIO_PIN_P1_10;
        public const Cpu.Pin GPIO_PIN_A3 = GPIO_PIN_P1_11;
        public const Cpu.Pin GPIO_PIN_A4 = GPIO_PIN_P1_13;
        public const Cpu.Pin GPIO_PIN_A5 = GPIO_PIN_P1_15;

        public const Cpu.Pin ONBOARD_LED = GPIO_PIN_P6_12;

        public const Cpu.Pin GPIO_NONE = Cpu.Pin.GPIO_NONE;
    }

    // Specifies identifiers for analog channels.
    public static class AnalogChannels
    {
        public const Cpu.AnalogChannel ANALOG_PIN_A0 = Cpu.AnalogChannel.ANALOG_0;
        public const Cpu.AnalogChannel ANALOG_PIN_A1 = Cpu.AnalogChannel.ANALOG_1;
        public const Cpu.AnalogChannel ANALOG_PIN_A2 = Cpu.AnalogChannel.ANALOG_2;
        public const Cpu.AnalogChannel ANALOG_PIN_A3 = Cpu.AnalogChannel.ANALOG_3;
        public const Cpu.AnalogChannel ANALOG_PIN_A4 = Cpu.AnalogChannel.ANALOG_4;
        public const Cpu.AnalogChannel ANALOG_PIN_A5 = Cpu.AnalogChannel.ANALOG_5;
        public const Cpu.AnalogChannel ANALOG_NONE = Cpu.AnalogChannel.ANALOG_NONE;
    }

    public static class SerialPorts
    {
        public const string COM1 = "COM1";
        public const string COM2 = "COM2";
    }

    public static class BaudRates
    {
        public const BaudRate Baud2400 = BaudRate.Baudrate2400;
        public const BaudRate Baud9600 = BaudRate.Baudrate9600;
        public const BaudRate Baud19200 = BaudRate.Baudrate19200;
        public const BaudRate Baud38400 = BaudRate.Baudrate38400;
        public const BaudRate Baud57600 = BaudRate.Baudrate57600;
        public const BaudRate Baud115200 = BaudRate.Baudrate115200;
    }

    public static class ResistorModes
    {
        public const Port.ResistorMode PullUp = Port.ResistorMode.PullUp;
        public const Port.ResistorMode Disabled = Port.ResistorMode.Disabled;
    }

    public static class InterruptModes
    {
        public const Port.InterruptMode InterruptEdgeLow = Port.InterruptMode.InterruptEdgeLow;
        public const Port.InterruptMode InterruptEdgeHigh = Port.InterruptMode.InterruptEdgeHigh;
        public const Port.InterruptMode InterruptEdgeBoth = Port.InterruptMode.InterruptEdgeBoth;
        public const Port.InterruptMode InterruptEdgeLevelHigh = Port.InterruptMode.InterruptEdgeLevelHigh;
        public const Port.InterruptMode InterruptEdgeLevelLow = Port.InterruptMode.InterruptEdgeLevelLow;
        public const Port.InterruptMode InterruptNone = Port.InterruptMode.InterruptNone;
    }

    public static class SPI_Devices
    {
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI1 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI1;
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI2 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI2;
        public const Microsoft.SPOT.Hardware.SPI.SPI_module SPI3 = Microsoft.SPOT.Hardware.SPI.SPI_module.SPI3;
    }
}
