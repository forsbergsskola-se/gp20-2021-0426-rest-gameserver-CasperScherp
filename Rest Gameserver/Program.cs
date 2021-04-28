using System;
using System.Net;
using System.Net.Sockets;

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
                tcpClient.GetStream();
                
                
                
                
                tcpClient.Close();
            }
        }
        
        
            
            
            
            
        }
    }
}
