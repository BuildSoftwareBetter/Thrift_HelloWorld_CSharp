using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Thrift;
using Thrift.Protocol;
using Thrift.Server;
using Thrift.Transport;

namespace Thrift_HelloWorld_CSharp
{
    public class HelloWorldBidirectionServer : HelloWorldBidirectionService.Iface
    {
        public void Run(int port)
        {
            try
            {
                TServerTransport transport = new TServerSocket(port);

                TTransportFactory transportFac = new TTransportFactory();

                TProtocolFactory inputProtocolFactory = new TBinaryProtocol.Factory();
                TThreadPoolServer server = new TThreadPoolServer(getProcessorFactory(), transport, transportFac, inputProtocolFactory);

                server.Serve();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public static List<TTransport> TransportCollection = new List<TTransport>();

        public void SayHello(string msg)
        {
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm:ss} 服务端接收到消息： {1}", DateTime.Now, msg));
        }

        public void SayToClient(string msg)
        {
            try
            {
                foreach (TTransport trans in TransportCollection)
                {
                    TBinaryProtocol protocol = new TBinaryProtocol(trans);
                    HelloWorldBidirectionService.Client client = new HelloWorldBidirectionService.Client(protocol);
                    //Thread.Sleep(1000);
                    client.SayHello(msg);
                    Console.WriteLine("发给了客户端哟");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public TProcessorFactory getProcessorFactory()
        {
            return new HelloWorldBidirectionProcessor();
        }
    }

    public class HelloWorldBidirectionProcessor : TProcessorFactory
    {
        public TProcessor GetProcessor(TTransport trans, TServer server = null)
        {
            if (trans.IsOpen)
            {
                HelloWorldBidirectionServer.TransportCollection.Add(trans);
                Console.WriteLine("有客户端上船啦");
            }

            HelloWorldBidirectionServer srv = new HelloWorldBidirectionServer();
            return new global::HelloWorldBidirectionService.Processor(srv);
        }
    }
}
