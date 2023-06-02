using System;
using System.Text;
using System.Net;
using System.Net.Sockets;

namespace server
{
    class Program
    {

        static object locK = new object(); // để có thể chuy cập vào riêng client của nó
        static Dictionary<int, TcpClient> listClients = new Dictionary<int, TcpClient>(); //lưu trữ các list người dùng
        static void Main()
        {

            int count = 1;
            //tạo server
            TcpListener address = new TcpListener(IPAddress.Parse("127.0.0.1"), 888);
            address.Start();
            Console.WriteLine("Sever is listening... ");
            //cách thứ hoạt động của server
            while (true)
            {

                TcpClient client = address.AcceptTcpClient(); //lắng nghe
                lock (locK) listClients.Add(count, client); //thêm vào list phụ thuộc vào count để để có thứ tự
                
                Thread t = new Thread(handleClients);//chạy song song đa luồng
                t.Start(count);
                count++;
                
            }
        }
        public static void handleClients(object o)
        {
            int id = (int)o; //ép kiểu 
            TcpClient client;
            TcpClient namechat;

            lock (locK) client = listClients[id];
            lock (locK) namechat = listClients[id];

            while (true)
            {
                NetworkStream stream = client.GetStream();
                NetworkStream stream_namechat = namechat.GetStream();
                byte[] buffer = new byte[1024];
                int byte_count = stream.Read(buffer, 0, buffer.Length);
                // điều kiện đóng server
                if (byte_count == 0)
                {
                    
                    byte[] namec = new byte[1024];
                    int namec_count = stream_namechat.Read(namec,0,namec.Length);
                    string nameData = Encoding.ASCII.GetString(namec,0,namec_count);
                    Console.Write($"{nameData} disconnect connect... ");
                    break;
                }

                string data = Encoding.ASCII.GetString(buffer, 0, byte_count);
                Broadcast(data);
                Console.WriteLine(data);
            }

            lock (locK) listClients.Remove(id);
            client.Client.Shutdown(SocketShutdown.Both);
            client.Close();
        }

        public static void Broadcast(string data)//phát dữ liệu cho các client khác
        {
            byte[] buffer = Encoding.ASCII.GetBytes(data + Environment.NewLine);

            lock (locK)
            {
                foreach (TcpClient c in listClients.Values)
                {
                    NetworkStream stream = c.GetStream();

                    stream.Write(buffer, 0, buffer.Length);
                }
            }
        }
    }
}