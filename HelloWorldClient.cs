using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift;
using Thrift.Protocol;
using Thrift.Transport;

namespace Thrift_HelloWorld_CSharp
{
    public static class HelloWorldClient
    {
        public static void Say(int port, string msg, string ip = "127.0.0.1")
        {
            TTransport transport = new TSocket(ip, port);
            TProtocol protocol = new TBinaryProtocol(transport);
            HelloWorldService.Client client = new HelloWorldService.Client(protocol);

            transport.Open();
            try
            {
                client.SayHello(msg);
            }
            catch (TApplicationException x)
            {
                Console.WriteLine(x.StackTrace);

            }
            finally
            {
                transport.Close();
            }
        }
    }


}
