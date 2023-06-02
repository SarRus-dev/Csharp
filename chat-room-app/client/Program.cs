using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace client
{
    class Program
    {
        static object locK = new object();
        static void Main()
        {
            List<string> nameChat = new List<string>();

            TcpClient client = new TcpClient();
            // TcpClient name_chat = new TcpClient();

            Console.Write("Sever: ");
            string? IpSever = Console.ReadLine();
            Console.Write("Your name: ");
            string? name = Console.ReadLine();

            client.Connect(IpSever ?? "", 888);

            // Thread thread_nameChat = new Thread(o => nhanData((TcpClient)o));
            Thread thread = new Thread(o => nhanData((TcpClient)o));
            thread.Start(client);
            // thread_nameChat.Start(name_chat);

            NetworkStream ns = client.GetStream();
            // NetworkStream nc = name_chat.GetStream();

            int count = 1;

            string dataChat;
            while (true)
            {
                Console.Write($"{name} chatt: ");
                dataChat = Console.ReadLine() ?? "";
                if (dataChat.ToUpper().Equals("EXIT"))
                {
                    byte[] namec = Encoding.ASCII.GetBytes($"{name}");
                    // nc.Write(namec, 0, namec.Length);
                    break;
                }
                byte[] buffer = Encoding.ASCII.GetBytes($"{name} chat: {dataChat}");
                ns.Write(buffer, 0, buffer.Length);
                nameChat.Add(count + name);
                count++;
            }

            client.Client.Shutdown(SocketShutdown.Send);
            thread.Join();

            ns.Close();
            client.Close();
            Console.WriteLine("disconnect from server!!");
            Console.ReadKey();
        }


        static void nhanData(TcpClient client)
        {
            NetworkStream ns = client.GetStream();
            byte[] receivedBytes = new byte[1024];
            int byte_count;

            while ((byte_count = ns.Read(receivedBytes, 0, receivedBytes.Length)) > 0)
            {
                Console.Write(Encoding.ASCII.GetString(receivedBytes, 0, byte_count));
            }
        }
    }
}