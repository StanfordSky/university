using System;
using System.Net.Sockets;
using System.Net;
using System.Text;

class WebServer
{
    private Socket server;

    public WebServer(int port)
    {
        // Создаём сокет
        server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.IP);
        server.Bind(new IPEndPoint(IPAddress.Loopback, port));
    }

    public void run()
    {
        server.Listen(10);
        Console.WriteLine("Сервер запущен. Ожидание подключения...");
        while (true)
        {
            //Ожидаем подключения клиента
            Socket socket = server.Accept();
            HandleClientSession(socket);
        }
    }

    private void HandleClientSession(Socket socket)
    {
        Console.WriteLine("Выполнение запроса..");

        string one = SocketRead(socket);
        Console.WriteLine(one);

        string line;

        do
        {
            line = SocketRead(socket);
            if (line != null)
                Console.WriteLine(line);
        } while (line != null && line.Length > 0);


        // функция для отправки ответа клиенту
        SocketWrite(socket, "HTTP/1.1. 200 OK");
        SocketWrite(socket, "");
        SocketWrite(socket, "");

        socket.Close();
    }
    private string SocketRead(Socket socket)
    {
        StringBuilder result = new StringBuilder();
        byte[] buffer = new byte[1];


        // Читаем запрос от клиента
        while (socket.Receive(buffer) > 0)
        {
            char c = (char)buffer[0];
            if (c == '\n')
                break;
            else if (c != '\r')
                result.Append(c);
        }

        return result.ToString();
    }

    private void SocketWrite(Socket socket, string str)
    {
        //Рускоязычная кодировка
        Encoding encoding = Encoding.GetEncoding(1251);

        //Отправляем ответ
        socket.Send(encoding.GetBytes(str));
        socket.Send(encoding.GetBytes("\r\n"));
    }

    

    static void Main(string[] arg)
    {
        WebServer server = new WebServer(80);
        server.run();
    }
}