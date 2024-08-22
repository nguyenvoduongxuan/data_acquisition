namespace BTL
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
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.Data_Received = new System.Windows.Forms.TextBox();
            this.OPEN = new System.Windows.Forms.Button();
            this.CLOSE = new System.Windows.Forms.Button();
            this.Output_1 = new System.Windows.Forms.TextBox();
            this.Output_2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ThresL1 = new System.Windows.Forms.DomainUpDown();
            this.shapeContainer1 = new Microsoft.VisualBasic.PowerPacks.ShapeContainer();
            this.AlarmH2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.AlarmL2 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.AlarmH1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.AlarmL1 = new Microsoft.VisualBasic.PowerPacks.OvalShape();
            this.ThresH1 = new System.Windows.Forms.DomainUpDown();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.ThresH2 = new System.Windows.Forms.DomainUpDown();
            this.ThresL2 = new System.Windows.Forms.DomainUpDown();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.btChart = new System.Windows.Forms.Button();
            this.cb10s = new System.Windows.Forms.CheckBox();
            this.cb5s = new System.Windows.Forms.CheckBox();
            this.cb2s = new System.Windows.Forms.CheckBox();
            this.cb1s = new System.Windows.Forms.CheckBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cb_Enable_Alarm2 = new System.Windows.Forms.CheckBox();
            this.cb_Enable_Alarm1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // serialPort1
            // 
            this.serialPort1.PortName = "COM3";
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // Data_Received
            // 
            this.Data_Received.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Data_Received.Location = new System.Drawing.Point(93, 444);
            this.Data_Received.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Data_Received.Name = "Data_Received";
            this.Data_Received.Size = new System.Drawing.Size(235, 38);
            this.Data_Received.TabIndex = 0;
            this.Data_Received.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // OPEN
            // 
            this.OPEN.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OPEN.Location = new System.Drawing.Point(798, 603);
            this.OPEN.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.OPEN.Name = "OPEN";
            this.OPEN.Size = new System.Drawing.Size(204, 52);
            this.OPEN.TabIndex = 1;
            this.OPEN.Text = "OPEN PORT";
            this.OPEN.UseVisualStyleBackColor = true;
            this.OPEN.Click += new System.EventHandler(this.OPEN_Click);
            // 
            // CLOSE
            // 
            this.CLOSE.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLOSE.Location = new System.Drawing.Point(1046, 603);
            this.CLOSE.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CLOSE.Name = "CLOSE";
            this.CLOSE.Size = new System.Drawing.Size(204, 52);
            this.CLOSE.TabIndex = 2;
            this.CLOSE.Text = "CLOSE PORT";
            this.CLOSE.UseVisualStyleBackColor = true;
            this.CLOSE.Click += new System.EventHandler(this.CLOSE_Click);
            // 
            // Output_1
            // 
            this.Output_1.BackColor = System.Drawing.Color.White;
            this.Output_1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_1.Location = new System.Drawing.Point(93, 106);
            this.Output_1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output_1.Name = "Output_1";
            this.Output_1.Size = new System.Drawing.Size(235, 38);
            this.Output_1.TabIndex = 4;
            this.Output_1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Output_2
            // 
            this.Output_2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Output_2.Location = new System.Drawing.Point(93, 275);
            this.Output_2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Output_2.Name = "Output_2";
            this.Output_2.Size = new System.Drawing.Size(235, 38);
            this.Output_2.TabIndex = 5;
            this.Output_2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 417);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(359, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "TEMPERATURE 3 [℃] (THERMISTOR)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(70, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(278, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "TEMPERATURE 1 [℃] (LM35)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(70, 248);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(278, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "TEMPERATURE 2 [℃] (LM35)";
            // 
            // ThresL1
            // 
            this.ThresL1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresL1.Items.Add("50");
            this.ThresL1.Items.Add("49");
            this.ThresL1.Items.Add("48");
            this.ThresL1.Items.Add("47");
            this.ThresL1.Items.Add("46");
            this.ThresL1.Items.Add("45");
            this.ThresL1.Items.Add("44");
            this.ThresL1.Items.Add("43");
            this.ThresL1.Items.Add("42");
            this.ThresL1.Items.Add("41");
            this.ThresL1.Items.Add("40");
            this.ThresL1.Items.Add("39");
            this.ThresL1.Items.Add("38");
            this.ThresL1.Items.Add("37");
            this.ThresL1.Items.Add("36");
            this.ThresL1.Items.Add("35");
            this.ThresL1.Items.Add("34");
            this.ThresL1.Items.Add("33");
            this.ThresL1.Items.Add("32");
            this.ThresL1.Items.Add("31");
            this.ThresL1.Items.Add("30");
            this.ThresL1.Items.Add("29");
            this.ThresL1.Items.Add("28");
            this.ThresL1.Items.Add("27");
            this.ThresL1.Items.Add("26");
            this.ThresL1.Items.Add("25");
            this.ThresL1.Items.Add("24");
            this.ThresL1.Items.Add("23");
            this.ThresL1.Items.Add("22");
            this.ThresL1.Items.Add("21");
            this.ThresL1.Items.Add("20");
            this.ThresL1.Location = new System.Drawing.Point(443, 204);
            this.ThresL1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresL1.Name = "ThresL1";
            this.ThresL1.Size = new System.Drawing.Size(75, 34);
            this.ThresL1.TabIndex = 9;
            this.ThresL1.Text = "34";
            this.ThresL1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // shapeContainer1
            // 
            this.shapeContainer1.Location = new System.Drawing.Point(0, 0);
            this.shapeContainer1.Margin = new System.Windows.Forms.Padding(0);
            this.shapeContainer1.Name = "shapeContainer1";
            this.shapeContainer1.Shapes.AddRange(new Microsoft.VisualBasic.PowerPacks.Shape[] {
            this.AlarmH2,
            this.AlarmL2,
            this.AlarmH1,
            this.AlarmL1});
            this.shapeContainer1.Size = new System.Drawing.Size(1840, 677);
            this.shapeContainer1.TabIndex = 10;
            this.shapeContainer1.TabStop = false;
            // 
            // AlarmH2
            // 
            this.AlarmH2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.AlarmH2.Location = new System.Drawing.Point(403, 291);
            this.AlarmH2.Name = "AlarmH2";
            this.AlarmH2.Size = new System.Drawing.Size(44, 44);
            // 
            // AlarmL2
            // 
            this.AlarmL2.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.AlarmL2.Location = new System.Drawing.Point(402, 372);
            this.AlarmL2.Name = "AlarmL2";
            this.AlarmL2.Size = new System.Drawing.Size(44, 44);
            // 
            // AlarmH1
            // 
            this.AlarmH1.BackColor = System.Drawing.SystemColors.ControlDark;
            this.AlarmH1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.AlarmH1.Location = new System.Drawing.Point(403, 82);
            this.AlarmH1.Name = "AlarmH1";
            this.AlarmH1.Size = new System.Drawing.Size(44, 44);
            // 
            // AlarmL1
            // 
            this.AlarmL1.FillStyle = Microsoft.VisualBasic.PowerPacks.FillStyle.Solid;
            this.AlarmL1.Location = new System.Drawing.Point(403, 162);
            this.AlarmL1.Name = "AlarmL1";
            this.AlarmL1.Size = new System.Drawing.Size(44, 44);
            // 
            // ThresH1
            // 
            this.ThresH1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresH1.Items.Add("50");
            this.ThresH1.Items.Add("49");
            this.ThresH1.Items.Add("48");
            this.ThresH1.Items.Add("47");
            this.ThresH1.Items.Add("46");
            this.ThresH1.Items.Add("45");
            this.ThresH1.Items.Add("44");
            this.ThresH1.Items.Add("43");
            this.ThresH1.Items.Add("42");
            this.ThresH1.Items.Add("41");
            this.ThresH1.Items.Add("40");
            this.ThresH1.Items.Add("39");
            this.ThresH1.Items.Add("38");
            this.ThresH1.Items.Add("37");
            this.ThresH1.Items.Add("36");
            this.ThresH1.Items.Add("35");
            this.ThresH1.Items.Add("34");
            this.ThresH1.Items.Add("33");
            this.ThresH1.Items.Add("32");
            this.ThresH1.Items.Add("31");
            this.ThresH1.Items.Add("30");
            this.ThresH1.Items.Add("29");
            this.ThresH1.Items.Add("28");
            this.ThresH1.Items.Add("27");
            this.ThresH1.Items.Add("26");
            this.ThresH1.Items.Add("25");
            this.ThresH1.Items.Add("24");
            this.ThresH1.Items.Add("23");
            this.ThresH1.Items.Add("22");
            this.ThresH1.Items.Add("21");
            this.ThresH1.Items.Add("20");
            this.ThresH1.Location = new System.Drawing.Point(443, 106);
            this.ThresH1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresH1.Name = "ThresH1";
            this.ThresH1.Size = new System.Drawing.Size(75, 34);
            this.ThresH1.TabIndex = 11;
            this.ThresH1.Text = "35";
            this.ThresH1.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(437, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(383, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Temperature 1 High Threshold [℃]";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(437, 162);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(378, 29);
            this.label5.TabIndex = 13;
            this.label5.Text = "Temperature 1 Low Threshold [℃]";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(603, 111);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Alarm";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(603, 209);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 29);
            this.label7.TabIndex = 15;
            this.label7.Text = "Alarm";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(597, 468);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(75, 29);
            this.label8.TabIndex = 21;
            this.label8.Text = "Alarm";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(597, 370);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(75, 29);
            this.label9.TabIndex = 20;
            this.label9.Text = "Alarm";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(432, 421);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(378, 29);
            this.label10.TabIndex = 19;
            this.label10.Text = "Temperature 2 Low Threshold [℃]";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(432, 324);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(383, 29);
            this.label11.TabIndex = 18;
            this.label11.Text = "Temperature 2 High Threshold [℃]";
            // 
            // ThresH2
            // 
            this.ThresH2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresH2.Items.Add("50");
            this.ThresH2.Items.Add("49");
            this.ThresH2.Items.Add("48");
            this.ThresH2.Items.Add("47");
            this.ThresH2.Items.Add("46");
            this.ThresH2.Items.Add("45");
            this.ThresH2.Items.Add("44");
            this.ThresH2.Items.Add("43");
            this.ThresH2.Items.Add("42");
            this.ThresH2.Items.Add("41");
            this.ThresH2.Items.Add("40");
            this.ThresH2.Items.Add("39");
            this.ThresH2.Items.Add("38");
            this.ThresH2.Items.Add("37");
            this.ThresH2.Items.Add("36");
            this.ThresH2.Items.Add("35");
            this.ThresH2.Items.Add("34");
            this.ThresH2.Items.Add("33");
            this.ThresH2.Items.Add("32");
            this.ThresH2.Items.Add("31");
            this.ThresH2.Items.Add("30");
            this.ThresH2.Items.Add("29");
            this.ThresH2.Items.Add("28");
            this.ThresH2.Items.Add("27");
            this.ThresH2.Items.Add("26");
            this.ThresH2.Items.Add("25");
            this.ThresH2.Items.Add("24");
            this.ThresH2.Items.Add("23");
            this.ThresH2.Items.Add("22");
            this.ThresH2.Items.Add("21");
            this.ThresH2.Items.Add("20");
            this.ThresH2.Location = new System.Drawing.Point(437, 366);
            this.ThresH2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresH2.Name = "ThresH2";
            this.ThresH2.Size = new System.Drawing.Size(75, 34);
            this.ThresH2.TabIndex = 17;
            this.ThresH2.Text = "35";
            this.ThresH2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // ThresL2
            // 
            this.ThresL2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ThresL2.Items.Add("50");
            this.ThresL2.Items.Add("49");
            this.ThresL2.Items.Add("48");
            this.ThresL2.Items.Add("47");
            this.ThresL2.Items.Add("46");
            this.ThresL2.Items.Add("45");
            this.ThresL2.Items.Add("44");
            this.ThresL2.Items.Add("43");
            this.ThresL2.Items.Add("42");
            this.ThresL2.Items.Add("41");
            this.ThresL2.Items.Add("40");
            this.ThresL2.Items.Add("39");
            this.ThresL2.Items.Add("38");
            this.ThresL2.Items.Add("37");
            this.ThresL2.Items.Add("36");
            this.ThresL2.Items.Add("35");
            this.ThresL2.Items.Add("34");
            this.ThresL2.Items.Add("33");
            this.ThresL2.Items.Add("32");
            this.ThresL2.Items.Add("31");
            this.ThresL2.Items.Add("30");
            this.ThresL2.Items.Add("29");
            this.ThresL2.Items.Add("28");
            this.ThresL2.Items.Add("27");
            this.ThresL2.Items.Add("26");
            this.ThresL2.Items.Add("25");
            this.ThresL2.Items.Add("24");
            this.ThresL2.Items.Add("23");
            this.ThresL2.Items.Add("22");
            this.ThresL2.Items.Add("21");
            this.ThresL2.Items.Add("20");
            this.ThresL2.Location = new System.Drawing.Point(437, 463);
            this.ThresL2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ThresL2.Name = "ThresL2";
            this.ThresL2.Size = new System.Drawing.Size(75, 34);
            this.ThresL2.TabIndex = 16;
            this.ThresL2.Text = "34";
            this.ThresL2.UpDownAlign = System.Windows.Forms.LeftRightAlignment.Left;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(877, 60);
            this.zedGraphControl1.Margin = new System.Windows.Forms.Padding(5);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(811, 508);
            this.zedGraphControl1.TabIndex = 22;
            this.zedGraphControl1.UseExtendedPrintDialog = true;
            // 
            // btChart
            // 
            this.btChart.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChart.Location = new System.Drawing.Point(1287, 603);
            this.btChart.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btChart.Name = "btChart";
            this.btChart.Size = new System.Drawing.Size(204, 52);
            this.btChart.TabIndex = 23;
            this.btChart.Text = "CHART";
            this.btChart.UseVisualStyleBackColor = true;
            this.btChart.Click += new System.EventHandler(this.btChart_Click);
            // 
            // cb10s
            // 
            this.cb10s.AutoSize = true;
            this.cb10s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb10s.ForeColor = System.Drawing.Color.Black;
            this.cb10s.Location = new System.Drawing.Point(13, 110);
            this.cb10s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb10s.Name = "cb10s";
            this.cb10s.Size = new System.Drawing.Size(55, 29);
            this.cb10s.TabIndex = 33;
            this.cb10s.Text = "1s";
            this.cb10s.UseVisualStyleBackColor = true;
            this.cb10s.CheckedChanged += new System.EventHandler(this.cb10s_CheckedChanged);
            // 
            // cb5s
            // 
            this.cb5s.AutoSize = true;
            this.cb5s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb5s.ForeColor = System.Drawing.Color.Black;
            this.cb5s.Location = new System.Drawing.Point(13, 81);
            this.cb5s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb5s.Name = "cb5s";
            this.cb5s.Size = new System.Drawing.Size(71, 29);
            this.cb5s.TabIndex = 32;
            this.cb5s.Text = "0.5s";
            this.cb5s.UseVisualStyleBackColor = true;
            this.cb5s.CheckedChanged += new System.EventHandler(this.cb5s_CheckedChanged);
            // 
            // cb2s
            // 
            this.cb2s.AutoSize = true;
            this.cb2s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb2s.Location = new System.Drawing.Point(1713, 116);
            this.cb2s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb2s.Name = "cb2s";
            this.cb2s.Size = new System.Drawing.Size(71, 29);
            this.cb2s.TabIndex = 31;
            this.cb2s.Text = "0.2s";
            this.cb2s.UseVisualStyleBackColor = true;
            this.cb2s.CheckedChanged += new System.EventHandler(this.cb2s_CheckedChanged);
            // 
            // cb1s
            // 
            this.cb1s.AutoSize = true;
            this.cb1s.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb1s.Location = new System.Drawing.Point(1713, 90);
            this.cb1s.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb1s.Name = "cb1s";
            this.cb1s.Size = new System.Drawing.Size(71, 29);
            this.cb1s.TabIndex = 30;
            this.cb1s.Text = "0.1s";
            this.cb1s.UseVisualStyleBackColor = true;
            this.cb1s.CheckedChanged += new System.EventHandler(this.cb1s_CheckedChanged);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.White;
            this.groupBox3.Controls.Add(this.cb5s);
            this.groupBox3.Controls.Add(this.cb10s);
            this.groupBox3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(1700, 59);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.groupBox3.Size = new System.Drawing.Size(125, 144);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Sample Time";
            // 
            // cb_Enable_Alarm2
            // 
            this.cb_Enable_Alarm2.AutoSize = true;
            this.cb_Enable_Alarm2.Checked = true;
            this.cb_Enable_Alarm2.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Enable_Alarm2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Enable_Alarm2.Location = new System.Drawing.Point(443, 522);
            this.cb_Enable_Alarm2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Enable_Alarm2.Name = "cb_Enable_Alarm2";
            this.cb_Enable_Alarm2.Size = new System.Drawing.Size(151, 29);
            this.cb_Enable_Alarm2.TabIndex = 36;
            this.cb_Enable_Alarm2.Text = "Enable Alarm";
            this.cb_Enable_Alarm2.UseVisualStyleBackColor = true;
            // 
            // cb_Enable_Alarm1
            // 
            this.cb_Enable_Alarm1.AutoSize = true;
            this.cb_Enable_Alarm1.Checked = true;
            this.cb_Enable_Alarm1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cb_Enable_Alarm1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_Enable_Alarm1.Location = new System.Drawing.Point(443, 277);
            this.cb_Enable_Alarm1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cb_Enable_Alarm1.Name = "cb_Enable_Alarm1";
            this.cb_Enable_Alarm1.Size = new System.Drawing.Size(151, 29);
            this.cb_Enable_Alarm1.TabIndex = 35;
            this.cb_Enable_Alarm1.Text = "Enable Alarm";
            this.cb_Enable_Alarm1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1524, 603);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(238, 52);
            this.button1.TabIndex = 37;
            this.button1.Text = "EXPORT DATA";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1840, 677);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cb_Enable_Alarm2);
            this.Controls.Add(this.cb_Enable_Alarm1);
            this.Controls.Add(this.cb2s);
            this.Controls.Add(this.cb1s);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.btChart);
            this.Controls.Add(this.zedGraphControl1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.ThresH2);
            this.Controls.Add(this.ThresL2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ThresH1);
            this.Controls.Add(this.ThresL1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Output_2);
            this.Controls.Add(this.Output_1);
            this.Controls.Add(this.CLOSE);
            this.Controls.Add(this.OPEN);
            this.Controls.Add(this.Data_Received);
            this.Controls.Add(this.shapeContainer1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Temperature Measurement";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.TextBox Data_Received;
        private System.Windows.Forms.Button OPEN;
        private System.Windows.Forms.Button CLOSE;
        private System.Windows.Forms.TextBox Output_1;
        private System.Windows.Forms.TextBox Output_2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DomainUpDown ThresL1;
        private Microsoft.VisualBasic.PowerPacks.ShapeContainer shapeContainer1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape AlarmH2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape AlarmL2;
        private Microsoft.VisualBasic.PowerPacks.OvalShape AlarmH1;
        private Microsoft.VisualBasic.PowerPacks.OvalShape AlarmL1;
        private System.Windows.Forms.DomainUpDown ThresH1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.DomainUpDown ThresH2;
        private System.Windows.Forms.DomainUpDown ThresL2;
        private System.Windows.Forms.Timer timer1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button btChart;
        private System.Windows.Forms.CheckBox cb10s;
        private System.Windows.Forms.CheckBox cb5s;
        private System.Windows.Forms.CheckBox cb2s;
        private System.Windows.Forms.CheckBox cb1s;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cb_Enable_Alarm2;
        private System.Windows.Forms.CheckBox cb_Enable_Alarm1;
        private System.Windows.Forms.Button button1;
    }
}

