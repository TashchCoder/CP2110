using SLABHIDTOUART_DLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApp5
{
    public partial class Form1 : Form
    {

        // ПЕРЕМЕННЫЕ......................................................................

        //используется для вывода состояния и запуска\остановки цикла чтения
        public bool isActive;
        //буфер предварительной записи данных со считывателя
        byte[] buffer;
        //сюда записываются данные из буфера buffer
        string data;
        //объект, ассоциирующийся со считывателем
        IntPtr device;
        // Vendor ID и Product ID - идентификаторы устройства
        ushort vid;
        ushort pid;
        //путь к файлу логов
        string path;
        //переменные для получения данных от считывателя
        uint numBytesToRead;
        uint numBytesRead;
        // количество найденных устройств с заданными значениями VID и PID
        uint NumDevices;

        //объект чисто для лока метода запросов SendReport
        private readonly object balanceLock;



        // КНОПКИ И ФОРМЫ...................................................................

        public Form1()
        {
            //закрытие соединения с устройством в случае закрытия приложения с открытым соединением 
            FormClosing += CloseConnectionWithFormClosing;

            device = new IntPtr();
            path = Directory.GetCurrentDirectory() + "\\log.txt";
            isActive = false;
            data = "";
            InitializeComponent();
            buffer = new byte[32768];
            for (int i = 0; i < buffer.Length; i++)
            {
                buffer[i] = 0;
            }
            numBytesToRead = 32768;
            numBytesRead = 0;
            NumDevices = 0;
            balanceLock = new object();
            //запуск потока чтения
            ReadDataNew();

        }

        //кнопка подключения к устройству
        private void OpenButton_Click(object sender, EventArgs e)
        {

            //проверка на открытое/закрытое состояние
            //открытие
            //

            //попытка преобразовать введённые pid и vid в шестнадцатеричную форму
            try
            {
                vid = (ushort)Convert.ToInt32(VIDEnterTextBox.Text, 16);
                pid = (ushort)Convert.ToInt32(PIDEnterTextBox.Text, 16);
            }
            catch (Exception exc)
            {
                vid = 0x2803;
                pid = 0x0013;
                MessageBox.Show("Не удалось преобразовать введённые значения PID и VID в шестнадцатеричную форму.\n" + exc);

            }


            //проверка vid и pid на корректность
            //проверка на единственность vid и pid
            if (CheckVidPid() && IsOneDevice())
            {

                //проверка на открытое/закрытое состояние
                if (!isActive)
                {
                    
                    
                    //SLABHIDTOUART.HidUart_GetNumDevices(ref num, vid, pid);
                    SendReport(1);

                    //for (int i = 0; i < num+1; i++)
                    //{
                    //    if (SLABHIDTOUART.HidUart_Open(ref device, (uint)i, vid, pid)==0)
                    //    {
                    //        isActive = true;

                    //        StateConnectionLabel.Text = "подключено";
                    //        break;
                    //    }
                    //}

                    if (SendReport(2)==0)
                    {
                        isActive = true;
                        StateConnectionLabel.Text = "подключено";

                    }

                    if (!isActive)
                    {
                        MessageBox.Show("Ошибка подключения к устройству: " + SendReport(2));
                    }


                }
                else
                {
                    MessageBox.Show("Устройство уже подключено.");
                }

                
            }



        }


        //кнопка отключения устройства
        private void CloseButton_Click(object sender, EventArgs e)
        {
            if (isActive)
            {
                isActive = false;
                //SLABHIDTOUART.HidUart_Close(device);
                SendReport(3);

                StateConnectionLabel.Text = "отключено";
                OpenButton.Enabled = true;



            }
            else
            {
                MessageBox.Show("Нет подключённых устройств.");
            }
        }

        //кнопка открытия журнала
        private void LogButton_Click(object sender, EventArgs e)
        {
            Process.Start(path);
        }




        //ВСПОМОГАТЕЛЬНЫЕ МЕТОДЫ.................................................................


        //проверка переданного ID на соответствие формату
        bool CheckCorrectID(string ID)
        {
            int coincidence;
            char[] correctArray = new char[] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'A', 'b', 'B', 'c', 'C', 'd', 'D', 'e', 'E', 'f', 'F' };

            if (string.IsNullOrEmpty(ID) || string.IsNullOrWhiteSpace(ID))
            {
                return false;
            }

            for (int i = 0; i < ID.Length; i++)
            {
                coincidence = 0;
                for (int j = 0; j < correctArray.Length; j++)
                {
                    if (ID[i] == correctArray[j])
                    {
                        coincidence = 1;
                        break;
                    }


                }

                if (coincidence == 0)
                {
                    return false;
                }
            }

            if (ID.Length != 4)
            {
                return false;
            }

            return true;
        }


        //проверка введённых VID и PID на корректность
        bool CheckVidPid()
        {
            if (!CheckCorrectID(VIDEnterTextBox.Text))
            {
                MessageBox.Show("Некорректно введён VID");
                return false;
            }
            else
            {
                if (!CheckCorrectID(PIDEnterTextBox.Text))
                {
                    MessageBox.Show("Некорректно введён PID");
                    return false;
                }
                else
                {
                    //введены корректные pid и vid

                    return true;
                }
            }
        }

        //проверка устройства с заданным VID и PID на единственность
        bool IsOneDevice()
        {
            
            //SLABHIDTOUART.HidUart_GetNumDevices(ref NumDevices, vid, pid);
            SendReport(1);

            if (NumDevices == 1)
            {
                return true;
            }
            else if (NumDevices > 1)
            {
                MessageBox.Show("Найдено несколько устройств с указанным VID и PID. Выбрано первое из них.");

            }
            else if (NumDevices == 0)
            {
                MessageBox.Show("Не найдено устройств с указанной комбинацией VID и PID.");
            }
            return false;


        }


        //при закрытии окна проверяет устройство и, если нужно, закрывает
        private void CloseConnectionWithFormClosing(object sender, EventArgs e)
        {
            if (isActive)
            {
                SendReport(3);
                //SLABHIDTOUART.HidUart_Close(device);
            }


        }


        //если устройство активно, запрашивает из его внутреннего буфера данные
        int ChangeIndexx()
        {
            int result;


            if (isActive)
            {
                for (int i = 0; i < buffer.Length; i++)
                {
                    buffer[i] = 0;
                }

                //result = SLABHIDTOUART.HidUart_Read(device, buffer, numBytesToRead, ref numByrtesRead);
                result = SendReport(4);
                

            }
            else
            {
                result = -1;
            }
            System.Threading.Thread.Sleep(100);
            return result;
        }


        //обёртка для асинхронного вызова ChangeIndexx
        async void ReadDataNew()
        {

            int result = -1;

            while (true)
            {


                result = await Task.Run(() => ChangeIndexx());

                if (result == 0 || result == 18)
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

                    if (!data.Equals("") && !this.DataLabel.Text.Equals(data))
                    {

                        this.DataLabel.Text = "(" + DateTime.Now + ")  " + data;
                        using (var sw = new StreamWriter(path, true))
                        {
                            sw.WriteLine(DataLabel.Text);
                        }


                    }
                }





                
                




            }
        }


        //общий метод для отправки запроса считывателю

        int SendReport(int index)
        {
            int result;

            lock (balanceLock)
            {
                switch (index)
                {
                    case 1:
                        {
                            result = SLABHIDTOUART.HidUart_GetNumDevices(ref NumDevices, vid, pid);

                            break;
                        }

                    case 2:
                        {
                            
                            result = SLABHIDTOUART.HidUart_Open(ref device, 0, vid, pid);

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


    }
}
