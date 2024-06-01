// Class SocketManager dùng để quản lý Client và Server
// Mô hình cờ caro được phát triển theo một form vừa là Client vừa là Server
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Runtime.Serialization.Formatters.Binary;
using System.Net.NetworkInformation;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;


namespace CARO_GAME
{
    public class SocketManager
    {
        #region Client
        Socket client; // Trường hợp client là server

        // Kiểm tra kết nối đến Server
        public bool ConnectServer()
        {
            IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(IP),PORT);
            client = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            try
            {
                client.Connect(ipEndpoint);
                return true;
            }
            catch(Exception ex) 
            {
                return false;
            }

            return false;
        }
        #endregion

        #region Server
        Socket server;
        public void CreateServer()
        {
            IPEndPoint ipEndpoint = new IPEndPoint(IPAddress.Parse(IP), PORT);
            server = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

            server.Bind(ipEndpoint);
            server.Listen(10); // Lắng nghe kết nối trong vòng 10s

            Thread acceptClient = new Thread(() => // Anonymous method, muốn truyền tham số thì phải truyền object, kiểu trả về là void
            {
                client = server.Accept();
            });
            // Thuộc tính IsBackground xác định liệu một thread là background thread hay foreground
            // Background thread: Là các thread hoạt động trong nền và không ngăn ứng dụng kết thúc. 
            //  Khi công việc chính kết thúc (ứng dụng chính kết thúc), công việc nền tự động dừng lại, giúp giải phóng tài nguyên hệ thống.
            // Tránh ngốn tài nguyên hệ điều hành tránh tình trạng các công việc không quan trọng tiếp tục chạy và ngốn tài nguyên hệ điều hành sau khi ứng dụng chính đã kết thúc.
            acceptClient.IsBackground = true; 
            acceptClient.Start();
        }
        #endregion

        #region For both 
        public string IP = "127.0.0.1";
        public int PORT = 9999;
        public bool isServer = true;
        public const int BUFFER = 1024;

        public bool Send (object data)
        {
            byte[] sentData = SerializeData(data);
            return SendData(client, sentData);

        }

        public object Receive()
        {
            byte[] receivedData = new byte[BUFFER];
            bool isOK = ReceivedData(client, receivedData);
            return DeserializeData(receivedData);
        }

        // Kiểm tra dữ liệu có được gửi thành công hay không
        // Phải biết đã gửi Socket nào,  đã gửi tin nào
        private bool SendData(Socket target, byte[] data)
        {
            return target.Send(data) == 1 ? true : false;
        }

        // Kiểm tra dữ liệu có được nhận thành công hay không
        // Phải biết đã nhận Socket nào, đã nhận tin nào
        // Hiểu đơn giản ref là tham chiếu
        private bool ReceivedData(Socket target, byte[] data) 
        {
            return target.Receive(data) == 1 ? true : false;
        }

        //Nén đối tượng thành mảng byte[]
        public byte[] SerializeData(Object o)
        {
            // Tạo đối tượng mang tên ms của lớp MemoryStream => Tạo Stream để lưu trữ
            MemoryStream ms = new MemoryStream();
            BinaryFormatter bf1 = new BinaryFormatter();
            bf1.Serialize(ms, o);
            return ms.ToArray();
        }

        //Giải nén mảng byte[] thành đối tượng object
        public object DeserializeData(byte[] theByteArray)
        {
            MemoryStream ms = new MemoryStream(theByteArray);
            BinaryFormatter bf1 = new BinaryFormatter();
            ms.Position = 0;
            return bf1.Deserialize(ms);
        }
        
        // Lấy IPv4 của card mạng đang dùng 
        public string GetLocalIPv4(NetworkInterfaceType _type)
        {
            string output = "";
            foreach (NetworkInterface item in NetworkInterface.GetAllNetworkInterfaces())
            {
                if (item.NetworkInterfaceType == _type && item.OperationalStatus == OperationalStatus.Up)
                {
                    foreach (UnicastIPAddressInformation ip in item.GetIPProperties().UnicastAddresses)
                    {
                        if (ip.Address.AddressFamily == AddressFamily.InterNetwork)
                        {
                            output = ip.Address.ToString();
                        }
                    }
                }
            }
            return output;
        }
        #endregion
    }
}
