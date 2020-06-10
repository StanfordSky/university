using System;
using System.Text;
using System.Threading;
using System.IO;
using System.Net.Sockets;
using System.Net;
using System.Text.RegularExpressions;

namespace HTTPServer
{
    class Client
    {
        static void Main(string[] args)
        {
            int MaxThreadsCount = Environment.ProcessorCount * 4;
            ThreadPool.SetMaxThreads(MaxThreadsCount, MaxThreadsCount);
            ThreadPool.SetMinThreads(2, 2);
            new Server(80);
        }
        private void SendError(TcpClient Client, int Code)
        {
            string CodeStr = Code.ToString() + " " + ((HttpStatusCode)Code).ToString();
            string Html = "<html>\n<title>" + 
                CodeStr + "</title>\n<body>\n<h1>" + 
                CodeStr + "</h1>\n</hr>Kremp Server 2020 by Lyadov</body>\n</html>";

            string Str = "HTTP/1.1 " +
                CodeStr + 
                "\nContent-type: text/html\nContent-Length:" + 
                Html.Length.ToString() + 
                "\n\n" + Html;

            byte[] Buffer = Encoding.ASCII.GetBytes(Str);
            Client.GetStream().Write(Buffer, 0, Buffer.Length);
            Client.Close();
        }

        public Client(TcpClient Client)
        {
            string Request = "";
            byte[] Buffer = new byte[1024]; 
            int Count;

            while ((Count = Client.GetStream().Read(Buffer, 0, Buffer.Length)) > 0) // Читаем из потока клиента до тех пор, пока от него поступают данные
            {
                Request += Encoding.ASCII.GetString(Buffer, 0, Count);
                if (Request.IndexOf("\r\n\r\n") >= 0 || Request.Length > 4096)
                {
                    break;
                }
            }

            Match Implement = Regex.Match(Request, @"^GET");
            bool lyadov_task = Request.Contains("/secret/");
            Match ReqMatch = Regex.Match(Request, @"^GET+\s+([^\s\?]+)[^\s]*\s+HTTP/.*|");

            if (Implement == Match.Empty) // Отлавливаем ошибку 501 - не реализовано
            {
                SendError(Client, 501);
                return;
            }

            if (lyadov_task) // Отлавливаем ошибку 410 - Gone.
            {
                SendError(Client, 410);
                return;
            }

            string RequestUri = ReqMatch.Groups[1].Value;
            RequestUri = Uri.UnescapeDataString(RequestUri);

            // Если строка запроса оканчивается на "/", то добавим к ней index.html
            if (RequestUri.EndsWith("/"))
            {
                RequestUri += "index.html";
            }

            string FilePath = "D:/HTTPserver" + RequestUri;
            
            if (!File.Exists(FilePath)) // Если в папке не существует данного файла, посылаем ошибку 404
            {
                SendError(Client, 404);
                return;
            }

            // Получаем расширение файла из строки запроса
            string Extension = RequestUri.Substring(RequestUri.LastIndexOf('.'));

            // Тип содержимого
            string ContentType = "";

            // Пытаемся определить тип содержимого по расширению файла
            switch (Extension)
            {
                case ".htm":
                case ".html":
                    ContentType = "text/html";
                    break;
                case ".css":
                    ContentType = "text/css";
                    break;
                case ".txt":
                    ContentType = "text/plain";
                    break;
                case ".js":
                    ContentType = "text/javascript";
                    break;
                case ".jpg":
                    ContentType = "image/jpeg";
                    break;
                case ".jpeg":
                case ".png":
                case ".gif":
                    ContentType = "image/" + Extension.Substring(1);
                    break;
                default:
                    if (Extension.Length > 1)
                    {
                        ContentType = "application/" + Extension.Substring(1);
                    }
                    else
                    {
                        ContentType = "application/unknown";
                    }
                    break;
            }

            FileStream FS;
            try
            {
                FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read, FileShare.Read);
            }
            catch (Exception)
            {
                SendError(Client, 500);
                return;
            }

            string Headers = "HTTP/1.1 200 OK\nContent-Type: " + ContentType + "\nContent-Length: " + FS.Length + "\n\n";
            byte[] HeadersBuffer = Encoding.ASCII.GetBytes(Headers);
            Client.GetStream().Write(HeadersBuffer, 0, HeadersBuffer.Length);

            while (FS.Position < FS.Length)
            {
                Count = FS.Read(Buffer, 0, Buffer.Length);  // Читаем данные из файла
                Client.GetStream().Write(Buffer, 0, Count); // И передаем их клиенту
            }
            // Закроем файл и соединение
            FS.Close();
            Client.Close();
        }
    }

    class Server
    {
        TcpListener Listener; // Объект, принимающий TCP-клиентов

        // Запуск сервера
        public Server(int Port)
        {
            Listener = new TcpListener(IPAddress.Any, Port); 
            Listener.Start(); 


            while (true)
            {
                // Принимаем новых клиентов. После того, как клиент был принят, он передается в новый поток (ClientThread)
                ThreadPool.QueueUserWorkItem(new WaitCallback(ClientThread), Listener.AcceptTcpClient());
            }
        }

        static void ClientThread(Object StateInfo)
        {
            new Client((TcpClient)StateInfo);
        }

        // Остановка сервера
        ~Server()
        {
            if (Listener != null)
            {
                Listener.Stop();
            }
        }
    }
}
