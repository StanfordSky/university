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
        //команда фтп LIST
        ftpRequest.Method = WebRequestMethods.Ftp.ListDirectoryDetails;

        //Получаем входящий поток
        ftpResponse = (FtpWebResponse)ftpRequest.GetResponse();

        //переменная для хранения всей полученной информации
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

            // пишем считанный в массив байтов файл в выходной поток
            Stream requestStream = request.GetRequestStream();
            requestStream.Write(fileContents, 0, fileContents.Length);
            requestStream.Close();

            // получаем ответ от сервера в виде объекта FtpWebResponse
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
