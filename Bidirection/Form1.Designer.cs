namespace Thrift_HelloWorld_CSharp.Bidirection
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txbCliPort = new System.Windows.Forms.TextBox();
            this.txbMsg = new System.Windows.Forms.TextBox();
            this.txbSrvPort = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txbSrvMsg = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 184);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 15;
            this.label3.Text = "发送  消息：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(92, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 14;
            this.label2.Text = "服务端端口：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 135);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 13;
            this.label1.Text = "客户端端口：";
            // 
            // txbCliPort
            // 
            this.txbCliPort.Location = new System.Drawing.Point(175, 132);
            this.txbCliPort.Name = "txbCliPort";
            this.txbCliPort.Size = new System.Drawing.Size(100, 21);
            this.txbCliPort.TabIndex = 12;
            this.txbCliPort.Text = "1234";
            // 
            // txbMsg
            // 
            this.txbMsg.Location = new System.Drawing.Point(175, 179);
            this.txbMsg.Name = "txbMsg";
            this.txbMsg.Size = new System.Drawing.Size(265, 21);
            this.txbMsg.TabIndex = 11;
            this.txbMsg.Text = "HelloWorld";
            // 
            // txbSrvPort
            // 
            this.txbSrvPort.Location = new System.Drawing.Point(175, 29);
            this.txbSrvPort.Name = "txbSrvPort";
            this.txbSrvPort.Size = new System.Drawing.Size(100, 21);
            this.txbSrvPort.TabIndex = 10;
            this.txbSrvPort.Text = "9090";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(446, 179);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 23);
            this.button2.TabIndex = 9;
            this.button2.Text = "发送到服务端";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(281, 29);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "启动";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(446, 83);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 23);
            this.button3.TabIndex = 9;
            this.button3.Text = "发送到客户端";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txbSrvMsg
            // 
            this.txbSrvMsg.Location = new System.Drawing.Point(175, 83);
            this.txbSrvMsg.Name = "txbSrvMsg";
            this.txbSrvMsg.Size = new System.Drawing.Size(265, 21);
            this.txbSrvMsg.TabIndex = 11;
            this.txbSrvMsg.Text = "HelloWorld";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(92, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 12);
            this.label4.TabIndex = 15;
            this.label4.Text = "发送  消息：";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(281, 130);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 16;
            this.button4.Text = "连接";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 262);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txbCliPort);
            this.Controls.Add(this.txbSrvMsg);
            this.Controls.Add(this.txbMsg);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.txbSrvPort);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbCliPort;
        private System.Windows.Forms.TextBox txbMsg;
        private System.Windows.Forms.TextBox txbSrvPort;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox txbSrvMsg;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button4;
    }
}