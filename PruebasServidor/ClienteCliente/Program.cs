using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;


namespace ClienteCliente
{
    class Program
    {
        static void Main(string[] args)
        {
            const string IP_Server = "127.0.0.1";
            string msg;
            string userMsg;

            IPEndPoint ie = new IPEndPoint(IPAddress.Parse(IP_Server), 31416);
            Console.WriteLine("Starting client. Press a key to init connection");
            Console.ReadKey();
            using (Socket s = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp))
            {
                try
                {
                    s.Connect(ie);
                }
                catch (SocketException e)
                {
                    Console.WriteLine("Error connection: {0}\nError code: {1}({2})",e.Message, (SocketError)e.ErrorCode, e.ErrorCode);
                    Console.ReadKey();
                    return;
                }
                using (NetworkStream ns = new NetworkStream(s))
                using(StreamReader sIn=new StreamReader(ns))
                using(StreamWriter sOut=new StreamWriter(ns))
                {
                    msg = sIn.ReadLine();
                    Console.WriteLine(msg);
                    while (true)
                    {
                        userMsg = Console.ReadLine();
                        sOut.WriteLine(userMsg);
                        sOut.Flush();
                        msg = sIn.ReadLine();
                        Console.WriteLine(msg);
                    }

                }
                Console.WriteLine("Ending connection");
            }
            
        }
    }
}
