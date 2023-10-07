// Copyrigth (c) S.C.SoftLab S.R.L.
// All Rigths reserved.

using Aerotec.Data.Helper;
using Microsoft.VisualBasic;

namespace Aerotec.Data.Factories
{
    public class Jet3UpMessageBuilder
    {
        private static Jet3UpMessageBuilder instance;
        private FontSizeEnum size;
        private MachineTypeEnum machineType;
        private string message = "";

        private Jet3UpMessageBuilder()
        {
            
        }

        public static Jet3UpMessageBuilder Start()
        {
            instance = new Jet3UpMessageBuilder();
            return instance;
        }

        private string GetBold(FontSizeEnum size, MachineTypeEnum machineType)
        {
            switch(machineType)
            {
                case MachineTypeEnum.Alba:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "1 0 1";
                        case FontSizeEnum.ISO1_7x5:
                            return "1 1 2";
                        case FontSizeEnum.ISO1_9x7:
                            return "1 1 2";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                case MachineTypeEnum.Neagra:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "1 0 0";
                        case FontSizeEnum.ISO1_7x5:
                            return "1 0 0";
                        case FontSizeEnum.ISO1_9x7:
                            return "1 0 0";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(machineType));
            }            
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId)
        {

            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0*OBJ [1 0 11 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [2 97 11 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [4 64 0 0 (ISO1_7x5)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [5 97 0 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;

                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0*OBJ [1 0 13 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [2 173 13 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [4 131 0 0 (ISO1_7x5)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [5 173 1 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0*OBJ [1 0 16 0 (ISO1_9x7)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [2 260 16 0 (ISO1_9x7)  (" + signature + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_9x7)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [4 176 0 0 (ISO1_9x7)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [5 260 0 0 (ISO1_9x7)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, machineType) + " 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;
                    break;
                default:

                    break;
            }
            return this;
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId, string final)
        {

            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0*OBJ [1 0 22 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 97 22 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 11 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 64 11 0 (ISO1_7x5)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 97 11 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_7x5)  (" + final + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0*OBJ [1 0 24 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 173 24 0 (ISO1_7x5)  (" + signature + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 12 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 131 12 0 (ISO1_7x5)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 173 12 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_7x5)  (" + final + "  ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;


                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0*OBJ [1 0 32 0 (ISO1_9x7)  (" + HTZ + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 260 32 0 (ISO1_9x7)  (" + signature + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 16 0 (ISO1_9x7)  (" + ANR + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 176 16 0 (ISO1_9x7)  (" + BTIDX + " ) 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 260 16 0 (ISO1_9x7)  (" + controllerId + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_9x7)  (" + final + ") 1 0 0 0 0 " + GetBold(size, MachineTypeEnum.Neagra) + " 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;

                    break;
                default:

                    break;
            }
            return this;
        }

        private string GetDistanceBetweenDots(FontSizeEnum size, MachineTypeEnum machineType)
        {
            switch (machineType)
            {
                case MachineTypeEnum.Alba:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "280";
                        case FontSizeEnum.ISO1_7x5:
                            return "420";
                        case FontSizeEnum.ISO1_9x7:
                            return "380";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                case MachineTypeEnum.Neagra:
                    switch (size)
                    {
                        case FontSizeEnum.ISO1_5x3:
                            return "260";
                        case FontSizeEnum.ISO1_7x5:
                            return "280";
                        case FontSizeEnum.ISO1_9x7:
                            return "280";
                        default:
                            throw new ArgumentOutOfRangeException(nameof(size));
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(machineType));
            }
        }

        public Jet3UpMessageBuilder SetSize(FontSizeEnum size,int rotation, MachineTypeEnum machineType, int printGoSignal = 0, int encoderSignal = 0, int encoderSpeed = 10, int encoderResolution = 700)
        {
            this.size = size;
            this.machineType = machineType;
            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 60 1 0 3 10 " + rotation + " 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [ 2000 0 0 " + GetDistanceBetweenDots(size, machineType) + " 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 " + rotation + " 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [2000 0 0 " + GetDistanceBetweenDots(size, machineType) + " 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 " + rotation + " 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [ 2000 0 0 " + GetDistanceBetweenDots(size, machineType) + " 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
                    break;
                default:

                    break;
            }
            return this;

        }

        public Jet3UpMessageBuilder Create()
        {
            message += "^0*ENDJOB []" + Constants.vbCrLf + "^0*ENDLJSCRIPT []" + Constants.vbCrLf;
            return this;
        }

        public string End()
        {
            message += "^0*ENDJOB []" + Constants.vbCrLf
                    + "^0*ENDLJSCRIPT []" + Constants.vbCrLf;
            return message;
        }
    }
}
