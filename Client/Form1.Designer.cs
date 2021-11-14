
namespace Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.disconnectBtn = new System.Windows.Forms.Button();
            this.connectBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            this.messegesVewerBox = new System.Windows.Forms.RichTextBox();
            this.messegeSenderBox = new System.Windows.Forms.RichTextBox();
            this.sendMessegeBtn = new System.Windows.Forms.Button();
            this.ipAddressTxt = new System.Windows.Forms.TextBox();
            this.portNoTxt = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // disconnectBtn
            // 
            this.disconnectBtn.Location = new System.Drawing.Point(239, 12);
            this.disconnectBtn.Name = "disconnectBtn";
            this.disconnectBtn.Size = new System.Drawing.Size(77, 48);
            this.disconnectBtn.TabIndex = 0;
            this.disconnectBtn.Text = "Disconnect";
            this.disconnectBtn.UseVisualStyleBackColor = true;
            this.disconnectBtn.Click += new System.EventHandler(this.disconnectBtn_Click);
            // 
            // connectBtn
            // 
            this.connectBtn.Location = new System.Drawing.Point(322, 12);
            this.connectBtn.Name = "connectBtn";
            this.connectBtn.Size = new System.Drawing.Size(73, 48);
            this.connectBtn.TabIndex = 0;
            this.connectBtn.Text = "Connect";
            this.connectBtn.UseVisualStyleBackColor = true;
            this.connectBtn.Click += new System.EventHandler(this.connectBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Ip Address :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 2;
            this.label2.Text = "Port Number :";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 349);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(10, 15);
            this.statusLabel.TabIndex = 2;
            this.statusLabel.Text = " ";
            // 
            // messegesVewerBox
            // 
            this.messegesVewerBox.Location = new System.Drawing.Point(13, 67);
            this.messegesVewerBox.Name = "messegesVewerBox";
            this.messegesVewerBox.Size = new System.Drawing.Size(382, 178);
            this.messegesVewerBox.TabIndex = 3;
            this.messegesVewerBox.Text = "";
            // 
            // messegeSenderBox
            // 
            this.messegeSenderBox.Location = new System.Drawing.Point(121, 268);
            this.messegeSenderBox.Name = "messegeSenderBox";
            this.messegeSenderBox.Size = new System.Drawing.Size(273, 93);
            this.messegeSenderBox.TabIndex = 3;
            this.messegeSenderBox.Text = "";
            // 
            // sendMessegeBtn
            // 
            this.sendMessegeBtn.Location = new System.Drawing.Point(13, 268);
            this.sendMessegeBtn.Name = "sendMessegeBtn";
            this.sendMessegeBtn.Size = new System.Drawing.Size(102, 64);
            this.sendMessegeBtn.TabIndex = 4;
            this.sendMessegeBtn.Text = "Send";
            this.sendMessegeBtn.UseVisualStyleBackColor = true;
            this.sendMessegeBtn.Click += new System.EventHandler(this.sendMessegeBtn_Click);
            // 
            // ipAddressTxt
            // 
            this.ipAddressTxt.Location = new System.Drawing.Point(100, 12);
            this.ipAddressTxt.Name = "ipAddressTxt";
            this.ipAddressTxt.Size = new System.Drawing.Size(100, 23);
            this.ipAddressTxt.TabIndex = 5;
            // 
            // portNoTxt
            // 
            this.portNoTxt.Location = new System.Drawing.Point(100, 38);
            this.portNoTxt.Name = "portNoTxt";
            this.portNoTxt.Size = new System.Drawing.Size(100, 23);
            this.portNoTxt.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 373);
            this.Controls.Add(this.portNoTxt);
            this.Controls.Add(this.ipAddressTxt);
            this.Controls.Add(this.sendMessegeBtn);
            this.Controls.Add(this.messegeSenderBox);
            this.Controls.Add(this.messegesVewerBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.connectBtn);
            this.Controls.Add(this.disconnectBtn);
            this.Name = "Form1";
            this.Text = "Client";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button disconnectBtn;
        private System.Windows.Forms.Button connectBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.RichTextBox messegesVewerBox;
        private System.Windows.Forms.RichTextBox messegeSenderBox;
        private System.Windows.Forms.Button sendMessegeBtn;
        private System.Windows.Forms.TextBox ipAddressTxt;
        private System.Windows.Forms.TextBox portNoTxt;
    }
}

