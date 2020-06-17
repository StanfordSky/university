/*
 Custom FTP client, implemented as laboratory report No. 12, subject "Computer Networks and Telecommunications".

Implemented student of the group 18-PRI-rps-B - Lyadov Vyacheslav Serveevich

Implemented functions:
- Connection to FTP server;
- Browse the catalog (LIST)
- Individual task

The program is implemented using FtpWebRequest, FtpWebResponse
*/
using System;
using System.IO;
using System.Net;
using System.Text;

class FtpClient
{
    static string Host;
    static string UserName;
    static string Password;
    static string Path;
    static string CMD;
    static FtpWebRequest ftpRequest;
    static FtpWebResponse ftpResponse;

    static public void Main()
    {
        Console.WriteLine("Добро пожаловать в клиент Kremp для работы с FTP сервером.");
        Console.WriteLine("Информацию по командам FTP клиента - /help.");
        
        ConnectFTP();

        Console.Write("Режим(Активный-POST/Пассивный-PASV): ");
        CMD = Console.ReadLine();
        if (CMD == "POST")
        {
            ftpRequest.UsePassive = false;
        }
        else if (CMD == "PASV")
        {
            ftpRequest.UsePassive = true;
        }

        while (true)
        {
            Console.Write(" > ");
            CMD = Console.ReadLine();
            if (CMD == "LIST")
            {
                ListDirectory();
            }
            else if (CMD == "LYADOVTASK")
            {
                LyadovTask();
            }
            else if (CMD == "HELP")
            {
                HELP();
            }
        }
    }

    private static void ConnectFTP()
    {
        Console.Write("Адрес FTP сервера: ");
        Host = Console.ReadLine();

        Console.Write("Логин: ");
        UserName = Console.ReadLine();

        Console.Write("Пароль: ");
        Password = Console.ReadLine();

        if (Path == null || Path == "")
        {
            Path = "/";
        }
        
        ftpRequest = (FtpWebRequest)WebRequest.Create("ftp://" + Host + Path);
        ftpRequest.Credentials = new NetworkCredential(UserName, Password);
    }

    private static void ListDirectory()
    {
        //Command LIST
        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

        //Receive Thread
        ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

        //Buffer for Response from server
        string content = "";

        StreamReader sr = new StreamReader(ftpResponse.GetResponseStream(), System.Text.Encoding.ASCII);
        content = sr.ReadToEnd();

        sr.Close();
        ftpResponse.Close();

        Console.Write("\nСодержимое папки " + Path + ":\n" + content + "\n");
    }

    private static void LyadovTask()
    {
        Console.Write("\nОписание индивидуального задания:\n\n" +
            "Вариант 12 - Программа флудер: " +
            "\nна сервере создается указанное пользователем число файлов ненулевой длины с уникальными именами " +
            "(тем самым уменьшается свободное место на сервере).\n");

        Console.Write("Введите количество папок, которое требуеться создать: ");
        int CountFiles = Convert.ToInt32(Console.ReadLine());


        for (int i = 1; i <= CountFiles; i++)
        {

            File.WriteAllText(i + ".txt", "This is some text in the file.");
            FtpWebRequest request = (FtpWebRequest)WebRequest.Create("ftp://127.0.0.1/" + i + ".txt");
            request.Method = WebRequestMethods.Ftp.UploadFile;

            FileStream fs = new FileStream(i + ".txt", FileMode.Open);
            byte[] fileContents = new byte[fs.Length];
            fs.Read(fileContents, 0, fileContents.Length);
            fs.Close();
            request.ContentLength = fileContents.Length;

            // file to output stream
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            // we get a response from the server as an FtpWebResponse object
            FtpWebResponse response = (FtpWebResponse)request.GetResponse();
            Console.WriteLine("Сервер: файл " + i + ".txt + загружен на сервер - " + response.StatusDescription);

            File.Delete(i + ".txt");
        }
    }

    private static void HELP()
    {
        Console.WriteLine("\n======================\n" +
            "Клиент разработан студентом группы О-18-ПРИ-рпс-Б, Лядов В.С., Вариант 12.\n" +
            "Список команд:\n" +
            "- HELP - справка по командам.\n" +
            "- LIST - вывод текущей директории(файлы, папки).\n" +
            "- LYADOVTASK - задание по варианту.\n" +
            "- PASV - использовать пассивный режим.\n" +
            "- POST - использовать активный режим.");
    }
}
