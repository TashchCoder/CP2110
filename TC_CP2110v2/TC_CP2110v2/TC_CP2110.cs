using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using SLABHIDTOUART_DLL;

namespace TC_CP2110v2
{
    public class TC_CP2110
    {

        #region global vars
        ushort PID { get; set; }
        ushort VID { get; set; }

        public Action<string> Handler;

        //объект чисто для лока метода запросов SendReport
        private readonly object balanceLock;
        //объект, ассоциирующийся со считывателем
        IntPtr device;
        // количество найденных устройств с заданными значениями VID и PID
        uint NumDevices;


        //переменные для получения данных от считывателя
        uint numBytesToRead;
        uint numBytesRead;
        //буфер предварительной записи данных со считывателя
        byte[] buffer;
        //сюда записываются данные из буфера buffer
        string data;
        

        //второй поток для Update
        Thread UpdateThread;

        bool isConnect;








        #endregion



        #region constructors
        public TC_CP2110 ()
        {
            isConnect = false;
            device = new IntPtr();
            data = "";
            buffer = new byte[32768];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0;
            }
            numBytesToRead = 32768;
            numBytesRead = 0;
            NumDevices = 0;
            balanceLock = new object();



        }



        #endregion



        #region Update



        void UpdateCycle()
        {
            while (isConnect)
            {
                Update();
                Thread.Sleep(200);
            }


        }



        void Update()
        {
            int res = SendReport(4);
            if (res== SLABHIDTOUART.HID_UART_SUCCESS || res==18)
            {
                data = "";

                for (int i = 0; i < buffer.Length; i++)
                {
                    if (buffer[i] != 0)
                    {
                        data += buffer[i];
                    }
                    else
                    {
                        break;
                    }
                }


                if (!data.Equals(""))
                {
                    data = buffer[2] + "/" + byteArrtonumber(buffer[0], buffer[1]);
                    if (buffer[2].ToString().Length < 3)
                    {
                        data = "0" + data;
                    }

                    Handler?.Invoke(data);
                    for (int i = 0; i < buffer.Length; i++)
                    {
                        buffer[i] = 0;
                    }





                }


            }
            


        }






        #endregion



        #region public methods

        public bool Connect(ushort vid, ushort pid)
        {
            VID = vid;
            PID = pid;

            if (vid==0 && pid==0)
            {
                return false;
            }

            SendReport(1);

            if (SendReport(2) == SLABHIDTOUART.HID_UART_SUCCESS)
            {
                
                UpdateThread = new Thread(UpdateCycle);
                isConnect = true;
                UpdateThread.Start();
                return true;

            }
            else
            {
                return false;
            }

        }

        public bool Disconnect()
        {
            if (VID == 0 || PID == 0)
            {
                return false;
            }

            isConnect = false;
            Thread.Sleep(200);
            if (SendReport(3) == SLABHIDTOUART.HID_UART_SUCCESS)
            {
                
                device = IntPtr.Zero;
                device = new IntPtr();
                



                return true;
            }

            return false;

        }



        #endregion


        #region private methods

        private int byteArrtonumber(byte b0, byte b1)
        {
            int i1 = (int)b1 << 8;
            int i0 = b0;

            int res = i0 | i1;

            return res;
        }


        int SendReport(int index)
        {
            int result;

            lock (balanceLock)
            {
                switch (index)
                {
                    case 1:
                        {
                            result = SLABHIDTOUART.HidUart_GetNumDevices(ref NumDevices, VID, PID);

                            break;
                        }

                    case 2:
                        {

                            result = SLABHIDTOUART.HidUart_Open(ref device, 0, VID, PID);

                            break;
                        }

                    case 3:
                        {
                            result = SLABHIDTOUART.HidUart_Close(device);

                            break;
                        }
                    case 4:
                        {
                            result = SLABHIDTOUART.HidUart_Read(device, buffer, numBytesToRead, ref numBytesRead);

                            break;
                        }

                    default:
                        {
                            result = -1;

                            break;
                        }

                }
            }



            return result;
        }





        #endregion










    }
}
