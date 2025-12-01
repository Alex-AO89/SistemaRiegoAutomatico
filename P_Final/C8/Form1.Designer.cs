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
            this.CBPuertos = new System.Windows.Forms.ComboBox();
            this.BtnConectar = new System.Windows.Forms.Button();
            this.PuertoSerie = new System.IO.Ports.SerialPort(this.components);
            this.BtnDesconectar = new System.Windows.Forms.Button();
            this.labelLED1 = new System.Windows.Forms.Label();
            this.labelLED2 = new System.Windows.Forms.Label();
            this.BtnEncender1 = new System.Windows.Forms.Button();
            this.BtnApagar1 = new System.Windows.Forms.Button();
            this.BtnEncender2 = new System.Windows.Forms.Button();
            this.BtnApagar2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // CBPuertos
            // 
            this.CBPuertos.BackColor = System.Drawing.Color.LightBlue;
            this.CBPuertos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBPuertos.ForeColor = System.Drawing.Color.Black;
            this.CBPuertos.FormattingEnabled = true;
            this.CBPuertos.Location = new System.Drawing.Point(169, 63);
            this.CBPuertos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.CBPuertos.Name = "CBPuertos";
            this.CBPuertos.Size = new System.Drawing.Size(121, 24);
            this.CBPuertos.TabIndex = 0;
            // 
            // BtnConectar
            // 
            this.BtnConectar.BackColor = System.Drawing.Color.Black;
            this.BtnConectar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnConectar.ForeColor = System.Drawing.Color.White;
            this.BtnConectar.Location = new System.Drawing.Point(315, 54);
            this.BtnConectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnConectar.Name = "BtnConectar";
            this.BtnConectar.Size = new System.Drawing.Size(118, 40);
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
            this.BtnDesconectar.Location = new System.Drawing.Point(436, 54);
            this.BtnDesconectar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnDesconectar.Name = "BtnDesconectar";
            this.BtnDesconectar.Size = new System.Drawing.Size(118, 40);
            this.BtnDesconectar.TabIndex = 2;
            this.BtnDesconectar.Text = "Desconectar";
            this.BtnDesconectar.UseVisualStyleBackColor = false;
            this.BtnDesconectar.Click += new System.EventHandler(this.BtnDesconectar_Click);
            // 
            // labelLED1
            // 
            this.labelLED1.AutoSize = true;
            this.labelLED1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLED1.Location = new System.Drawing.Point(153, 156);
            this.labelLED1.Name = "labelLED1";
            this.labelLED1.Size = new System.Drawing.Size(44, 16);
            this.labelLED1.TabIndex = 3;
            this.labelLED1.Text = "LED1";
            // 
            // labelLED2
            // 
            this.labelLED2.AutoSize = true;
            this.labelLED2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLED2.Location = new System.Drawing.Point(474, 156);
            this.labelLED2.Name = "labelLED2";
            this.labelLED2.Size = new System.Drawing.Size(44, 16);
            this.labelLED2.TabIndex = 4;
            this.labelLED2.Text = "LED2";
            // 
            // BtnEncender1
            // 
            this.BtnEncender1.BackColor = System.Drawing.Color.Black;
            this.BtnEncender1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender1.ForeColor = System.Drawing.Color.White;
            this.BtnEncender1.Location = new System.Drawing.Point(52, 303);
            this.BtnEncender1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEncender1.Name = "BtnEncender1";
            this.BtnEncender1.Size = new System.Drawing.Size(118, 40);
            this.BtnEncender1.TabIndex = 5;
            this.BtnEncender1.Text = "Encender";
            this.BtnEncender1.UseVisualStyleBackColor = false;
            this.BtnEncender1.Click += new System.EventHandler(this.BtnEncender1_Click);
            // 
            // BtnApagar1
            // 
            this.BtnApagar1.BackColor = System.Drawing.Color.Black;
            this.BtnApagar1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar1.ForeColor = System.Drawing.Color.White;
            this.BtnApagar1.Location = new System.Drawing.Point(177, 303);
            this.BtnApagar1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnApagar1.Name = "BtnApagar1";
            this.BtnApagar1.Size = new System.Drawing.Size(118, 40);
            this.BtnApagar1.TabIndex = 6;
            this.BtnApagar1.Text = "Apagar";
            this.BtnApagar1.UseVisualStyleBackColor = false;
            this.BtnApagar1.Click += new System.EventHandler(this.BtnApagar1_Click);
            // 
            // BtnEncender2
            // 
            this.BtnEncender2.BackColor = System.Drawing.Color.Black;
            this.BtnEncender2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnEncender2.ForeColor = System.Drawing.Color.White;
            this.BtnEncender2.Location = new System.Drawing.Point(376, 303);
            this.BtnEncender2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnEncender2.Name = "BtnEncender2";
            this.BtnEncender2.Size = new System.Drawing.Size(118, 40);
            this.BtnEncender2.TabIndex = 7;
            this.BtnEncender2.Text = "Encender";
            this.BtnEncender2.UseVisualStyleBackColor = false;
            this.BtnEncender2.Click += new System.EventHandler(this.BtnEncender2_Click);
            // 
            // BtnApagar2
            // 
            this.BtnApagar2.BackColor = System.Drawing.Color.Black;
            this.BtnApagar2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnApagar2.ForeColor = System.Drawing.Color.White;
            this.BtnApagar2.Location = new System.Drawing.Point(500, 303);
            this.BtnApagar2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnApagar2.Name = "BtnApagar2";
            this.BtnApagar2.Size = new System.Drawing.Size(118, 40);
            this.BtnApagar2.TabIndex = 8;
            this.BtnApagar2.Text = "Apagar";
            this.BtnApagar2.UseVisualStyleBackColor = false;
            this.BtnApagar2.Click += new System.EventHandler(this.BtnApagar2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::C8.Properties.Resources.led_green_off;
            this.pictureBox1.Location = new System.Drawing.Point(121, 190);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::C8.Properties.Resources.led_ROJO_off;
            this.pictureBox2.Location = new System.Drawing.Point(443, 190);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 110);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 25);
            this.label1.TabIndex = 12;
            this.label1.Text = "Estado actual del LED";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(260, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 25);
            this.label2.TabIndex = 14;
            this.label2.Text = "Puerto Serie";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(659, 354);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.BtnApagar2);
            this.Controls.Add(this.BtnEncender2);
            this.Controls.Add(this.BtnApagar1);
            this.Controls.Add(this.BtnEncender1);
            this.Controls.Add(this.labelLED2);
            this.Controls.Add(this.labelLED1);
            this.Controls.Add(this.BtnDesconectar);
            this.Controls.Add(this.BtnConectar);
            this.Controls.Add(this.CBPuertos);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox CBPuertos;
        private System.Windows.Forms.Button BtnConectar;
        private System.IO.Ports.SerialPort PuertoSerie;
        private System.Windows.Forms.Button BtnDesconectar;
        private System.Windows.Forms.Label labelLED1;
        private System.Windows.Forms.Label labelLED2;
        private System.Windows.Forms.Button BtnEncender1;
        private System.Windows.Forms.Button BtnApagar1;
        private System.Windows.Forms.Button BtnEncender2;
        private System.Windows.Forms.Button BtnApagar2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

