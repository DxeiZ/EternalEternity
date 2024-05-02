namespace DxSystemControl
{
    partial class Main
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod
        /*
         * 
         * Author: DxeiZ
         * Github: @DxeiZ
         * 
         */
        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.siticoneGroupBox1 = new ns1.SiticoneGroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.getOS = new System.Windows.Forms.Label();
            this.siticoneGroupBox2 = new ns1.SiticoneGroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.getCPU = new System.Windows.Forms.Label();
            this.siticoneGroupBox3 = new ns1.SiticoneGroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.getRAM = new System.Windows.Forms.Label();
            this.siticoneGroupBox4 = new ns1.SiticoneGroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.getMotherboard = new System.Windows.Forms.Label();
            this.siticoneGroupBox5 = new ns1.SiticoneGroupBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.getGPU = new System.Windows.Forms.Label();
            this.siticoneGroupBox6 = new ns1.SiticoneGroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.getStorage = new System.Windows.Forms.Label();
            this.siticoneGroupBox7 = new ns1.SiticoneGroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.getBIOS = new System.Windows.Forms.Label();
            this.siticoneGroupBox8 = new ns1.SiticoneGroupBox();
            this.panel8 = new System.Windows.Forms.Panel();
            this.getAudio = new System.Windows.Forms.Label();
            this.systemControlBtn = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.siticoneGroupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.siticoneGroupBox2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.siticoneGroupBox3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.siticoneGroupBox4.SuspendLayout();
            this.panel2.SuspendLayout();
            this.siticoneGroupBox5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.siticoneGroupBox6.SuspendLayout();
            this.panel3.SuspendLayout();
            this.siticoneGroupBox7.SuspendLayout();
            this.panel4.SuspendLayout();
            this.siticoneGroupBox8.SuspendLayout();
            this.panel8.SuspendLayout();
            this.SuspendLayout();
            // 
            // siticoneGroupBox1
            // 
            this.siticoneGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox1.BorderRadius = 3;
            this.siticoneGroupBox1.Controls.Add(this.panel1);
            this.siticoneGroupBox1.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox1.Location = new System.Drawing.Point(12, 12);
            this.siticoneGroupBox1.Name = "siticoneGroupBox1";
            this.siticoneGroupBox1.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox1.ShadowDecoration.Parent = this.siticoneGroupBox1;
            this.siticoneGroupBox1.Size = new System.Drawing.Size(200, 133);
            this.siticoneGroupBox1.TabIndex = 1;
            this.siticoneGroupBox1.Text = "İşletim Sistemi";
            this.siticoneGroupBox1.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.getOS);
            this.panel1.Location = new System.Drawing.Point(0, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 108);
            this.panel1.TabIndex = 0;
            // 
            // getOS
            // 
            this.getOS.AutoSize = true;
            this.getOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getOS.Location = new System.Drawing.Point(15, 11);
            this.getOS.Name = "getOS";
            this.getOS.Size = new System.Drawing.Size(70, 17);
            this.getOS.TabIndex = 0;
            this.getOS.Text = "System OS";
            // 
            // siticoneGroupBox2
            // 
            this.siticoneGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox2.BorderRadius = 3;
            this.siticoneGroupBox2.Controls.Add(this.panel5);
            this.siticoneGroupBox2.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox2.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox2.Location = new System.Drawing.Point(218, 12);
            this.siticoneGroupBox2.Name = "siticoneGroupBox2";
            this.siticoneGroupBox2.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox2.ShadowDecoration.Parent = this.siticoneGroupBox2;
            this.siticoneGroupBox2.Size = new System.Drawing.Size(504, 133);
            this.siticoneGroupBox2.TabIndex = 2;
            this.siticoneGroupBox2.Text = "CPU";
            this.siticoneGroupBox2.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel5
            // 
            this.panel5.AutoScroll = true;
            this.panel5.Controls.Add(this.getCPU);
            this.panel5.Location = new System.Drawing.Point(0, 25);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(504, 108);
            this.panel5.TabIndex = 1;
            // 
            // getCPU
            // 
            this.getCPU.AutoSize = true;
            this.getCPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getCPU.Location = new System.Drawing.Point(15, 11);
            this.getCPU.Name = "getCPU";
            this.getCPU.Size = new System.Drawing.Size(77, 17);
            this.getCPU.TabIndex = 1;
            this.getCPU.Text = "System CPU";
            // 
            // siticoneGroupBox3
            // 
            this.siticoneGroupBox3.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox3.BorderRadius = 3;
            this.siticoneGroupBox3.Controls.Add(this.panel6);
            this.siticoneGroupBox3.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox3.Location = new System.Drawing.Point(12, 151);
            this.siticoneGroupBox3.Name = "siticoneGroupBox3";
            this.siticoneGroupBox3.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox3.ShadowDecoration.Parent = this.siticoneGroupBox3;
            this.siticoneGroupBox3.Size = new System.Drawing.Size(299, 133);
            this.siticoneGroupBox3.TabIndex = 3;
            this.siticoneGroupBox3.Text = "RAM";
            this.siticoneGroupBox3.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel6
            // 
            this.panel6.AutoScroll = true;
            this.panel6.Controls.Add(this.getRAM);
            this.panel6.Location = new System.Drawing.Point(0, 25);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(299, 108);
            this.panel6.TabIndex = 2;
            // 
            // getRAM
            // 
            this.getRAM.AutoSize = true;
            this.getRAM.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getRAM.Location = new System.Drawing.Point(15, 11);
            this.getRAM.Name = "getRAM";
            this.getRAM.Size = new System.Drawing.Size(81, 17);
            this.getRAM.TabIndex = 2;
            this.getRAM.Text = "System RAM";
            // 
            // siticoneGroupBox4
            // 
            this.siticoneGroupBox4.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox4.BorderRadius = 3;
            this.siticoneGroupBox4.Controls.Add(this.panel2);
            this.siticoneGroupBox4.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox4.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox4.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox4.Location = new System.Drawing.Point(12, 290);
            this.siticoneGroupBox4.Name = "siticoneGroupBox4";
            this.siticoneGroupBox4.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox4.ShadowDecoration.Parent = this.siticoneGroupBox4;
            this.siticoneGroupBox4.Size = new System.Drawing.Size(299, 133);
            this.siticoneGroupBox4.TabIndex = 2;
            this.siticoneGroupBox4.Text = "Anakart";
            this.siticoneGroupBox4.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.getMotherboard);
            this.panel2.Location = new System.Drawing.Point(0, 25);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(299, 108);
            this.panel2.TabIndex = 1;
            // 
            // getMotherboard
            // 
            this.getMotherboard.AutoSize = true;
            this.getMotherboard.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getMotherboard.Location = new System.Drawing.Point(15, 11);
            this.getMotherboard.Name = "getMotherboard";
            this.getMotherboard.Size = new System.Drawing.Size(132, 17);
            this.getMotherboard.TabIndex = 3;
            this.getMotherboard.Text = "System Motherboard";
            // 
            // siticoneGroupBox5
            // 
            this.siticoneGroupBox5.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox5.BorderRadius = 3;
            this.siticoneGroupBox5.Controls.Add(this.panel7);
            this.siticoneGroupBox5.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox5.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox5.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox5.Location = new System.Drawing.Point(317, 151);
            this.siticoneGroupBox5.Name = "siticoneGroupBox5";
            this.siticoneGroupBox5.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox5.ShadowDecoration.Parent = this.siticoneGroupBox5;
            this.siticoneGroupBox5.Size = new System.Drawing.Size(405, 133);
            this.siticoneGroupBox5.TabIndex = 4;
            this.siticoneGroupBox5.Text = "Grafik Kartı";
            this.siticoneGroupBox5.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel7
            // 
            this.panel7.AutoScroll = true;
            this.panel7.Controls.Add(this.getGPU);
            this.panel7.Location = new System.Drawing.Point(0, 25);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(405, 108);
            this.panel7.TabIndex = 3;
            // 
            // getGPU
            // 
            this.getGPU.AutoSize = true;
            this.getGPU.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getGPU.Location = new System.Drawing.Point(15, 11);
            this.getGPU.Name = "getGPU";
            this.getGPU.Size = new System.Drawing.Size(78, 17);
            this.getGPU.TabIndex = 4;
            this.getGPU.Text = "System GPU";
            // 
            // siticoneGroupBox6
            // 
            this.siticoneGroupBox6.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox6.BorderRadius = 3;
            this.siticoneGroupBox6.Controls.Add(this.panel3);
            this.siticoneGroupBox6.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox6.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox6.Location = new System.Drawing.Point(12, 429);
            this.siticoneGroupBox6.Name = "siticoneGroupBox6";
            this.siticoneGroupBox6.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox6.ShadowDecoration.Parent = this.siticoneGroupBox6;
            this.siticoneGroupBox6.Size = new System.Drawing.Size(710, 67);
            this.siticoneGroupBox6.TabIndex = 3;
            this.siticoneGroupBox6.Text = "Hafıza";
            this.siticoneGroupBox6.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel3
            // 
            this.panel3.AutoScroll = true;
            this.panel3.Controls.Add(this.getStorage);
            this.panel3.Location = new System.Drawing.Point(0, 26);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(710, 41);
            this.panel3.TabIndex = 2;
            // 
            // getStorage
            // 
            this.getStorage.AutoSize = true;
            this.getStorage.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getStorage.Location = new System.Drawing.Point(15, 11);
            this.getStorage.Name = "getStorage";
            this.getStorage.Size = new System.Drawing.Size(99, 17);
            this.getStorage.TabIndex = 5;
            this.getStorage.Text = "System Storage";
            // 
            // siticoneGroupBox7
            // 
            this.siticoneGroupBox7.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox7.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox7.BorderRadius = 3;
            this.siticoneGroupBox7.Controls.Add(this.panel4);
            this.siticoneGroupBox7.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox7.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox7.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox7.Location = new System.Drawing.Point(12, 502);
            this.siticoneGroupBox7.Name = "siticoneGroupBox7";
            this.siticoneGroupBox7.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox7.ShadowDecoration.Parent = this.siticoneGroupBox7;
            this.siticoneGroupBox7.Size = new System.Drawing.Size(710, 67);
            this.siticoneGroupBox7.TabIndex = 4;
            this.siticoneGroupBox7.Text = "BIOS";
            this.siticoneGroupBox7.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel4
            // 
            this.panel4.AutoScroll = true;
            this.panel4.Controls.Add(this.getBIOS);
            this.panel4.Location = new System.Drawing.Point(0, 25);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(710, 42);
            this.panel4.TabIndex = 3;
            // 
            // getBIOS
            // 
            this.getBIOS.AutoSize = true;
            this.getBIOS.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getBIOS.Location = new System.Drawing.Point(15, 11);
            this.getBIOS.Name = "getBIOS";
            this.getBIOS.Size = new System.Drawing.Size(80, 17);
            this.getBIOS.TabIndex = 6;
            this.getBIOS.Text = "System BIOS";
            // 
            // siticoneGroupBox8
            // 
            this.siticoneGroupBox8.BackColor = System.Drawing.Color.Transparent;
            this.siticoneGroupBox8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox8.BorderRadius = 3;
            this.siticoneGroupBox8.Controls.Add(this.panel8);
            this.siticoneGroupBox8.CustomBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.siticoneGroupBox8.CustomBorderThickness = new System.Windows.Forms.Padding(0, 25, 0, 0);
            this.siticoneGroupBox8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(16)))), ((int)(((byte)(18)))));
            this.siticoneGroupBox8.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.siticoneGroupBox8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.siticoneGroupBox8.Location = new System.Drawing.Point(317, 290);
            this.siticoneGroupBox8.Name = "siticoneGroupBox8";
            this.siticoneGroupBox8.ShadowDecoration.BorderRadius = 0;
            this.siticoneGroupBox8.ShadowDecoration.Parent = this.siticoneGroupBox8;
            this.siticoneGroupBox8.Size = new System.Drawing.Size(405, 133);
            this.siticoneGroupBox8.TabIndex = 5;
            this.siticoneGroupBox8.Text = "Ses";
            this.siticoneGroupBox8.TextOffset = new System.Drawing.Point(0, -8);
            // 
            // panel8
            // 
            this.panel8.AutoScroll = true;
            this.panel8.Controls.Add(this.getAudio);
            this.panel8.Location = new System.Drawing.Point(0, 25);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(405, 108);
            this.panel8.TabIndex = 4;
            // 
            // getAudio
            // 
            this.getAudio.AutoSize = true;
            this.getAudio.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.getAudio.Location = new System.Drawing.Point(15, 11);
            this.getAudio.Name = "getAudio";
            this.getAudio.Size = new System.Drawing.Size(87, 17);
            this.getAudio.TabIndex = 7;
            this.getAudio.Text = "System Audio";
            // 
            // systemControlBtn
            // 
            this.systemControlBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(29)))), ((int)(((byte)(32)))));
            this.systemControlBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.systemControlBtn.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.systemControlBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.systemControlBtn.IconChar = FontAwesome.Sharp.IconChar.Toolbox;
            this.systemControlBtn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.systemControlBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.systemControlBtn.IconSize = 20;
            this.systemControlBtn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.systemControlBtn.Location = new System.Drawing.Point(572, 603);
            this.systemControlBtn.Name = "systemControlBtn";
            this.systemControlBtn.Size = new System.Drawing.Size(150, 28);
            this.systemControlBtn.TabIndex = 6;
            this.systemControlBtn.Text = "Bilgisayarı Yönet";
            this.systemControlBtn.UseVisualStyleBackColor = false;
            this.systemControlBtn.Click += new System.EventHandler(this.systemControlBtn_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(87)))), ((int)(((byte)(96)))));
            this.label9.Location = new System.Drawing.Point(9, 618);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(108, 13);
            this.label9.TabIndex = 7;
            this.label9.Text = "Developed by DxeiZ";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(5)))), ((int)(((byte)(6)))));
            this.ClientSize = new System.Drawing.Size(734, 642);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.systemControlBtn);
            this.Controls.Add(this.siticoneGroupBox8);
            this.Controls.Add(this.siticoneGroupBox7);
            this.Controls.Add(this.siticoneGroupBox6);
            this.Controls.Add(this.siticoneGroupBox5);
            this.Controls.Add(this.siticoneGroupBox4);
            this.Controls.Add(this.siticoneGroupBox3);
            this.Controls.Add(this.siticoneGroupBox2);
            this.Controls.Add(this.siticoneGroupBox1);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Eternal Eternity";
            this.siticoneGroupBox1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.siticoneGroupBox2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.siticoneGroupBox3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.siticoneGroupBox4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.siticoneGroupBox5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.siticoneGroupBox6.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.siticoneGroupBox7.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.siticoneGroupBox8.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.panel8.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ns1.SiticoneGroupBox siticoneGroupBox1;
        private ns1.SiticoneGroupBox siticoneGroupBox2;
        private ns1.SiticoneGroupBox siticoneGroupBox3;
        private ns1.SiticoneGroupBox siticoneGroupBox4;
        private ns1.SiticoneGroupBox siticoneGroupBox5;
        private ns1.SiticoneGroupBox siticoneGroupBox6;
        private ns1.SiticoneGroupBox siticoneGroupBox7;
        private ns1.SiticoneGroupBox siticoneGroupBox8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label getOS;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label getCPU;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label getRAM;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label getGPU;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label getBIOS;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label getMotherboard;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label getStorage;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Label getAudio;
        private FontAwesome.Sharp.IconButton systemControlBtn;
        private System.Windows.Forms.Label label9;
    }
}

