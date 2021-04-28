using System;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace gp20_2021_0426_rest_gameserver_CasperScherp
{
    public class Program : TcpClient
    {
        static void Main(string[] args)
        {
        var endpoint = new IPEndPoint(IPAddress.Loopback, 7777);
        {
            var tcpListener = new TcpListener(endpoint);
            tcpListener.Start();

            while (true) {
                var tcpClient = tcpListener.AcceptTcpClient();
                byte[] buffer = new byte[100];
                var responseBuffer = Encoding.ASCII.GetBytes("Hey");
                Console.WriteLine("Update"+Encoding.ASCII.GetString(buffer));
                tcpClient.GetStream().Write(responseBuffer, 0, responseBuffer.Length);
                tcpClient.GetStream().Read(buffer, 0,100);
                
                
                
                
                
                
                
                tcpClient.Close();
            }
        }
        
        
            
            
            
            
        }
    }
}
