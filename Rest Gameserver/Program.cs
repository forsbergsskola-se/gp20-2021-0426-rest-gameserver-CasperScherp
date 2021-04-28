using System;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Text;

namespace gp20_2021_0426_rest_gameserver_CasperScherp
{
    public class Program
    {
        static void Main(string[] args)
        {
            var tcpClient = new TcpClient("acme.com",80);
            var stream = tcpClient.GetStream();
            var bytes = Encoding.ASCII.GetBytes("GET / HTTP/1.1\r\nHost: acme.com\r\n\r\n");
            //var streamWriter = new StreamWriter(tcpClient.GetStream());
            //streamWriter.Write();
            var streamReader = new StreamReader(tcpClient.GetStream());
            var result = streamReader.ReadToEnd();
            Console.WriteLine(result);

        }
        
        
            
            
            
            
        }
    }

