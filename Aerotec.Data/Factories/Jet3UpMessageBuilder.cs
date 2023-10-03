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
        private string message = "";

        public static Jet3UpMessageBuilder Start()
        {
            instance = new Jet3UpMessageBuilder();
            return instance;
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId, string final)
        {

            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0*OBJ [1 0 22 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 89 22 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 11 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 64 11 0 (ISO1_7x5)  (" + BTIDX + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 87 11 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_7x5)  (" + final + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0*OBJ [1 0 26 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 168 26 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 26 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 131 13 0 (ISO1_7x5)  (" + BTIDX + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 163 13 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_7x5)  (" + final + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;


                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0*OBJ [1 0 32 0 (ISO1_9x7)  (" + HTZ + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 251 32 0 (ISO1_9x7)  (" + signature + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 16 0 (ISO1_9x7)  (" + ANR + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 176 16 0 (ISO1_9x7)  (" + BTIDX + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 242 16 0 (ISO1_9x7)  (" + controllerId + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [6 0 0 0 (ISO1_9x7)  (" + final + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;

                    break;
                default:

                    break;
            }
            return this;
        }

        public Jet3UpMessageBuilder Write(string HTZ, string signature, string ANR, string BTIDX, string controllerId)
        {

            switch (size)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0*OBJ [1 0 11 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [2 89 11 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [4 64 0 0 (ISO1_7x5)  (" + BTIDX + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf
                            + "^0*OBJ [5 87 0 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 1 0 1 0 0 0 0 ()  () 0 0 ()]" + Constants.vbCrLf;

                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0*OBJ [1 0 13 0 (ISO1_7x5)  (" + HTZ + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 168 13 0 (ISO1_7x5)  (" + signature + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_7x5)  (" + ANR + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 131 0 0 (ISO1_7x5)  (" + BTIDX + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 163 1 0 (ISO1_7x5)  (" + controllerId + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0*OBJ [1 0 16 0 (ISO1_9x7)  (" + HTZ + " ) 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [2 251 16 0 (ISO1_9x7)  (" + signature + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [3 0 0 0 (ISO1_9x7)  (" + ANR + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [4 176 0 0 (ISO1_9x7)  (" + BTIDX + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf
                            + "^0*OBJ [5 242 0 0 (ISO1_9x7)  (" + controllerId + ") 1 0 0 0 0 1 1 2 0 0 0 0 ()  () 0 0 () ]" + Constants.vbCrLf;
                    break;
                default:

                    break;
            }
            return this;
        }

        public Jet3UpMessageBuilder SetSize(FontSizeEnum fontSize, int printGoSignal = 0, int encoderSignal = 0, int encoderSpeed = 10, int encoderResolution = 700)
        {
            size = fontSize;
            switch (fontSize)
            {
                case FontSizeEnum.ISO1_5x3:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 60 1 0 3 10 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [ 2000 0 0 280 0 0 0 1 1 0 -1 () 1 1 55000 0 9 0 1 0 100 0 1 0]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_7x5:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [2000 0 0 420 0 0 0 1 1 0 -1 () 1 1 55000 0 16 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
                    break;
                case FontSizeEnum.ISO1_9x7:
                    message += "^0!GO" + Constants.vbCrLf + "^0*BEGINLJSCRIPT [()]" + Constants.vbCrLf
                            + $"^0*JLPAR [ 90 1 0 3 1000 180 0 30000 00:00 0 30000 0 0 1000 0]" + Constants.vbCrLf
                            + "^0*BEGINJOB [ 0 () ]" + Constants.vbCrLf
                            + "^0*JOBPAR [ 2000 0 0 380 0 0 0 1 1 0 -1 () 1 1 55000 0 21 0 1 0 100 0 1 0 ]" + Constants.vbCrLf;
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
                    + "^0*ENDLJSCRIPT []";
            return message;
        }
    }
}
