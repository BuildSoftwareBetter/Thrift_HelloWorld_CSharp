using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;

namespace Thrift_HelloWorld_CSharp
{
    public class HelloWorldServer : HelloWorldService.Iface
    {
        public static void Run(int port)
        {
            HelloWorldServer client = new HelloWorldServer();
            HelloWorldService.Processor processor = new global::HelloWorldService.Processor(client);
            TServerTransport transport = new TServerSocket(port);
            TServer server = new TThreadPoolServer(processor, transport);

            Console.WriteLine("Starting the server...");

            server.Serve();

            transport.Close();
        }

        public void SayHello(string msg)
        {
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm:ss} {1}", DateTime.Now, msg));
        }
    }
}
