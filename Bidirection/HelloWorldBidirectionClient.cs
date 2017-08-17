using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Thrift.Protocol;
using Thrift.Transport;

namespace Thrift_HelloWorld_CSharp
{
    public class HelloWorldBidirectionClient
    {
        static HelloWorldBidirectionService.Client client = null;
        public void ConnectAndListern(int port, string ip = "127.0.0.1")
        {
            //Tsocket: TCP/IP Socket接口
            TSocket tSocket = new TSocket(ip, port);
            //消息结构协议
            TProtocol protocol = new TBinaryProtocol(tSocket);
            try
            {
                if (client == null)
                {
                    client = new global::HelloWorldBidirectionService.Client(protocol);
                    tSocket.Open();//建立连接
                    StartListern(tSocket);//启动监听线程
                }
                //cli.SayHello(msg);
                //tSocket.Close();
                //cli.Dispose();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        public void Say(string msg)
        {
            if (client != null)
                client.SayHello(msg);
        }

        void StartListern(TSocket tSocket)
        {
            Thread t = new Thread(new ParameterizedThreadStart(Run));
            t.Start(tSocket);
        }

        public void Run(object tSocket)
        {
            HelloWorldBidirectionService.Processor process = new HelloWorldBidirectionService.Processor(new HelloWorldBidirectionFace());

            try
            {
                while (process.Process(new TBinaryProtocol((TSocket)tSocket), new TBinaryProtocol((TSocket)tSocket)))
                {
                    Console.WriteLine("消息接收完成，等下一波，阻塞中......");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("连接断开..." + ex.Message);
            }
        }

    }
    class HelloWorldBidirectionFace : HelloWorldBidirectionService.Iface
    {
        public void SayHello(string msg)
        {
            Console.WriteLine(string.Format("{0:yyyy/MM/dd hh:mm:ss} 收到服务端响应消息 {1}", DateTime.Now, msg));

        }
    }
}
