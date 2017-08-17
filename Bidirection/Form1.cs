using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Thrift_HelloWorld_CSharp.Bidirection
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        int SrvPort
        {
            get
            {
                return Convert.ToInt32(this.txbSrvPort.Text);
            }
        }

        int CliPort
        {
            get
            {
                return Convert.ToInt32(this.txbCliPort.Text);
            }
        }

        string Msg
        {
            get
            {
                return this.txbMsg.Text;
            }
        }

        string SrvMsg
        {
            get
            {
                return this.txbSrvMsg.Text;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartServer));
            t.Start();

            button1.Enabled = false;
        }

        void StartServer()
        {
            HelloWorldBidirectionServer srv = new Thrift_HelloWorld_CSharp.HelloWorldBidirectionServer();
            srv.Run(SrvPort);
        }


        private void button3_Click(object sender, EventArgs e)
        {
            HelloWorldBidirectionServer srv = new Thrift_HelloWorld_CSharp.HelloWorldBidirectionServer();
            srv.SayToClient(SrvMsg);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            HelloWorldBidirectionClient client = new HelloWorldBidirectionClient();
            client.ConnectAndListern(CliPort);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                HelloWorldBidirectionClient client = new HelloWorldBidirectionClient();
                client.Say(Msg);
            }
                ));

          
        }
    }
}
