using System;
using System.IO;
using System.Net.Sockets;


namespace Вебинар
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Введите запрос типа: pagesaver selin.in.ua/index.html output.html");
            var request = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            var serverAddr = request[1].Split("/")[0];
            //var a = $@"D:\";
            var Path = request[2];
            Console.WriteLine("tcp client");

            var message = $"GET /index.html HTTP/1.0\n\n";

            try
            {
                var port = 80;

                var client = new TcpClient(serverAddr, port);
                var data = System.Text.Encoding.ASCII.GetBytes(message);
                NetworkStream stream = client.GetStream();

                stream.Write(data, 0, data.Length);
                stream.Flush();
                Console.WriteLine("Sent {0}", message);

                var responseData = new byte[65536];
                int bytesRead = stream.Read(responseData, 0, responseData.Length);
                var responseMessage = System.Text.Encoding.ASCII.GetString(responseData, 0, bytesRead);
                Console.WriteLine("Receive {0}\n", responseMessage);
                stream.Close();
                client.Close();

                try
                {
                    responseMessage = responseMessage.Substring(responseMessage.IndexOf("\n\n"));

                    using (StreamWriter sw = new StreamWriter(Path, false, System.Text.Encoding.Default))
                    {
                        sw.WriteLine(responseMessage);
                    }

                    Console.WriteLine("Запись выполнена");
                }
                catch (Exception e)
                {

                    Console.WriteLine(e);
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }
    }
}
