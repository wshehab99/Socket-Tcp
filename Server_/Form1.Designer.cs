
namespace Server_
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
            this.messegeShowBox = new System.Windows.Forms.RichTextBox();
            this.messegeSend = new System.Windows.Forms.RichTextBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.sendMessegeButton = new System.Windows.Forms.Button();
            this.statusLabel = new System.Windows.Forms.TextBox();
            this.ipAddressBox = new System.Windows.Forms.TextBox();
            this.portNOBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // messegeShowBox
            // 
            this.messegeShowBox.Location = new System.Drawing.Point(12, 83);
            this.messegeShowBox.Name = "messegeShowBox";
            this.messegeShowBox.Size = new System.Drawing.Size(347, 193);
            this.messegeShowBox.TabIndex = 0;
            this.messegeShowBox.Text = "";
            // 
            // messegeSend
            // 
            this.messegeSend.Location = new System.Drawing.Point(97, 282);
            this.messegeSend.Name = "messegeSend";
            this.messegeSend.Size = new System.Drawing.Size(262, 77);
            this.messegeSend.TabIndex = 0;
            this.messegeSend.Text = "";
            // 
            // stopButton
            // 
            this.stopButton.Location = new System.Drawing.Point(12, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(75, 65);
            this.stopButton.TabIndex = 1;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(284, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 65);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // sendMessegeButton
            // 
            this.sendMessegeButton.Location = new System.Drawing.Point(12, 282);
            this.sendMessegeButton.Name = "sendMessegeButton";
            this.sendMessegeButton.Size = new System.Drawing.Size(79, 48);
            this.sendMessegeButton.TabIndex = 1;
            this.sendMessegeButton.Text = "Send";
            this.sendMessegeButton.UseVisualStyleBackColor = true;
            this.sendMessegeButton.Click += new System.EventHandler(this.sendMessegeButton_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Location = new System.Drawing.Point(12, 336);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.ReadOnly = true;
            this.statusLabel.Size = new System.Drawing.Size(78, 23);
            this.statusLabel.TabIndex = 2;
            // 
            // ipAddressBox
            // 
            this.ipAddressBox.Location = new System.Drawing.Point(178, 12);
            this.ipAddressBox.Name = "ipAddressBox";
            this.ipAddressBox.Size = new System.Drawing.Size(100, 23);
            this.ipAddressBox.TabIndex = 3;
            // 
            // portNOBox
            // 
            this.portNOBox.Location = new System.Drawing.Point(178, 54);
            this.portNOBox.Name = "portNOBox";
            this.portNOBox.Size = new System.Drawing.Size(100, 23);
            this.portNOBox.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(104, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ip Address :";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(93, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Port Number :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(371, 364);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.portNOBox);
            this.Controls.Add(this.ipAddressBox);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.sendMessegeButton);
            this.Controls.Add(this.stopButton);
            this.Controls.Add(this.messegeSend);
            this.Controls.Add(this.messegeShowBox);
            this.Name = "Form1";
            this.Text = "Server";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox messegeShowBox;
        private System.Windows.Forms.RichTextBox messegeSend;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button sendMessegeButton;
        private System.Windows.Forms.TextBox statusLabel;
        private System.Windows.Forms.TextBox ipAddressBox;
        private System.Windows.Forms.TextBox portNOBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

