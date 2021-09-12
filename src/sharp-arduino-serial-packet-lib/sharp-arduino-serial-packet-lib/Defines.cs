﻿namespace sharp_arduino_serial_packet_lib
{
    //http://www.codeproject.com/Articles/75770/Basic-serial-port-listening-application 
    public class Defines
    {
        public const int DEFAULT_BAUDRATE = 115200;

        //Sensor types:

        public const int TEMPERATURE = 0x10;
        public const int HUMIDITY = 0x11;

        public const int DISTANCE = 0x30;
        public const int MOTORSTATUS = 0x50;

        //Command IDs
       

    }
    public enum Commands
    {
        STOP_MOTOR_A = 0x10,
        START_MOTOR_A = 0x11,
        SET_SPEED_MOTOR_A = 0x12,
        BRAKE_MOTOR_A = 0x13,
        STOP_MOTOR_B = 0x15,
        START_MOTOR_B = 0x16,
        SET_SPEED_MOTOR_B = 0x17,
        BRAKE_MOTOR_B = 0x18
    }
    public enum PacketFields {Unknown ,Type, NodeID, SensorID, CommandID, Payload, Parity}

    public enum PacketTypes { Command = 0x01, Command_Reply =0x02, Data_Request= 0x11, Data_Byte= 0x12, Data_Int=0x13, Data_Array_Request= 0x21, Data_Array= 0x22, Unknown = 0x77}

}
