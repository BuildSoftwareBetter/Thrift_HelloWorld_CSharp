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

namespace Thrift_HelloWorld_CSharp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Thread t = new Thread(new ThreadStart(StartServer));
            t.Start();

            button1.Enabled = false;

            //await Task.Run(new Action(() =>
            //  {
            //      HelloWorldServer.Run(SrvPort);
            //  }
            //  ));
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Task.Run(new Action(() =>
            {
                HelloWorldClient.Say(CliPort, Msg);
            }
                ));
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

        void StartServer()
        {
            HelloWorldServer.Run(SrvPort);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Bidirection.Form1 form = new Bidirection.Form1();
            form.Show();
        }
    }
}
