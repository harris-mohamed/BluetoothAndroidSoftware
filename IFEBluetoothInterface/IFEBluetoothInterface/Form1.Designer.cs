namespace IFEBluetoothInterface
{
    partial class BluetoothInterface
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BluetoothInterface));
            this.ConnectButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.RefreshListButton = new System.Windows.Forms.Button();
            this.COMDropDown = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TransmitDataTextBox = new System.Windows.Forms.TextBox();
            this.SendButton = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.ReceivedDataTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.BaudRateDropDown = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.DataBitsDropDown = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.BT = new System.IO.Ports.SerialPort(this.components);
            this.SuspendLayout();
            // 
            // ConnectButton
            // 
            this.ConnectButton.FlatAppearance.BorderSize = 2;
            this.ConnectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConnectButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConnectButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ConnectButton.Location = new System.Drawing.Point(633, 147);
            this.ConnectButton.Name = "ConnectButton";
            this.ConnectButton.Size = new System.Drawing.Size(263, 65);
            this.ConnectButton.TabIndex = 0;
            this.ConnectButton.Text = "Connect";
            this.ConnectButton.UseVisualStyleBackColor = true;
            this.ConnectButton.Click += new System.EventHandler(this.ConnectButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(52, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 32);
            this.label2.TabIndex = 3;
            this.label2.Text = "Total Voltage";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox1.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.White;
            this.textBox1.Location = new System.Drawing.Point(259, 92);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(218, 48);
            this.textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox2.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.White;
            this.textBox2.Location = new System.Drawing.Point(259, 156);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(218, 48);
            this.textBox2.TabIndex = 5;
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox3.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.ForeColor = System.Drawing.Color.White;
            this.textBox3.Location = new System.Drawing.Point(259, 228);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(218, 48);
            this.textBox3.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(67, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(186, 32);
            this.label3.TabIndex = 7;
            this.label3.Text = "Max voltage ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(83, 228);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(176, 32);
            this.label4.TabIndex = 8;
            this.label4.Text = "Min Voltage";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(134, 294);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(121, 32);
            this.label5.TabIndex = 9;
            this.label5.Text = "Current";
            // 
            // textBox4
            // 
            this.textBox4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox4.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox4.ForeColor = System.Drawing.Color.White;
            this.textBox4.Location = new System.Drawing.Point(259, 295);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(218, 48);
            this.textBox4.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(110, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(140, 32);
            this.label6.TabIndex = 16;
            this.label6.Text = "Min temp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(100, 430);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 32);
            this.label7.TabIndex = 15;
            this.label7.Text = "Max temp";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox5.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.ForeColor = System.Drawing.Color.White;
            this.textBox5.Location = new System.Drawing.Point(259, 497);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(218, 48);
            this.textBox5.TabIndex = 14;
            // 
            // textBox6
            // 
            this.textBox6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox6.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox6.ForeColor = System.Drawing.Color.White;
            this.textBox6.Location = new System.Drawing.Point(259, 431);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(218, 48);
            this.textBox6.TabIndex = 13;
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.textBox7.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox7.ForeColor = System.Drawing.Color.White;
            this.textBox7.Location = new System.Drawing.Point(259, 364);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(218, 48);
            this.textBox7.TabIndex = 12;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(89, 363);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 32);
            this.label8.TabIndex = 11;
            this.label8.Text = "Total Temp";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(991, 33);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(187, 39);
            this.label9.TabIndex = 17;
            this.label9.Text = "Bluetooth ";
            // 
            // RefreshListButton
            // 
            this.RefreshListButton.FlatAppearance.BorderSize = 2;
            this.RefreshListButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RefreshListButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RefreshListButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.RefreshListButton.Location = new System.Drawing.Point(633, 66);
            this.RefreshListButton.Name = "RefreshListButton";
            this.RefreshListButton.Size = new System.Drawing.Size(263, 68);
            this.RefreshListButton.TabIndex = 18;
            this.RefreshListButton.Text = "Refresh List";
            this.RefreshListButton.UseVisualStyleBackColor = true;
            this.RefreshListButton.Click += new System.EventHandler(this.RefreshListButton_Click);
            // 
            // COMDropDown
            // 
            this.COMDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.COMDropDown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.COMDropDown.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMDropDown.ForeColor = System.Drawing.Color.White;
            this.COMDropDown.FormattingEnabled = true;
            this.COMDropDown.ItemHeight = 40;
            this.COMDropDown.Location = new System.Drawing.Point(927, 85);
            this.COMDropDown.Name = "COMDropDown";
            this.COMDropDown.Size = new System.Drawing.Size(243, 48);
            this.COMDropDown.TabIndex = 19;
            this.COMDropDown.Text = "Pick COM";
            this.COMDropDown.SelectedIndexChanged += new System.EventHandler(this.COMDropDown_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(626, 240);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 32);
            this.label10.TabIndex = 20;
            this.label10.Text = "Transmit";
            // 
            // TransmitDataTextBox
            // 
            this.TransmitDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.TransmitDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TransmitDataTextBox.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TransmitDataTextBox.ForeColor = System.Drawing.Color.White;
            this.TransmitDataTextBox.Location = new System.Drawing.Point(633, 283);
            this.TransmitDataTextBox.Name = "TransmitDataTextBox";
            this.TransmitDataTextBox.Size = new System.Drawing.Size(784, 41);
            this.TransmitDataTextBox.TabIndex = 21;
            this.TransmitDataTextBox.TextChanged += new System.EventHandler(this.TransmitDataTextBox_TextChanged);
            // 
            // SendButton
            // 
            this.SendButton.FlatAppearance.BorderSize = 2;
            this.SendButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.SendButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.SendButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SendButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SendButton.ForeColor = System.Drawing.Color.White;
            this.SendButton.Location = new System.Drawing.Point(1432, 269);
            this.SendButton.Name = "SendButton";
            this.SendButton.Size = new System.Drawing.Size(176, 64);
            this.SendButton.TabIndex = 22;
            this.SendButton.Text = "Send";
            this.SendButton.UseVisualStyleBackColor = true;
            this.SendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(627, 349);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(126, 32);
            this.label11.TabIndex = 23;
            this.label11.Text = "Receive";
            // 
            // ReceivedDataTextBox
            // 
            this.ReceivedDataTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.ReceivedDataTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ReceivedDataTextBox.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ReceivedDataTextBox.ForeColor = System.Drawing.Color.White;
            this.ReceivedDataTextBox.Location = new System.Drawing.Point(633, 385);
            this.ReceivedDataTextBox.Name = "ReceivedDataTextBox";
            this.ReceivedDataTextBox.ReadOnly = true;
            this.ReceivedDataTextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.ReceivedDataTextBox.Size = new System.Drawing.Size(784, 326);
            this.ReceivedDataTextBox.TabIndex = 24;
            this.ReceivedDataTextBox.Text = "";
            this.ReceivedDataTextBox.TextChanged += new System.EventHandler(this.ReceivedDataTextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(206, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(211, 39);
            this.label1.TabIndex = 2;
            this.label1.Text = "Battery Info";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.900001F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label12.Location = new System.Drawing.Point(167, 581);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(323, 39);
            this.label12.TabIndex = 25;
            this.label12.Text = "Bluetooth Settings";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label13.Location = new System.Drawing.Point(87, 638);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(158, 32);
            this.label13.TabIndex = 26;
            this.label13.Text = "Baud Rate";
            // 
            // BaudRateDropDown
            // 
            this.BaudRateDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.BaudRateDropDown.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BaudRateDropDown.ForeColor = System.Drawing.Color.White;
            this.BaudRateDropDown.FormattingEnabled = true;
            this.BaudRateDropDown.Items.AddRange(new object[] {
            "1200",
            "2400",
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.BaudRateDropDown.Location = new System.Drawing.Point(259, 639);
            this.BaudRateDropDown.Name = "BaudRateDropDown";
            this.BaudRateDropDown.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.BaudRateDropDown.Size = new System.Drawing.Size(188, 48);
            this.BaudRateDropDown.TabIndex = 27;
            this.BaudRateDropDown.Text = "9600";
            this.BaudRateDropDown.SelectedIndexChanged += new System.EventHandler(this.BaudRateDropDown_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label14.Location = new System.Drawing.Point(107, 702);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(140, 32);
            this.label14.TabIndex = 28;
            this.label14.Text = "Data Bits";
            // 
            // DataBitsDropDown
            // 
            this.DataBitsDropDown.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(36)))), ((int)(((byte)(62)))));
            this.DataBitsDropDown.Font = new System.Drawing.Font("Calibri", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataBitsDropDown.ForeColor = System.Drawing.Color.White;
            this.DataBitsDropDown.FormattingEnabled = true;
            this.DataBitsDropDown.Items.AddRange(new object[] {
            "5",
            "6",
            "7",
            "8",
            "9"});
            this.DataBitsDropDown.Location = new System.Drawing.Point(259, 703);
            this.DataBitsDropDown.Name = "DataBitsDropDown";
            this.DataBitsDropDown.Size = new System.Drawing.Size(188, 48);
            this.DataBitsDropDown.TabIndex = 29;
            this.DataBitsDropDown.Text = "8";
            this.DataBitsDropDown.SelectedIndexChanged += new System.EventHandler(this.DataBitsDropDown_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(1670, 201);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 32);
            this.label15.TabIndex = 30;
            // 
            // BT
            // 
            this.BT.ReceivedBytesThreshold = 8;
            this.BT.WriteTimeout = 500;
            this.BT.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.BT_DataReceived);
            // 
            // BluetoothInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(240F, 240F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(14)))), ((int)(((byte)(55)))), ((int)(((byte)(104)))));
            this.ClientSize = new System.Drawing.Size(1650, 784);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.DataBitsDropDown);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.BaudRateDropDown);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.ReceivedDataTextBox);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.SendButton);
            this.Controls.Add(this.TransmitDataTextBox);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.COMDropDown);
            this.Controls.Add(this.RefreshListButton);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ConnectButton);
            this.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.1F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1682, 872);
            this.MinimumSize = new System.Drawing.Size(1682, 872);
            this.Name = "BluetoothInterface";
            this.Text = "IFE Bluetooth Interface";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.BluetoothInterface_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BluetoothInterface_KeyPress);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ConnectButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button RefreshListButton;
        private System.Windows.Forms.ComboBox COMDropDown;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TransmitDataTextBox;
        private System.Windows.Forms.Button SendButton;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.RichTextBox ReceivedDataTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox BaudRateDropDown;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox DataBitsDropDown;
        private System.Windows.Forms.Label label15;
        private System.IO.Ports.SerialPort BT;
    }
}

