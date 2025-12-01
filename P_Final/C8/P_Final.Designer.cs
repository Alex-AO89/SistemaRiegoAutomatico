namespace C8
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.CBPuertos = new System.Windows.Forms.ComboBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.labelPuertoSerie = new System.Windows.Forms.Label();
            this.labelFoco = new System.Windows.Forms.Label();
            this.labelVentilador = new System.Windows.Forms.Label();
            this.BtnEncender1 = new System.Windows.Forms.Button();
            this.BtnApagar1 = new System.Windows.Forms.Button();
            this.BtnEncender2 = new System.Windows.Forms.Button();
            this.BtnApagar2 = new System.Windows.Forms.Button();
            this.labelEstadoAct = new System.Windows.Forms.Label();
            this.labelAspersor = new System.Windows.Forms.Label();
            this.labelPuerta = new System.Windows.Forms.Label();
            this.BtnEncender3 = new System.Windows.Forms.Button();
            this.BtnApagar3 = new System.Windows.Forms.Button();
            this.BtnEncender4 = new System.Windows.Forms.Button();
            this.BtnApagar4 = new System.Windows.Forms.Button();
            this.panelActuadores = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.buttonAuto = new System.Windows.Forms.Button();
            this.buttonManual = new System.Windows.Forms.Button();
            this.lblLuz1 = new System.Windows.Forms.Label();
            this.lblLuz2 = new System.Windows.Forms.Label();
            this.progressBarHumedad = new System.Windows.Forms.ProgressBar();
            this.lblHumedad = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox10 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox11 = new System.Windows.Forms.PictureBox();
            this.pictureBox12 = new System.Windows.Forms.PictureBox();
            this.panelActuadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).BeginInit();
            this.SuspendLayout();
            // 
            // CBPuertos
            // 
            this.CBPuertos.BackColor = System.Drawing.Color.LightBlue;
            this.CBPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPuertos.ForeColor = System.Drawing.Color.Black;
            this.CBPuertos.FormattingEnabled = true;
            this.CBPuertos.Location = new System.Drawing.Point(13, 51);
            this.CBPuertos.Margin = new System.Windows.Forms.Padding(2);
            this.CBPuertos.Name = "CBPuertos";
            this.CBPuertos.Size = new System.Drawing.Size(92, 21);
            this.CBPuertos.TabIndex = 0;
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.Black;
            this.BtnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.ForeColor = System.Drawing.Color.White;
            this.BtnConectar.Location = new System.Drawing.Point(122, 11);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(88, 32);
            this.BtnConectar.TabIndex = 1;
            this.BtnConectar.Text = "Conectar";
            this.BtnConectar.UseVisualStyleBackColor = false;
            this.BtnConectar.Click += new System.EventHandler(this.BtnConectar_Click);
            // 
            // PuertoSerie
            // 
            this.PuertoSerie.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.PuertoSerie_DataReceived);
            // 
            // BtnDesconectar
            // 
            this.BtnDesconectar.BackColor = System.Drawing.Color.Black;
            this.BtnDesconectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnDesconectar.ForeColor = System.Drawing.Color.White;
            this.BtnDesconectar.Location = new System.Drawing.Point(122, 47);
            this.BtnDesconectar.Margin = new System.Windows.Forms.Padding(2);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(88, 32);
            this.BtnDesconectar.TabIndex = 2;
            this.BtnDesconectar.Text = "Desconectar";
            this.BtnDesconectar.UseVisualStyleBackColor = false;
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // labelPuertoSerie
            // 
            this.labelPuertoSerie.AutoSize = true;
            this.labelPuertoSerie.BackColor = System.Drawing.Color.Transparent;
            this.labelPuertoSerie.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPuertoSerie.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.labelPuertoSerie.Location = new System.Drawing.Point(9, 16);
            this.labelPuertoSerie.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuertoSerie.Name = "labelPuertoSerie";
            this.labelPuertoSerie.Size = new System.Drawing.Size(109, 20);
            this.labelPuertoSerie.TabIndex = 14;
            this.labelPuertoSerie.Text = "Puerto Serie";
            // 
            // labelFoco
            // 
            this.labelFoco.AutoSize = true;
            this.labelFoco.BackColor = System.Drawing.Color.White;
            this.labelFoco.Font = new System.Drawing.Font("Lucida Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelFoco.Location = new System.Drawing.Point(115, 65);
            this.labelFoco.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelFoco.Name = "labelFoco";
            this.labelFoco.Size = new System.Drawing.Size(89, 32);
            this.labelFoco.TabIndex = 3;
            this.labelFoco.Text = "Luz 1";
            // 
            // labelVentilador
            // 
            this.labelVentilador.AutoSize = true;
            this.labelVentilador.BackColor = System.Drawing.Color.White;
            this.labelVentilador.Font = new System.Drawing.Font("Lucida Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelVentilador.Location = new System.Drawing.Point(448, 65);
            this.labelVentilador.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelVentilador.Name = "labelVentilador";
            this.labelVentilador.Size = new System.Drawing.Size(89, 32);
            this.labelVentilador.TabIndex = 4;
            this.labelVentilador.Text = "Luz 2";
            // 
            // BtnEncender1
            // 
            this.BtnEncender1.BackColor = System.Drawing.Color.Black;
            this.BtnEncender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender1.ForeColor = System.Drawing.Color.White;
            this.BtnEncender1.Location = new System.Drawing.Point(19, 208);
            this.BtnEncender1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEncender1.Name = "BtnEncender1";
            this.BtnEncender1.Size = new System.Drawing.Size(146, 40);
            this.BtnEncender1.TabIndex = 5;
            this.BtnEncender1.Text = "Encender";
            this.BtnEncender1.UseVisualStyleBackColor = false;
            this.BtnEncender1.Click += new System.EventHandler(this.BtnEncender1_Click);
            // 
            // BtnApagar1
            // 
            this.BtnApagar1.BackColor = System.Drawing.Color.Black;
            this.BtnApagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.BtnApagar1.ForeColor = System.Drawing.Color.White;
            this.BtnApagar1.Location = new System.Drawing.Point(169, 208);
            this.BtnApagar1.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagar1.Name = "BtnApagar1";
            this.BtnApagar1.Size = new System.Drawing.Size(146, 40);
            this.BtnApagar1.TabIndex = 6;
            this.BtnApagar1.Text = "Apagar";
            this.BtnApagar1.UseVisualStyleBackColor = false;
            this.BtnApagar1.Click += new System.EventHandler(this.BtnApagar1_Click);
            // 
            // BtnEncender2
            // 
            this.BtnEncender2.BackColor = System.Drawing.Color.Black;
            this.BtnEncender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender2.ForeColor = System.Drawing.Color.White;
            this.BtnEncender2.Location = new System.Drawing.Point(336, 208);
            this.BtnEncender2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEncender2.Name = "BtnEncender2";
            this.BtnEncender2.Size = new System.Drawing.Size(146, 40);
            this.BtnEncender2.TabIndex = 7;
            this.BtnEncender2.Text = "Encender";
            this.BtnEncender2.UseVisualStyleBackColor = false;
            this.BtnEncender2.Click += new System.EventHandler(this.BtnEncender2_Click);
            // 
            // BtnApagar2
            // 
            this.BtnApagar2.BackColor = System.Drawing.Color.Black;
            this.BtnApagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar2.ForeColor = System.Drawing.Color.White;
            this.BtnApagar2.Location = new System.Drawing.Point(500, 208);
            this.BtnApagar2.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagar2.Name = "BtnApagar2";
            this.BtnApagar2.Size = new System.Drawing.Size(146, 40);
            this.BtnApagar2.TabIndex = 8;
            this.BtnApagar2.Text = "Apagar";
            this.BtnApagar2.UseVisualStyleBackColor = false;
            this.BtnApagar2.Click += new System.EventHandler(this.BtnApagar2_Click);
            // 
            // labelEstadoAct
            // 
            this.labelEstadoAct.AutoSize = true;
            this.labelEstadoAct.BackColor = System.Drawing.Color.Black;
            this.labelEstadoAct.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEstadoAct.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelEstadoAct.Location = new System.Drawing.Point(147, 17);
            this.labelEstadoAct.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelEstadoAct.Name = "labelEstadoAct";
            this.labelEstadoAct.Size = new System.Drawing.Size(340, 37);
            this.labelEstadoAct.TabIndex = 12;
            this.labelEstadoAct.Text = "Control del la Maseta";
            // 
            // labelAspersor
            // 
            this.labelAspersor.AutoSize = true;
            this.labelAspersor.BackColor = System.Drawing.Color.White;
            this.labelAspersor.Font = new System.Drawing.Font("Lucida Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelAspersor.Location = new System.Drawing.Point(61, 257);
            this.labelAspersor.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelAspersor.Name = "labelAspersor";
            this.labelAspersor.Size = new System.Drawing.Size(225, 32);
            this.labelAspersor.TabIndex = 15;
            this.labelAspersor.Text = "Bomba de agua";
            // 
            // labelPuerta
            // 
            this.labelPuerta.AutoSize = true;
            this.labelPuerta.BackColor = System.Drawing.Color.White;
            this.labelPuerta.Font = new System.Drawing.Font("Lucida Sans", 20F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.labelPuerta.Location = new System.Drawing.Point(431, 257);
            this.labelPuerta.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelPuerta.Name = "labelPuerta";
            this.labelPuerta.Size = new System.Drawing.Size(115, 32);
            this.labelPuerta.TabIndex = 16;
            this.labelPuerta.Text = "Alarma";
            // 
            // BtnEncender3
            // 
            this.BtnEncender3.BackColor = System.Drawing.Color.Black;
            this.BtnEncender3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender3.ForeColor = System.Drawing.Color.White;
            this.BtnEncender3.Location = new System.Drawing.Point(19, 401);
            this.BtnEncender3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEncender3.Name = "BtnEncender3";
            this.BtnEncender3.Size = new System.Drawing.Size(146, 40);
            this.BtnEncender3.TabIndex = 17;
            this.BtnEncender3.Text = "Abrir";
            this.BtnEncender3.UseVisualStyleBackColor = false;
            this.BtnEncender3.Click += new System.EventHandler(this.BtnEncender3_Click);
            // 
            // BtnApagar3
            // 
            this.BtnApagar3.BackColor = System.Drawing.Color.Black;
            this.BtnApagar3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar3.ForeColor = System.Drawing.Color.White;
            this.BtnApagar3.Location = new System.Drawing.Point(169, 401);
            this.BtnApagar3.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagar3.Name = "BtnApagar3";
            this.BtnApagar3.Size = new System.Drawing.Size(146, 40);
            this.BtnApagar3.TabIndex = 18;
            this.BtnApagar3.Text = "Cerrar";
            this.BtnApagar3.UseVisualStyleBackColor = false;
            this.BtnApagar3.Click += new System.EventHandler(this.BtnApagar3_Click);
            // 
            // BtnEncender4
            // 
            this.BtnEncender4.BackColor = System.Drawing.Color.Black;
            this.BtnEncender4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender4.ForeColor = System.Drawing.Color.White;
            this.BtnEncender4.Location = new System.Drawing.Point(336, 401);
            this.BtnEncender4.Margin = new System.Windows.Forms.Padding(2);
            this.BtnEncender4.Name = "BtnEncender4";
            this.BtnEncender4.Size = new System.Drawing.Size(146, 40);
            this.BtnEncender4.TabIndex = 19;
            this.BtnEncender4.Text = "Encender";
            this.BtnEncender4.UseVisualStyleBackColor = false;
            this.BtnEncender4.Click += new System.EventHandler(this.BtnEncender4_Click);
            // 
            // BtnApagar4
            // 
            this.BtnApagar4.BackColor = System.Drawing.Color.Black;
            this.BtnApagar4.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar4.ForeColor = System.Drawing.Color.White;
            this.BtnApagar4.Location = new System.Drawing.Point(500, 401);
            this.BtnApagar4.Margin = new System.Windows.Forms.Padding(2);
            this.BtnApagar4.Name = "BtnApagar4";
            this.BtnApagar4.Size = new System.Drawing.Size(146, 40);
            this.BtnApagar4.TabIndex = 20;
            this.BtnApagar4.Text = "Apagar";
            this.BtnApagar4.UseVisualStyleBackColor = false;
            this.BtnApagar4.Click += new System.EventHandler(this.BtnApagar4_Click);
            // 
            // panelActuadores
            // 
            this.panelActuadores.BackColor = System.Drawing.Color.Transparent;
            this.panelActuadores.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panelActuadores.BackgroundImage")));
            this.panelActuadores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panelActuadores.Controls.Add(this.pictureBox4);
            this.panelActuadores.Controls.Add(this.pictureBox3);
            this.panelActuadores.Controls.Add(this.BtnApagar4);
            this.panelActuadores.Controls.Add(this.BtnEncender4);
            this.panelActuadores.Controls.Add(this.BtnApagar3);
            this.panelActuadores.Controls.Add(this.BtnEncender3);
            this.panelActuadores.Controls.Add(this.labelPuerta);
            this.panelActuadores.Controls.Add(this.labelAspersor);
            this.panelActuadores.Controls.Add(this.labelEstadoAct);
            this.panelActuadores.Controls.Add(this.pictureBox2);
            this.panelActuadores.Controls.Add(this.pictureBox1);
            this.panelActuadores.Controls.Add(this.BtnApagar2);
            this.panelActuadores.Controls.Add(this.BtnEncender2);
            this.panelActuadores.Controls.Add(this.BtnApagar1);
            this.panelActuadores.Controls.Add(this.BtnEncender1);
            this.panelActuadores.Controls.Add(this.labelVentilador);
            this.panelActuadores.Controls.Add(this.labelFoco);
            this.panelActuadores.Location = new System.Drawing.Point(122, 168);
            this.panelActuadores.Margin = new System.Windows.Forms.Padding(2);
            this.panelActuadores.Name = "panelActuadores";
            this.panelActuadores.Size = new System.Drawing.Size(656, 468);
            this.panelActuadores.TabIndex = 23;
            this.panelActuadores.Paint += new System.Windows.Forms.PaintEventHandler(this.panelActuadores_Paint);
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::C8.Properties.Resources.SirenaAp;
            this.pictureBox4.Location = new System.Drawing.Point(454, 304);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(80, 80);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 22;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::C8.Properties.Resources.led_green_off;
            this.pictureBox3.Location = new System.Drawing.Point(121, 304);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(80, 80);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 21;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::C8.Properties.Resources.led_ROJO_off;
            this.pictureBox2.Location = new System.Drawing.Point(454, 122);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(80, 80);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::C8.Properties.Resources.led_green_off;
            this.pictureBox1.Location = new System.Drawing.Point(121, 122);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(80, 80);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // buttonAuto
            // 
            this.buttonAuto.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonAuto.ForeColor = System.Drawing.Color.White;
            this.buttonAuto.Location = new System.Drawing.Point(693, 101);
            this.buttonAuto.Margin = new System.Windows.Forms.Padding(2);
            this.buttonAuto.Name = "buttonAuto";
            this.buttonAuto.Size = new System.Drawing.Size(250, 50);
            this.buttonAuto.TabIndex = 25;
            this.buttonAuto.Text = "Modo Automático";
            this.buttonAuto.UseVisualStyleBackColor = false;
            this.buttonAuto.Click += new System.EventHandler(this.buttonAuto_Click_1);
            // 
            // buttonManual
            // 
            this.buttonManual.BackColor = System.Drawing.Color.ForestGreen;
            this.buttonManual.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold);
            this.buttonManual.ForeColor = System.Drawing.Color.White;
            this.buttonManual.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonManual.Location = new System.Drawing.Point(423, 101);
            this.buttonManual.Margin = new System.Windows.Forms.Padding(2);
            this.buttonManual.Name = "buttonManual";
            this.buttonManual.Size = new System.Drawing.Size(250, 50);
            this.buttonManual.TabIndex = 24;
            this.buttonManual.Text = "Modo Manual";
            this.buttonManual.UseVisualStyleBackColor = false;
            this.buttonManual.Click += new System.EventHandler(this.buttonManual_Click);
            // 
            // lblLuz1
            // 
            this.lblLuz1.AutoSize = true;
            this.lblLuz1.BackColor = System.Drawing.Color.White;
            this.lblLuz1.Font = new System.Drawing.Font("Perpetua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLuz1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.lblLuz1.Location = new System.Drawing.Point(136, 79);
            this.lblLuz1.Name = "lblLuz1";
            this.lblLuz1.Size = new System.Drawing.Size(84, 39);
            this.lblLuz1.TabIndex = 27;
            this.lblLuz1.Text = "Luz1";
            // 
            // lblLuz2
            // 
            this.lblLuz2.AutoSize = true;
            this.lblLuz2.BackColor = System.Drawing.Color.White;
            this.lblLuz2.Font = new System.Drawing.Font("Perpetua", 25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblLuz2.Location = new System.Drawing.Point(136, 177);
            this.lblLuz2.Name = "lblLuz2";
            this.lblLuz2.Size = new System.Drawing.Size(84, 39);
            this.lblLuz2.TabIndex = 28;
            this.lblLuz2.Text = "Luz2";
            // 
            // progressBarHumedad
            // 
            this.progressBarHumedad.Location = new System.Drawing.Point(141, 270);
            this.progressBarHumedad.Name = "progressBarHumedad";
            this.progressBarHumedad.Size = new System.Drawing.Size(177, 31);
            this.progressBarHumedad.TabIndex = 29;
            // 
            // lblHumedad
            // 
            this.lblHumedad.AutoSize = true;
            this.lblHumedad.BackColor = System.Drawing.Color.White;
            this.lblHumedad.Font = new System.Drawing.Font("Perpetua", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.lblHumedad.Location = new System.Drawing.Point(137, 314);
            this.lblHumedad.Name = "lblHumedad";
            this.lblHumedad.Size = new System.Drawing.Size(87, 23);
            this.lblHumedad.TabIndex = 30;
            this.lblHumedad.Text = "Humedad";
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Location = new System.Drawing.Point(238, 361);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(80, 80);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 23;
            this.pictureBox5.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Calibri", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.label1.Location = new System.Drawing.Point(526, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 49);
            this.label1.TabIndex = 31;
            this.label1.Text = "Jardin Inteligente";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pictureBox10);
            this.panel1.Controls.Add(this.pictureBox9);
            this.panel1.Controls.Add(this.pictureBox8);
            this.panel1.Controls.Add(this.pictureBox7);
            this.panel1.Controls.Add(this.pictureBox6);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.lblLuz2);
            this.panel1.Controls.Add(this.pictureBox5);
            this.panel1.Controls.Add(this.lblLuz1);
            this.panel1.Controls.Add(this.lblHumedad);
            this.panel1.Controls.Add(this.progressBarHumedad);
            this.panel1.Location = new System.Drawing.Point(850, 168);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(356, 468);
            this.panel1.TabIndex = 32;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // pictureBox10
            // 
            this.pictureBox10.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox10.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox10.Image")));
            this.pictureBox10.Location = new System.Drawing.Point(143, 372);
            this.pictureBox10.Name = "pictureBox10";
            this.pictureBox10.Size = new System.Drawing.Size(69, 59);
            this.pictureBox10.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox10.TabIndex = 35;
            this.pictureBox10.TabStop = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox9.Image")));
            this.pictureBox9.Location = new System.Drawing.Point(28, 361);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(90, 80);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox9.TabIndex = 34;
            this.pictureBox9.TabStop = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(28, 257);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(80, 80);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox8.TabIndex = 33;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(28, 157);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(80, 80);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 32;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox6.InitialImage")));
            this.pictureBox6.Location = new System.Drawing.Point(28, 59);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(80, 80);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox6.TabIndex = 31;
            this.pictureBox6.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Black;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(102, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(156, 37);
            this.label2.TabIndex = 23;
            this.label2.Text = "Mi planta";
            // 
            // pictureBox11
            // 
            this.pictureBox11.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox11.Location = new System.Drawing.Point(449, 27);
            this.pictureBox11.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox11.Name = "pictureBox11";
            this.pictureBox11.Size = new System.Drawing.Size(56, 53);
            this.pictureBox11.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox11.TabIndex = 23;
            this.pictureBox11.TabStop = false;
            // 
            // pictureBox12
            // 
            this.pictureBox12.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox12.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox12.Image")));
            this.pictureBox12.InitialImage = null;
            this.pictureBox12.Location = new System.Drawing.Point(850, 12);
            this.pictureBox12.Name = "pictureBox12";
            this.pictureBox12.Size = new System.Drawing.Size(87, 76);
            this.pictureBox12.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox12.TabIndex = 33;
            this.pictureBox12.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1350, 729);
            this.Controls.Add(this.pictureBox12);
            this.Controls.Add(this.pictureBox11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonAuto);
            this.Controls.Add(this.buttonManual);
            this.Controls.Add(this.panelActuadores);
            this.Controls.Add(this.labelPuertoSerie);
            this.Controls.Add(this.BtnDesconectar);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.CBPuertos);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelActuadores.ResumeLayout(false);
            this.panelActuadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox10)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox11)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox12)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.Label labelPuertoSerie;
        private System.Windows.Forms.Label labelFoco;
        private System.Windows.Forms.Label labelVentilador;
        private System.Windows.Forms.Button BtnEncender1;
        private System.Windows.Forms.Button BtnApagar1;
        private System.Windows.Forms.Button BtnEncender2;
        private System.Windows.Forms.Button BtnApagar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label labelEstadoAct;
        private System.Windows.Forms.Label labelAspersor;
        private System.Windows.Forms.Label labelPuerta;
        private System.Windows.Forms.Button BtnEncender3;
        private System.Windows.Forms.Button BtnApagar3;
        private System.Windows.Forms.Button BtnEncender4;
        private System.Windows.Forms.Button BtnApagar4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Panel panelActuadores;
        private System.Windows.Forms.Button buttonAuto;
        private System.Windows.Forms.Button buttonManual;
        private System.Windows.Forms.Label lblLuz1;
        private System.Windows.Forms.Label lblLuz2;
        private System.Windows.Forms.ProgressBar progressBarHumedad;
        private System.Windows.Forms.Label lblHumedad;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.PictureBox pictureBox10;
        private System.Windows.Forms.PictureBox pictureBox11;
        private System.Windows.Forms.PictureBox pictureBox12;
    }
}

