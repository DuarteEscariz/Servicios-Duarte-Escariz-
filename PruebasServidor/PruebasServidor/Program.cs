using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace PruebasServidor
{
    class Program
    {
        static void ShowNetInfo(string name)
        {
            IPHostEntry hostInfo;
            hostInfo = Dns.GetHostEntry(name);
            Console.WriteLine("Name: {0}", hostInfo.HostName);
            Console.WriteLine("IP list:");
            foreach (IPAddress ip in hostInfo.AddressList)
            {
                if (ip.AddressFamily == AddressFamily.InterNetwork)
                {
                    Console.WriteLine("\t{0,16}", ip);
                }
                Console.WriteLine("\n");
            }

        }
        static void ShowNetInfo(IPAddress ipAddress)
        {
            IPHostEntry hostInfo = Dns.GetHostEntry(ipAddress);
            ShowNetInfo(hostInfo.HostName);
        }
        static void Main(string[] args)
        {
            String localHost = Dns.GetHostName();
            Console.WriteLine("Localhost name: {0}", localHost);
            ShowNetInfo(localHost);
            ShowNetInfo("www.google.es");
            ShowNetInfo(IPAddress.Parse("82.98.160.124"));
            Console.ReadKey();
        }
    }
}
