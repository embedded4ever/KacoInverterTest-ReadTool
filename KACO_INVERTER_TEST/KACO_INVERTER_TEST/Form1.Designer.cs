namespace KACO_INVERTER_TEST
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
            this.components = new System.ComponentModel.Container();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.ComPort = new System.Windows.Forms.GroupBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button4 = new System.Windows.Forms.Button();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.chk20 = new System.Windows.Forms.CheckBox();
            this.chk19 = new System.Windows.Forms.CheckBox();
            this.chk18 = new System.Windows.Forms.CheckBox();
            this.chk17 = new System.Windows.Forms.CheckBox();
            this.chk16 = new System.Windows.Forms.CheckBox();
            this.chk14 = new System.Windows.Forms.CheckBox();
            this.chk15 = new System.Windows.Forms.CheckBox();
            this.chk13 = new System.Windows.Forms.CheckBox();
            this.chk12 = new System.Windows.Forms.CheckBox();
            this.chk11 = new System.Windows.Forms.CheckBox();
            this.chk10 = new System.Windows.Forms.CheckBox();
            this.chk8 = new System.Windows.Forms.CheckBox();
            this.chk7 = new System.Windows.Forms.CheckBox();
            this.chk6 = new System.Windows.Forms.CheckBox();
            this.chk4 = new System.Windows.Forms.CheckBox();
            this.chk9 = new System.Windows.Forms.CheckBox();
            this.chk3 = new System.Windows.Forms.CheckBox();
            this.chk5 = new System.Windows.Forms.CheckBox();
            this.chk2 = new System.Windows.Forms.CheckBox();
            this.chk1 = new System.Windows.Forms.CheckBox();
            this.ComPort.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(9, 71);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 35);
            this.button1.TabIndex = 0;
            this.button1.Text = "OPEN";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(9, 26);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(9, 109);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 35);
            this.button2.TabIndex = 2;
            this.button2.Text = "CLOSE";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // ComPort
            // 
            this.ComPort.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ComPort.Controls.Add(this.checkBox3);
            this.ComPort.Controls.Add(this.label2);
            this.ComPort.Controls.Add(this.label1);
            this.ComPort.Controls.Add(this.comboBox1);
            this.ComPort.Controls.Add(this.button2);
            this.ComPort.Controls.Add(this.button1);
            this.ComPort.Location = new System.Drawing.Point(13, 56);
            this.ComPort.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComPort.Name = "ComPort";
            this.ComPort.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ComPort.Size = new System.Drawing.Size(357, 154);
            this.ComPort.TabIndex = 3;
            this.ComPort.TabStop = false;
            this.ComPort.Text = "ComPort";
            this.ComPort.Enter += new System.EventHandler(this.ComPort_Enter);
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Location = new System.Drawing.Point(199, 89);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(132, 24);
            this.checkBox3.TabIndex = 6;
            this.checkBox3.Text = "StartSimulate";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(274, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label2.Size = new System.Drawing.Size(63, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "CLOSE";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "STATUS : ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.checkBox2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.checkBox1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(390, 56);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(441, 189);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "InverterParams";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(300, 34);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 132);
            this.button4.TabIndex = 6;
            this.button4.Text = "READ";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(141, 131);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(148, 26);
            this.textBox3.TabIndex = 5;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Location = new System.Drawing.Point(14, 128);
            this.checkBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(94, 24);
            this.checkBox2.TabIndex = 4;
            this.checkBox2.Text = "PollTime";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(141, 80);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(148, 26);
            this.textBox2.TabIndex = 3;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(14, 80);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(82, 24);
            this.checkBox1.TabIndex = 2;
            this.checkBox1.Text = "OffSet";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(141, 37);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 42);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Inverter Id :";
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(8, 22);
            this.richTextBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.ReadOnly = true;
            this.richTextBox1.Size = new System.Drawing.Size(706, 176);
            this.richTextBox1.TabIndex = 5;
            this.richTextBox1.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.richTextBox1);
            this.groupBox2.Location = new System.Drawing.Point(15, 255);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(724, 208);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Received Data";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.richTextBox2);
            this.groupBox4.Location = new System.Drawing.Point(15, 495);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox4.Size = new System.Drawing.Size(726, 195);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Transmit Data";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(7, 29);
            this.richTextBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.ReadOnly = true;
            this.richTextBox2.Size = new System.Drawing.Size(708, 156);
            this.richTextBox2.TabIndex = 0;
            this.richTextBox2.Text = "";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(747, 339);
            this.button3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(112, 35);
            this.button3.TabIndex = 8;
            this.button3.Text = "CLEAR";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(749, 547);
            this.button5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(112, 35);
            this.button5.TabIndex = 9;
            this.button5.Text = "CLEAR";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.chk20);
            this.groupBox3.Controls.Add(this.chk19);
            this.groupBox3.Controls.Add(this.chk18);
            this.groupBox3.Controls.Add(this.chk17);
            this.groupBox3.Controls.Add(this.chk16);
            this.groupBox3.Controls.Add(this.chk14);
            this.groupBox3.Controls.Add(this.chk15);
            this.groupBox3.Controls.Add(this.chk13);
            this.groupBox3.Controls.Add(this.chk12);
            this.groupBox3.Controls.Add(this.chk11);
            this.groupBox3.Controls.Add(this.chk10);
            this.groupBox3.Controls.Add(this.chk8);
            this.groupBox3.Controls.Add(this.chk7);
            this.groupBox3.Controls.Add(this.chk6);
            this.groupBox3.Controls.Add(this.chk4);
            this.groupBox3.Controls.Add(this.chk9);
            this.groupBox3.Controls.Add(this.chk3);
            this.groupBox3.Controls.Add(this.chk5);
            this.groupBox3.Controls.Add(this.chk2);
            this.groupBox3.Controls.Add(this.chk1);
            this.groupBox3.Location = new System.Drawing.Point(13, 698);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(726, 100);
            this.groupBox3.TabIndex = 10;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Device Enable";
            // 
            // chk20
            // 
            this.chk20.AutoSize = true;
            this.chk20.Location = new System.Drawing.Point(503, 57);
            this.chk20.Name = "chk20";
            this.chk20.Size = new System.Drawing.Size(53, 24);
            this.chk20.TabIndex = 20;
            this.chk20.Text = "20";
            this.chk20.UseVisualStyleBackColor = true;
            // 
            // chk19
            // 
            this.chk19.AutoSize = true;
            this.chk19.Location = new System.Drawing.Point(444, 57);
            this.chk19.Name = "chk19";
            this.chk19.Size = new System.Drawing.Size(53, 24);
            this.chk19.TabIndex = 19;
            this.chk19.Text = "19";
            this.chk19.UseVisualStyleBackColor = true;
            // 
            // chk18
            // 
            this.chk18.AutoSize = true;
            this.chk18.Location = new System.Drawing.Point(385, 57);
            this.chk18.Name = "chk18";
            this.chk18.Size = new System.Drawing.Size(53, 24);
            this.chk18.TabIndex = 18;
            this.chk18.Text = "18";
            this.chk18.UseVisualStyleBackColor = true;
            // 
            // chk17
            // 
            this.chk17.AutoSize = true;
            this.chk17.Location = new System.Drawing.Point(326, 57);
            this.chk17.Name = "chk17";
            this.chk17.Size = new System.Drawing.Size(53, 24);
            this.chk17.TabIndex = 17;
            this.chk17.Text = "17";
            this.chk17.UseVisualStyleBackColor = true;
            // 
            // chk16
            // 
            this.chk16.AutoSize = true;
            this.chk16.Location = new System.Drawing.Point(268, 57);
            this.chk16.Name = "chk16";
            this.chk16.Size = new System.Drawing.Size(53, 24);
            this.chk16.TabIndex = 16;
            this.chk16.Text = "16";
            this.chk16.UseVisualStyleBackColor = true;
            // 
            // chk14
            // 
            this.chk14.AutoSize = true;
            this.chk14.Location = new System.Drawing.Point(150, 57);
            this.chk14.Name = "chk14";
            this.chk14.Size = new System.Drawing.Size(53, 24);
            this.chk14.TabIndex = 15;
            this.chk14.Text = "14";
            this.chk14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.chk14.UseVisualStyleBackColor = true;
            // 
            // chk15
            // 
            this.chk15.AutoSize = true;
            this.chk15.Location = new System.Drawing.Point(209, 57);
            this.chk15.Name = "chk15";
            this.chk15.Size = new System.Drawing.Size(53, 24);
            this.chk15.TabIndex = 14;
            this.chk15.Text = "15";
            this.chk15.UseVisualStyleBackColor = true;
            // 
            // chk13
            // 
            this.chk13.AutoSize = true;
            this.chk13.Location = new System.Drawing.Point(91, 57);
            this.chk13.Name = "chk13";
            this.chk13.Size = new System.Drawing.Size(53, 24);
            this.chk13.TabIndex = 12;
            this.chk13.Text = "13";
            this.chk13.UseVisualStyleBackColor = true;
            // 
            // chk12
            // 
            this.chk12.AutoSize = true;
            this.chk12.Location = new System.Drawing.Point(32, 57);
            this.chk12.Name = "chk12";
            this.chk12.Size = new System.Drawing.Size(53, 24);
            this.chk12.TabIndex = 11;
            this.chk12.Text = "12";
            this.chk12.UseVisualStyleBackColor = true;
            // 
            // chk11
            // 
            this.chk11.AutoSize = true;
            this.chk11.Location = new System.Drawing.Point(541, 27);
            this.chk11.Name = "chk11";
            this.chk11.Size = new System.Drawing.Size(53, 24);
            this.chk11.TabIndex = 10;
            this.chk11.Text = "11";
            this.chk11.UseVisualStyleBackColor = true;
            // 
            // chk10
            // 
            this.chk10.AutoSize = true;
            this.chk10.Location = new System.Drawing.Point(482, 27);
            this.chk10.Name = "chk10";
            this.chk10.Size = new System.Drawing.Size(53, 24);
            this.chk10.TabIndex = 9;
            this.chk10.Text = "10";
            this.chk10.UseVisualStyleBackColor = true;
            // 
            // chk8
            // 
            this.chk8.AutoSize = true;
            this.chk8.Location = new System.Drawing.Point(385, 27);
            this.chk8.Name = "chk8";
            this.chk8.Size = new System.Drawing.Size(44, 24);
            this.chk8.TabIndex = 7;
            this.chk8.Text = "8";
            this.chk8.UseVisualStyleBackColor = true;
            // 
            // chk7
            // 
            this.chk7.AutoSize = true;
            this.chk7.Location = new System.Drawing.Point(335, 27);
            this.chk7.Name = "chk7";
            this.chk7.Size = new System.Drawing.Size(44, 24);
            this.chk7.TabIndex = 6;
            this.chk7.Text = "7";
            this.chk7.UseVisualStyleBackColor = true;
            // 
            // chk6
            // 
            this.chk6.AutoSize = true;
            this.chk6.Location = new System.Drawing.Point(287, 27);
            this.chk6.Name = "chk6";
            this.chk6.Size = new System.Drawing.Size(44, 24);
            this.chk6.TabIndex = 5;
            this.chk6.TabStop = false;
            this.chk6.Text = "6";
            this.chk6.UseVisualStyleBackColor = true;
            // 
            // chk4
            // 
            this.chk4.AutoSize = true;
            this.chk4.Location = new System.Drawing.Point(185, 27);
            this.chk4.Name = "chk4";
            this.chk4.Size = new System.Drawing.Size(44, 24);
            this.chk4.TabIndex = 3;
            this.chk4.Text = "4";
            this.chk4.UseVisualStyleBackColor = true;
            // 
            // chk9
            // 
            this.chk9.AutoSize = true;
            this.chk9.Location = new System.Drawing.Point(435, 27);
            this.chk9.Name = "chk9";
            this.chk9.Size = new System.Drawing.Size(44, 24);
            this.chk9.TabIndex = 8;
            this.chk9.Text = "9";
            this.chk9.UseVisualStyleBackColor = true;
            // 
            // chk3
            // 
            this.chk3.AutoSize = true;
            this.chk3.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.chk3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.chk3.Location = new System.Drawing.Point(132, 25);
            this.chk3.Name = "chk3";
            this.chk3.Size = new System.Drawing.Size(43, 25);
            this.chk3.TabIndex = 2;
            this.chk3.Text = "3";
            this.chk3.UseVisualStyleBackColor = true;
            // 
            // chk5
            // 
            this.chk5.AutoSize = true;
            this.chk5.Location = new System.Drawing.Point(235, 27);
            this.chk5.Name = "chk5";
            this.chk5.Size = new System.Drawing.Size(44, 24);
            this.chk5.TabIndex = 4;
            this.chk5.Text = "5";
            this.chk5.UseVisualStyleBackColor = true;
            // 
            // chk2
            // 
            this.chk2.AutoSize = true;
            this.chk2.Location = new System.Drawing.Point(82, 27);
            this.chk2.Name = "chk2";
            this.chk2.Size = new System.Drawing.Size(44, 24);
            this.chk2.TabIndex = 1;
            this.chk2.Text = "2";
            this.chk2.UseVisualStyleBackColor = true;
            // 
            // chk1
            // 
            this.chk1.AutoSize = true;
            this.chk1.FlatAppearance.CheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.chk1.Location = new System.Drawing.Point(32, 26);
            this.chk1.Name = "chk1";
            this.chk1.Size = new System.Drawing.Size(44, 24);
            this.chk1.TabIndex = 0;
            this.chk1.Text = "1";
            this.chk1.UseVisualStyleBackColor = true;
            this.chk1.CheckedChanged += new System.EventHandler(this.checkBox4_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(872, 932);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.ComPort);
            this.HelpButton = true;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KACO INVERTER TEST TOOL";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ComPort.ResumeLayout(false);
            this.ComPort.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button button2;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.GroupBox ComPort;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox chk10;
        private System.Windows.Forms.CheckBox chk8;
        private System.Windows.Forms.CheckBox chk7;
        private System.Windows.Forms.CheckBox chk6;
        private System.Windows.Forms.CheckBox chk4;
        private System.Windows.Forms.CheckBox chk9;
        private System.Windows.Forms.CheckBox chk3;
        private System.Windows.Forms.CheckBox chk5;
        private System.Windows.Forms.CheckBox chk2;
        private System.Windows.Forms.CheckBox chk1;
        private System.Windows.Forms.CheckBox chk11;
        private System.Windows.Forms.CheckBox chk16;
        private System.Windows.Forms.CheckBox chk12;
        private System.Windows.Forms.CheckBox chk13;
        private System.Windows.Forms.CheckBox chk15;
        private System.Windows.Forms.CheckBox chk14;
        private System.Windows.Forms.CheckBox chk17;
        private System.Windows.Forms.CheckBox chk20;
        private System.Windows.Forms.CheckBox chk19;
        private System.Windows.Forms.CheckBox chk18;
    }
}

