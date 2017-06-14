namespace PicWinUSB
{
    partial class PicWinUSB
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PicWinUSB));
            this.BtLedsToggle = new System.Windows.Forms.Button();
            this.BtIniciaADC = new System.Windows.Forms.Button();
            this.AdcBar = new System.Windows.Forms.ProgressBar();
            this.timerADC = new System.Windows.Forms.Timer(this.components);
            this.BtLeds_on = new System.Windows.Forms.Button();
            this.BtPICdivide = new System.Windows.Forms.Button();
            this.TextBoxResultadodivide = new System.Windows.Forms.TextBox();
            this.BtPICmultiplica = new System.Windows.Forms.Button();
            this.TextBoxResultadomultiplica = new System.Windows.Forms.TextBox();
            this.BtPICresta = new System.Windows.Forms.Button();
            this.TextBoxResultadoresta = new System.Windows.Forms.TextBox();
            this.BtLed_rojo = new System.Windows.Forms.Button();
            this.BtLed_verde = new System.Windows.Forms.Button();
            this.BtLeds_off = new System.Windows.Forms.Button();
            this.BtPICsuma = new System.Windows.Forms.Button();
            this.TextBoxResultadosuma = new System.Windows.Forms.TextBox();
            this.PicBoxOsciloscopio = new System.Windows.Forms.PictureBox();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.bunifuElipse1 = new ns1.BunifuElipse(this.components);
            this.Header = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel13 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel12 = new ns1.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuImageButton7 = new ns1.BunifuImageButton();
            this.bunifuImageButton6 = new ns1.BunifuImageButton();
            this.bunifuImageButton1 = new ns1.BunifuImageButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel11 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel10 = new ns1.BunifuCustomLabel();
            this.bunifuCustomLabel9 = new ns1.BunifuCustomLabel();
            this.bunifuCircleProgressbar1 = new ns1.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar2 = new ns1.BunifuCircleProgressbar();
            this.bunifuCircleProgressbar3 = new ns1.BunifuCircleProgressbar();
            this.bunifuDragControl1 = new ns1.BunifuDragControl(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.Header.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // BtLedsToggle
            // 
            this.BtLedsToggle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtLedsToggle.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLedsToggle.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLedsToggle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLedsToggle.Location = new System.Drawing.Point(881, 506);
            this.BtLedsToggle.Name = "BtLedsToggle";
            this.BtLedsToggle.Size = new System.Drawing.Size(161, 38);
            this.BtLedsToggle.TabIndex = 0;
            this.BtLedsToggle.Text = "TOGGLE LEDS";
            this.BtLedsToggle.UseVisualStyleBackColor = false;
            this.BtLedsToggle.Click += new System.EventHandler(this.BtLedToggle_Click);
            // 
            // BtIniciaADC
            // 
            this.BtIniciaADC.BackColor = System.Drawing.Color.White;
            this.BtIniciaADC.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtIniciaADC.Location = new System.Drawing.Point(1063, 256);
            this.BtIniciaADC.Name = "BtIniciaADC";
            this.BtIniciaADC.Size = new System.Drawing.Size(140, 47);
            this.BtIniciaADC.TabIndex = 3;
            this.BtIniciaADC.Text = "Iniciar lecturas del canal AN0";
            this.BtIniciaADC.UseVisualStyleBackColor = false;
            this.BtIniciaADC.Click += new System.EventHandler(this.BtAdc_Click);
            // 
            // AdcBar
            // 
            this.AdcBar.BackColor = System.Drawing.Color.White;
            this.AdcBar.Location = new System.Drawing.Point(1215, 255);
            this.AdcBar.Name = "AdcBar";
            this.AdcBar.Size = new System.Drawing.Size(249, 48);
            this.AdcBar.TabIndex = 4;
            this.AdcBar.Click += new System.EventHandler(this.AdcBar_Click);
            // 
            // timerADC
            // 
            this.timerADC.Interval = 1;
            this.timerADC.Tick += new System.EventHandler(this.timerADC_Tick);
            // 
            // BtLeds_on
            // 
            this.BtLeds_on.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtLeds_on.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLeds_on.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLeds_on.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLeds_on.Location = new System.Drawing.Point(881, 453);
            this.BtLeds_on.Name = "BtLeds_on";
            this.BtLeds_on.Size = new System.Drawing.Size(161, 38);
            this.BtLeds_on.TabIndex = 83;
            this.BtLeds_on.Text = "LEDS ON";
            this.BtLeds_on.UseVisualStyleBackColor = false;
            this.BtLeds_on.Click += new System.EventHandler(this.BtLeds_on_Click);
            // 
            // BtPICdivide
            // 
            this.BtPICdivide.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtPICdivide.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPICdivide.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICdivide.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPICdivide.Location = new System.Drawing.Point(635, 483);
            this.BtPICdivide.Name = "BtPICdivide";
            this.BtPICdivide.Size = new System.Drawing.Size(143, 38);
            this.BtPICdivide.TabIndex = 81;
            this.BtPICdivide.Text = "Sensor Luz";
            this.BtPICdivide.UseVisualStyleBackColor = false;
            this.BtPICdivide.Click += new System.EventHandler(this.BtPICdivide_Click);
            // 
            // TextBoxResultadodivide
            // 
            this.TextBoxResultadodivide.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadodivide.Location = new System.Drawing.Point(635, 527);
            this.TextBoxResultadodivide.MaxLength = 3;
            this.TextBoxResultadodivide.Name = "TextBoxResultadodivide";
            this.TextBoxResultadodivide.Size = new System.Drawing.Size(143, 23);
            this.TextBoxResultadodivide.TabIndex = 80;
            this.TextBoxResultadodivide.TextChanged += new System.EventHandler(this.TextBoxResultadodivide_TextChanged);
            // 
            // BtPICmultiplica
            // 
            this.BtPICmultiplica.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtPICmultiplica.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPICmultiplica.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICmultiplica.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPICmultiplica.Location = new System.Drawing.Point(436, 483);
            this.BtPICmultiplica.Name = "BtPICmultiplica";
            this.BtPICmultiplica.Size = new System.Drawing.Size(143, 38);
            this.BtPICmultiplica.TabIndex = 76;
            this.BtPICmultiplica.Text = "Sensor Gas";
            this.BtPICmultiplica.UseVisualStyleBackColor = false;
            this.BtPICmultiplica.Click += new System.EventHandler(this.BtPICmultiplica_Click);
            // 
            // TextBoxResultadomultiplica
            // 
            this.TextBoxResultadomultiplica.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadomultiplica.Location = new System.Drawing.Point(436, 527);
            this.TextBoxResultadomultiplica.MaxLength = 3;
            this.TextBoxResultadomultiplica.Name = "TextBoxResultadomultiplica";
            this.TextBoxResultadomultiplica.Size = new System.Drawing.Size(143, 23);
            this.TextBoxResultadomultiplica.TabIndex = 75;
            // 
            // BtPICresta
            // 
            this.BtPICresta.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtPICresta.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPICresta.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICresta.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPICresta.Location = new System.Drawing.Point(236, 483);
            this.BtPICresta.Name = "BtPICresta";
            this.BtPICresta.Size = new System.Drawing.Size(143, 38);
            this.BtPICresta.TabIndex = 71;
            this.BtPICresta.Text = "Temperatura";
            this.BtPICresta.UseVisualStyleBackColor = false;
            this.BtPICresta.Click += new System.EventHandler(this.BtPICresta_Click);
            // 
            // TextBoxResultadoresta
            // 
            this.TextBoxResultadoresta.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadoresta.Location = new System.Drawing.Point(236, 527);
            this.TextBoxResultadoresta.MaxLength = 3;
            this.TextBoxResultadoresta.Name = "TextBoxResultadoresta";
            this.TextBoxResultadoresta.Size = new System.Drawing.Size(143, 23);
            this.TextBoxResultadoresta.TabIndex = 70;
            // 
            // BtLed_rojo
            // 
            this.BtLed_rojo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtLed_rojo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLed_rojo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLed_rojo.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLed_rojo.Location = new System.Drawing.Point(881, 404);
            this.BtLed_rojo.Name = "BtLed_rojo";
            this.BtLed_rojo.Size = new System.Drawing.Size(161, 38);
            this.BtLed_rojo.TabIndex = 64;
            this.BtLed_rojo.Text = "LED ROJO ON";
            this.BtLed_rojo.UseVisualStyleBackColor = false;
            this.BtLed_rojo.Click += new System.EventHandler(this.BtLed_rojo_Click);
            // 
            // BtLed_verde
            // 
            this.BtLed_verde.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtLed_verde.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLed_verde.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLed_verde.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLed_verde.Location = new System.Drawing.Point(881, 356);
            this.BtLed_verde.Name = "BtLed_verde";
            this.BtLed_verde.Size = new System.Drawing.Size(161, 38);
            this.BtLed_verde.TabIndex = 63;
            this.BtLed_verde.Text = "LED VERDE ON";
            this.BtLed_verde.UseVisualStyleBackColor = false;
            this.BtLed_verde.Click += new System.EventHandler(this.BtLed_verde_Click);
            // 
            // BtLeds_off
            // 
            this.BtLeds_off.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtLeds_off.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtLeds_off.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtLeds_off.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtLeds_off.Location = new System.Drawing.Point(881, 307);
            this.BtLeds_off.Name = "BtLeds_off";
            this.BtLeds_off.Size = new System.Drawing.Size(161, 38);
            this.BtLeds_off.TabIndex = 62;
            this.BtLeds_off.Text = "LEDS OFF";
            this.BtLeds_off.UseVisualStyleBackColor = false;
            this.BtLeds_off.Click += new System.EventHandler(this.BtLeds_off_Click);
            // 
            // BtPICsuma
            // 
            this.BtPICsuma.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.BtPICsuma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtPICsuma.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtPICsuma.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BtPICsuma.Location = new System.Drawing.Point(31, 483);
            this.BtPICsuma.Name = "BtPICsuma";
            this.BtPICsuma.Size = new System.Drawing.Size(143, 38);
            this.BtPICsuma.TabIndex = 61;
            this.BtPICsuma.Text = "Sensor PIR";
            this.BtPICsuma.UseVisualStyleBackColor = false;
            this.BtPICsuma.Click += new System.EventHandler(this.BtPICsuma_Click);
            // 
            // TextBoxResultadosuma
            // 
            this.TextBoxResultadosuma.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBoxResultadosuma.Location = new System.Drawing.Point(31, 527);
            this.TextBoxResultadosuma.MaxLength = 3;
            this.TextBoxResultadosuma.Name = "TextBoxResultadosuma";
            this.TextBoxResultadosuma.Size = new System.Drawing.Size(143, 23);
            this.TextBoxResultadosuma.TabIndex = 60;
            this.TextBoxResultadosuma.TextChanged += new System.EventHandler(this.TextBoxResultadosuma_TextChanged);
            // 
            // PicBoxOsciloscopio
            // 
            this.PicBoxOsciloscopio.BackColor = System.Drawing.Color.White;
            this.PicBoxOsciloscopio.Location = new System.Drawing.Point(1063, 309);
            this.PicBoxOsciloscopio.Name = "PicBoxOsciloscopio";
            this.PicBoxOsciloscopio.Size = new System.Drawing.Size(401, 256);
            this.PicBoxOsciloscopio.TabIndex = 85;
            this.PicBoxOsciloscopio.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(75, 337);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(44, 57);
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 5;
            this.bunifuElipse1.TargetControl = this;
            // 
            // Header
            // 
            this.Header.AllowDrop = true;
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.Header.Controls.Add(this.bunifuCustomLabel13);
            this.Header.Controls.Add(this.bunifuCustomLabel12);
            this.Header.Controls.Add(this.panel1);
            this.Header.Controls.Add(this.bunifuImageButton1);
            this.Header.Location = new System.Drawing.Point(0, 0);
            this.Header.Name = "Header";
            this.Header.Size = new System.Drawing.Size(1487, 153);
            this.Header.TabIndex = 87;
            // 
            // bunifuCustomLabel13
            // 
            this.bunifuCustomLabel13.AutoSize = true;
            this.bunifuCustomLabel13.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel13.Font = new System.Drawing.Font("Century Gothic", 9.25F);
            this.bunifuCustomLabel13.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel13.Location = new System.Drawing.Point(57, 34);
            this.bunifuCustomLabel13.Name = "bunifuCustomLabel13";
            this.bunifuCustomLabel13.Size = new System.Drawing.Size(79, 17);
            this.bunifuCustomLabel13.TabIndex = 18;
            this.bunifuCustomLabel13.Text = "ESCOM IPN";
            // 
            // bunifuCustomLabel12
            // 
            this.bunifuCustomLabel12.AutoSize = true;
            this.bunifuCustomLabel12.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuCustomLabel12.Font = new System.Drawing.Font("Century Gothic", 12.25F);
            this.bunifuCustomLabel12.ForeColor = System.Drawing.SystemColors.Control;
            this.bunifuCustomLabel12.Location = new System.Drawing.Point(57, 13);
            this.bunifuCustomLabel12.Name = "bunifuCustomLabel12";
            this.bunifuCustomLabel12.Size = new System.Drawing.Size(322, 21);
            this.bunifuCustomLabel12.TabIndex = 17;
            this.bunifuCustomLabel12.Text = "PROYECTO FINAL INSTRUMENTACIÓN";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuImageButton7);
            this.panel1.Controls.Add(this.bunifuImageButton6);
            this.panel1.Location = new System.Drawing.Point(1402, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(72, 39);
            this.panel1.TabIndex = 12;
            // 
            // bunifuImageButton7
            // 
            this.bunifuImageButton7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.bunifuImageButton7.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton7.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton7.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton7.Image")));
            this.bunifuImageButton7.ImageActive = null;
            this.bunifuImageButton7.Location = new System.Drawing.Point(12, 0);
            this.bunifuImageButton7.Name = "bunifuImageButton7";
            this.bunifuImageButton7.Size = new System.Drawing.Size(30, 39);
            this.bunifuImageButton7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton7.TabIndex = 13;
            this.bunifuImageButton7.TabStop = false;
            this.bunifuImageButton7.Zoom = 0;
            // 
            // bunifuImageButton6
            // 
            this.bunifuImageButton6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.bunifuImageButton6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuImageButton6.Dock = System.Windows.Forms.DockStyle.Right;
            this.bunifuImageButton6.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton6.Image")));
            this.bunifuImageButton6.ImageActive = null;
            this.bunifuImageButton6.Location = new System.Drawing.Point(42, 0);
            this.bunifuImageButton6.Margin = new System.Windows.Forms.Padding(3, 30, 3, 3);
            this.bunifuImageButton6.Name = "bunifuImageButton6";
            this.bunifuImageButton6.Padding = new System.Windows.Forms.Padding(30);
            this.bunifuImageButton6.Size = new System.Drawing.Size(30, 39);
            this.bunifuImageButton6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton6.TabIndex = 12;
            this.bunifuImageButton6.TabStop = false;
            this.bunifuImageButton6.Zoom = 0;
            this.bunifuImageButton6.Click += new System.EventHandler(this.bunifuImageButton6_Click);
            // 
            // bunifuImageButton1
            // 
            this.bunifuImageButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(112)))), ((int)(((byte)(217)))));
            this.bunifuImageButton1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuImageButton1.Image")));
            this.bunifuImageButton1.ImageActive = null;
            this.bunifuImageButton1.Location = new System.Drawing.Point(12, 13);
            this.bunifuImageButton1.Name = "bunifuImageButton1";
            this.bunifuImageButton1.Size = new System.Drawing.Size(39, 39);
            this.bunifuImageButton1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuImageButton1.TabIndex = 0;
            this.bunifuImageButton1.TabStop = false;
            this.bunifuImageButton1.Zoom = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.bunifuCustomLabel11);
            this.panel2.Controls.Add(this.bunifuCustomLabel10);
            this.panel2.Controls.Add(this.bunifuCustomLabel9);
            this.panel2.Location = new System.Drawing.Point(-4, 153);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1491, 44);
            this.panel2.TabIndex = 88;
            // 
            // bunifuCustomLabel11
            // 
            this.bunifuCustomLabel11.AutoSize = true;
            this.bunifuCustomLabel11.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel11.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.bunifuCustomLabel11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel11.Location = new System.Drawing.Point(258, 12);
            this.bunifuCustomLabel11.Name = "bunifuCustomLabel11";
            this.bunifuCustomLabel11.Size = new System.Drawing.Size(110, 19);
            this.bunifuCustomLabel11.TabIndex = 15;
            this.bunifuCustomLabel11.Text = "CALCULADORA";
            // 
            // bunifuCustomLabel10
            // 
            this.bunifuCustomLabel10.AutoSize = true;
            this.bunifuCustomLabel10.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel10.Font = new System.Drawing.Font("Century Gothic", 10.25F);
            this.bunifuCustomLabel10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel10.Location = new System.Drawing.Point(104, 12);
            this.bunifuCustomLabel10.Name = "bunifuCustomLabel10";
            this.bunifuCustomLabel10.Size = new System.Drawing.Size(142, 19);
            this.bunifuCustomLabel10.TabIndex = 14;
            this.bunifuCustomLabel10.Text = "CONTROLADOR LED";
            // 
            // bunifuCustomLabel9
            // 
            this.bunifuCustomLabel9.AutoSize = true;
            this.bunifuCustomLabel9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuCustomLabel9.Font = new System.Drawing.Font("Century Gothic", 11.25F);
            this.bunifuCustomLabel9.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.bunifuCustomLabel9.Location = new System.Drawing.Point(16, 12);
            this.bunifuCustomLabel9.Name = "bunifuCustomLabel9";
            this.bunifuCustomLabel9.Size = new System.Drawing.Size(79, 20);
            this.bunifuCustomLabel9.TabIndex = 13;
            this.bunifuCustomLabel9.Text = "SENSORES";
            // 
            // bunifuCircleProgressbar1
            // 
            this.bunifuCircleProgressbar1.animated = false;
            this.bunifuCircleProgressbar1.animationIterval = 5;
            this.bunifuCircleProgressbar1.animationSpeed = 300;
            this.bunifuCircleProgressbar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bunifuCircleProgressbar1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar1.BackgroundImage")));
            this.bunifuCircleProgressbar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar1.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar1.LabelVisible = false;
            this.bunifuCircleProgressbar1.LineProgressThickness = 8;
            this.bunifuCircleProgressbar1.LineThickness = 5;
            this.bunifuCircleProgressbar1.Location = new System.Drawing.Point(236, 307);
            this.bunifuCircleProgressbar1.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar1.MaxValue = 100;
            this.bunifuCircleProgressbar1.Name = "bunifuCircleProgressbar1";
            this.bunifuCircleProgressbar1.ProgressBackColor = System.Drawing.Color.DimGray;
            this.bunifuCircleProgressbar1.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuCircleProgressbar1.Size = new System.Drawing.Size(145, 145);
            this.bunifuCircleProgressbar1.TabIndex = 89;
            this.bunifuCircleProgressbar1.Value = 0;
            // 
            // bunifuCircleProgressbar2
            // 
            this.bunifuCircleProgressbar2.animated = false;
            this.bunifuCircleProgressbar2.animationIterval = 5;
            this.bunifuCircleProgressbar2.animationSpeed = 300;
            this.bunifuCircleProgressbar2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bunifuCircleProgressbar2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar2.BackgroundImage")));
            this.bunifuCircleProgressbar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar2.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar2.LabelVisible = false;
            this.bunifuCircleProgressbar2.LineProgressThickness = 8;
            this.bunifuCircleProgressbar2.LineThickness = 5;
            this.bunifuCircleProgressbar2.Location = new System.Drawing.Point(436, 307);
            this.bunifuCircleProgressbar2.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar2.MaxValue = 100;
            this.bunifuCircleProgressbar2.Name = "bunifuCircleProgressbar2";
            this.bunifuCircleProgressbar2.ProgressBackColor = System.Drawing.Color.DimGray;
            this.bunifuCircleProgressbar2.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuCircleProgressbar2.Size = new System.Drawing.Size(145, 145);
            this.bunifuCircleProgressbar2.TabIndex = 90;
            this.bunifuCircleProgressbar2.Value = 0;
            // 
            // bunifuCircleProgressbar3
            // 
            this.bunifuCircleProgressbar3.animated = false;
            this.bunifuCircleProgressbar3.animationIterval = 5;
            this.bunifuCircleProgressbar3.animationSpeed = 300;
            this.bunifuCircleProgressbar3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.bunifuCircleProgressbar3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuCircleProgressbar3.BackgroundImage")));
            this.bunifuCircleProgressbar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F);
            this.bunifuCircleProgressbar3.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuCircleProgressbar3.LabelVisible = false;
            this.bunifuCircleProgressbar3.LineProgressThickness = 8;
            this.bunifuCircleProgressbar3.LineThickness = 5;
            this.bunifuCircleProgressbar3.Location = new System.Drawing.Point(633, 307);
            this.bunifuCircleProgressbar3.Margin = new System.Windows.Forms.Padding(10, 9, 10, 9);
            this.bunifuCircleProgressbar3.MaxValue = 100;
            this.bunifuCircleProgressbar3.Name = "bunifuCircleProgressbar3";
            this.bunifuCircleProgressbar3.ProgressBackColor = System.Drawing.Color.DimGray;
            this.bunifuCircleProgressbar3.ProgressColor = System.Drawing.Color.Teal;
            this.bunifuCircleProgressbar3.Size = new System.Drawing.Size(145, 145);
            this.bunifuCircleProgressbar3.TabIndex = 91;
            this.bunifuCircleProgressbar3.Value = 0;
            // 
            // bunifuDragControl1
            // 
            this.bunifuDragControl1.Fixed = true;
            this.bunifuDragControl1.Horizontal = true;
            this.bunifuDragControl1.TargetControl = this.Header;
            this.bunifuDragControl1.Vertical = true;
            // 
            // PicWinUSB
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.ClientSize = new System.Drawing.Size(1486, 587);
            this.Controls.Add(this.bunifuCircleProgressbar3);
            this.Controls.Add(this.bunifuCircleProgressbar2);
            this.Controls.Add(this.bunifuCircleProgressbar1);
            this.Controls.Add(this.Header);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.PicBoxOsciloscopio);
            this.Controls.Add(this.BtLeds_on);
            this.Controls.Add(this.BtPICdivide);
            this.Controls.Add(this.TextBoxResultadodivide);
            this.Controls.Add(this.BtPICmultiplica);
            this.Controls.Add(this.TextBoxResultadomultiplica);
            this.Controls.Add(this.BtPICresta);
            this.Controls.Add(this.TextBoxResultadoresta);
            this.Controls.Add(this.BtLed_rojo);
            this.Controls.Add(this.BtLed_verde);
            this.Controls.Add(this.BtLeds_off);
            this.Controls.Add(this.BtPICsuma);
            this.Controls.Add(this.TextBoxResultadosuma);
            this.Controls.Add(this.AdcBar);
            this.Controls.Add(this.BtIniciaADC);
            this.Controls.Add(this.BtLedsToggle);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PicWinUSB";
            this.Text = "ESCOM-IPN (PIC-WinUSB)";
            this.Load += new System.EventHandler(this.PicWinUSB_Load);
            ((System.ComponentModel.ISupportInitialize)(this.PicBoxOsciloscopio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.Header.ResumeLayout(false);
            this.Header.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuImageButton1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtLedsToggle;
        private System.Windows.Forms.Button BtIniciaADC;
        private System.Windows.Forms.ProgressBar AdcBar;
        private System.Windows.Forms.Timer timerADC;
        private System.Windows.Forms.Button BtLeds_on;
        private System.Windows.Forms.Button BtPICdivide;
        private System.Windows.Forms.TextBox TextBoxResultadodivide;
        private System.Windows.Forms.Button BtPICmultiplica;
        private System.Windows.Forms.TextBox TextBoxResultadomultiplica;
        private System.Windows.Forms.Button BtPICresta;
        private System.Windows.Forms.TextBox TextBoxResultadoresta;
        private System.Windows.Forms.Button BtLed_rojo;
        private System.Windows.Forms.Button BtLed_verde;
        private System.Windows.Forms.Button BtLeds_off;
        private System.Windows.Forms.Button BtPICsuma;
        private System.Windows.Forms.TextBox TextBoxResultadosuma;
        private System.Windows.Forms.PictureBox PicBoxOsciloscopio;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.PictureBox pictureBox4;
        private ns1.BunifuElipse bunifuElipse1;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar3;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar2;
        private ns1.BunifuCircleProgressbar bunifuCircleProgressbar1;
        private System.Windows.Forms.Panel Header;
        private ns1.BunifuCustomLabel bunifuCustomLabel13;
        private ns1.BunifuCustomLabel bunifuCustomLabel12;
        private System.Windows.Forms.Panel panel1;
        private ns1.BunifuImageButton bunifuImageButton7;
        private ns1.BunifuImageButton bunifuImageButton6;
        private ns1.BunifuImageButton bunifuImageButton1;
        private System.Windows.Forms.Panel panel2;
        private ns1.BunifuCustomLabel bunifuCustomLabel11;
        private ns1.BunifuCustomLabel bunifuCustomLabel10;
        private ns1.BunifuCustomLabel bunifuCustomLabel9;
        private ns1.BunifuDragControl bunifuDragControl1;
    }
}

