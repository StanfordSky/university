using System;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Windows.Forms;
using ClassLibraryAnimals;
using Newtonsoft.Json;

namespace ClientForms
{
    public partial class Form1 : Form
    {
        IPHostEntry ipHost;
        IPAddress ipAddr;
        IPEndPoint ipEndPoint;
        Socket sendSocket;
        byte[] bytes;
       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            comboBoxProtectionStatus.Items.AddRange(new string[]{ 
                "Вызывающие наименьшие опасения (LC)",
                "Близкие к уязвимому положению (NT)",              
                "Уязвимые (VU)",
                "Вымирающие (EN)",
                "Находящиеся на грани полного исчезновения (CR)",
                "Исчезнувшие в дикой природе (EW)",
                "Исчезнувшие (EX)"});
            comboBoxProtectionStatus.SelectedIndex = 0;

           // Буфер для входящих данных
           bytes = new byte[10240];

            // Соединяемся с удаленным устройством

            // Устанавливаем удаленную точку для сокета
            ipHost = Dns.GetHostEntry("localhost");
            ipAddr = ipHost.AddressList[0];
            ipEndPoint = new IPEndPoint(ipAddr, 11000);
            sendSocket = new Socket(ipAddr.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
            // Соединяем сокет с удаленной точкой
            sendSocket.Connect(ipEndPoint);
        }
        private AnimalResponse SendRequest(AnimalRequest request) 
        {
            string jsonRequest = JsonConvert.SerializeObject(request);
            byte[] msg = Encoding.UTF8.GetBytes(jsonRequest);
            // Отправляем данные через сокет
            sendSocket.Send(msg);
            // Получаем ответ от сервера
            int bytesRec = sendSocket.Receive(bytes);
            var json = Encoding.UTF8.GetString(bytes, 0, bytesRec);
            var response = new AnimalResponse { IsSuccess = false };
            try
            {
                response = JsonConvert.DeserializeObject<AnimalResponse>(json);
              
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message + "\nНе удалось десериализовать",
                          "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }
            return response;
        }

        private void buttonGet_Click(object sender, EventArgs e)
        {
            var request  = new AnimalRequest
            {
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Get
            };
            var response = SendRequest(request);
            if (!response.IsSuccess)
            {
                labelResponseStatus.Text = response.ErrorMessage;
            }
            else
            {
                textBoxTitle.Text = response.Animal.Title;
                textBoxLatin_Title.Text = response.Animal.Latin_Title;
                textBoxHabitat.Text = response.Animal.Habitat;
                comboBoxProtectionStatus.Text = response.Animal.Protection_Status;
                labelResponseStatus.Text = "Запрос выполнен успешно";   
            }
        }


        private void buttonAdd_Click(object sender, EventArgs e)
        {
           
            var request = new AnimalRequest
            {
                Animal = new Animal { 
                    Title = textBoxTitle.Text,
                    Latin_Title = textBoxLatin_Title.Text,
                    Habitat = textBoxHabitat.Text,
                    Protection_Status = comboBoxProtectionStatus.Text},              

                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Add
            };
            var response = SendRequest(request);
            if (!response.IsSuccess)
            {
                labelResponseStatus.Text = response.ErrorMessage;
            }
            else
            {
                labelResponseStatus.Text = "Животное добавлено";
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            var request = new AnimalRequest
            {
                Animal = new Animal
                {
                    Title = textBoxTitle.Text,
                    Latin_Title = textBoxLatin_Title.Text,
                    Habitat = textBoxHabitat.Text,
                    Protection_Status = comboBoxProtectionStatus.Text
                },
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Update
            };
            var response = SendRequest(request);
            if (!response.IsSuccess)
            {
                labelResponseStatus.Text = response.ErrorMessage;
            }
            else
            {
                labelResponseStatus.Text = "Животное обновлено";
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var request = new AnimalRequest
            {
                Key = textBoxTitle.Text,
                Type = AnimalRequestType.Get
            };
            var response = SendRequest(request);
            if (!response.IsSuccess)
            {
                labelResponseStatus.Text = response.ErrorMessage;
            }
            else
            {
                labelResponseStatus.Text = "Животное удалено";
            }
        }
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClearAnimal_Click(object sender, EventArgs e)
        {
            textBoxTitle.Text = "";
            textBoxLatin_Title.Text = "";
            textBoxHabitat.Text = "";
            comboBoxProtectionStatus.SelectedIndex=0;
        }
    }
}
