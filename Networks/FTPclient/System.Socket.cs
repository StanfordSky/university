/*
 Custom FTP client, implemented as laboratory report No. 12, subject "Computer Networks and Telecommunications".

Implemented student of the group 18-PRI-rps-B - Lyadov Vyacheslav Serveevich

Implemented functions:
- Connection to FTP server;
- Browse the catalog (LIST)
- Individual task

The program is implemented using socket technology
*/

using System;
using System.Text;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Collections.Generic;

namespace ConsoleApplication5
{
    class Program
    {
        public class FtpClient
        {
            public string ConnectionServer(string host)
            {
                // Variables for Listening Socket
                IPHostEntry hostEntry = Dns.GetHostEntry(host);
                IPEndPoint ipe = null;
                Socket Socket = null;
                
                int port = 21;
                string message;
                int portpasv = 1;
                try
                {
                    //Parse addresses and connect
                    foreach (IPAddress address in hostEntry.AddressList)
                    {
                        ipe = new IPEndPoint(address, port);
                        Socket = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                        Socket.Connect(ipe);
                        Console.WriteLine("Сервер: " + Response(ref Socket));
                    }

                    while(true)
                    {
                        Console.Write(" > ");
                        message = Console.ReadLine();
                        message = message + "\r\n";
                        byte[] buffer = Encoding.ASCII.GetBytes(message);
                        if (message == "QUIT\r\n") 
                        {
                            break;
                        }
                        else if (message == "LIST\r\n") // Command LIST
                        {
                            portpasv = PASV(ref Socket);
                            LIST(host, portpasv, ref Socket);                       
                            continue;
                        }
                        else if (message == "LYADOVLIST\r\n") // Commnd personal task
                        {
                            Console.Write("\nОписание индивидуального задания:\n\n" +
                         "Вариант 12 - Программа флудер: " +
                         "\nна сервере создается указанное пользователем число файлов ненулевой длины с уникальными именами " +
                         "(тем самым уменьшается свободное место на сервере).\n");

                            Console.Write("\nВведите количество файлов, которое должно быть создано: ");
                            int count = Convert.ToInt32(Console.ReadLine());
                           
                            for (int i = 1; i <= count; i++)
                            {   
                                try
                                {
                                    portpasv = PASV(ref Socket);
                                }
                                catch
                                {
                                    Response(ref Socket);
                                    portpasv = PASV(ref Socket);
                                }
                                LYADOVTASK(host, portpasv, ref Socket, i.ToString());
                            }                
                            continue;
                        }
                        Socket.Send(buffer, buffer.Length, 0);
                        Console.WriteLine("Сервер: " + Response(ref Socket));
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }

                Socket.Close();
                return "\nConnection closed.\n";
            }

            private int PASV(ref Socket Socket)
            {
                string message = "PASV\r\n";
                byte[] buffer = Encoding.ASCII.GetBytes(message);
                Socket.Send(buffer, buffer.Length, 0);
                string portreceive = Response(ref Socket);
                int one = 0, two = 0;

                // We get data for computing the Port
                try
                {
                    one = Convert.ToInt32(portreceive.Split(',')[4]);
                    two = Convert.ToInt32(portreceive.Split(',')[5].Split(')')[0]);
                }
                catch
                {
                    portreceive = Response(ref Socket);
                    one = Convert.ToInt32(portreceive.Split(',')[4]);
                    two = Convert.ToInt32(portreceive.Split(',')[5].Split(')')[0]);
                }
                return one * 256 + two;
            }

            private void LIST(string host, int portpasv, ref Socket socket)
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(host);
                IPEndPoint ipe = null;
                Socket dataSock = null;

                List<string> retObj = new List<string>();

                string dataSockMsg = "", message;
                byte[] buffer = new byte[256];

                foreach (IPAddress address in hostEntry.AddressList)
                {
                    ipe = new IPEndPoint(address, portpasv);
                    dataSock = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    dataSock.Connect(ipe);
                }

                message = "LIST\r\n";
                Console.WriteLine("\nСодержимое директории:\n");
                buffer = Encoding.ASCII.GetBytes(message);
                socket.Send(buffer, buffer.Length, 0);
                dataSockMsg = Response(ref dataSock);
                string[] messageobj = dataSockMsg.Split(new string[] { "\r\n" }, StringSplitOptions.RemoveEmptyEntries);

                foreach (string obj in messageobj)
                {
                    retObj.Add(obj);
                    Console.WriteLine(" - : " + obj);
                }

                Console.WriteLine("\n");                  
                dataSock.Close();
            }

            private void LYADOVTASK(string host, int portpasv, ref Socket socket, string filename)
            {
                IPHostEntry hostEntry = Dns.GetHostEntry(host);
                IPEndPoint ipe = null;
                Socket dataSock = null;

                byte[] buffer = new byte[256];

                foreach (IPAddress address in hostEntry.AddressList)
                {
                    ipe = new IPEndPoint(address, portpasv);
                    dataSock = new Socket(ipe.AddressFamily, SocketType.Stream, ProtocolType.Tcp);
                    dataSock.Connect(ipe);
                }

                File.WriteAllText(filename + ".txt", "This is some text in the file.");
                Console.WriteLine("\nЗагрузка файла на сервер...");
                buffer = Encoding.ASCII.GetBytes("STOR " + filename + ".txt" + "\r\n");
                socket.Send(buffer, buffer.Length, 0);
                dataSock.SendFile(filename + ".txt");
                dataSock.Close();
            }


            private string Response(ref Socket temp)
            {
                try
                {
                    // Buffer for Response
                    StringBuilder builder = new StringBuilder();
                    int bytes = 0;
                    byte[] data = new byte[2048];
                    do
                    {
                        bytes = temp.Receive(data, data.Length, 0);
                        builder.Append(Encoding.ASCII.GetString(data, 0, bytes));
                    }
                    while (temp.Available > 0);
                    return builder.ToString();
                }

                catch(Exception ex)
                {
                    Console.WriteLine("Ошибка от сервера: " + ex.Message);
                }

                return "error";
            }
        }



        static void Main(string[] args)
        {
            FtpClient client = new FtpClient();
            Console.Write("Adress FTP: ");
            string host = Console.ReadLine();
            Console.WriteLine(client.ConnectionServer(host));
            Console.ReadLine();
        }
    }
}