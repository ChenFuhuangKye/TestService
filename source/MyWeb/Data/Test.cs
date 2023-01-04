using Microsoft.AspNetCore.Http;
using MyWeb.Pages;
using System.Diagnostics;
using System.Net;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;

namespace MyWeb.Data
{
    public class Test
    {
        public string test(IPEndPoint endPoint)
        {
            var times = new List<double>();                        
            var sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            string result = null;
            sock.Blocking = true;
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            try
            {
                sock.Connect(endPoint);
            }
            catch
            {
                return "Service Do Not Work";
            }
            stopwatch.Stop();            
            double t = stopwatch.Elapsed.TotalMilliseconds;
            //Console.WriteLine("{0:0.00}ms", t);
            //result = "";
            sock.Close();
            Thread.Sleep(1000);
            return "Service Work";
            
        }
    

    }
    
}