using System.Net;

namespace MyWeb.Data
{
    public class TestService
    {
        public string test(string ip,int port)
        {
            Test hping = new Test();
            IPEndPoint ipe;
            try
            {
                ipe = new IPEndPoint(IPAddress.Parse(ip), port);
            }
            catch
            {
                return "Input right ip or port";
            }
            return hping.test(ipe);
        }
    }
}