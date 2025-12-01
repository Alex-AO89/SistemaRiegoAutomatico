using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace C8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string sPuertoAnterior = null;

        //FUNCIÓN DE EVENTO PARA OBTENER OBTENER LOS PUERTOS DISPONIBLES
        private void Form1_Load(object sender, EventArgs e)
        {
            string[] sPuertos = System.IO.Ports.SerialPort.GetPortNames();
            CBPuertos.DataSource = sPuertos;
            CheckForIllegalCrossThreadCalls = false;
        }

        //FUNCIÓN DE EVENTO PARA CONECTAR AL PUERTO SERIE SELECCIONADO
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            string sNombrePuerto = CBPuertos.SelectedItem.ToString();

            if (!PuertoSerie.IsOpen)
            {
                PuertoSerie.PortName = sNombrePuerto;
                PuertoSerie.Open();
                MessageBox.Show("Puerto " + sNombrePuerto + " conectado.");
                sPuertoAnterior = sNombrePuerto;
            }
            else
            {
                if (sPuertoAnterior == sNombrePuerto)
                {
                    MessageBox.Show("Puerto " + sNombrePuerto + " ya está conectado");
                }
                else
                {
                    MessageBox.Show("Puerto " + sPuertoAnterior + " está conectado, favor de desconectarlo primero");
                }
            }
        }

        //FUNCIÓN DE EVENTO PARA DESCONECTAR AL PUERTO SERIE SELECCIONADO
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            string sNombrePuerto = CBPuertos.SelectedItem.ToString();

            if (sNombrePuerto == sPuertoAnterior)
            {
                if (PuertoSerie.IsOpen)
                {
                    PuertoSerie.Close();
                    MessageBox.Show("Puerto " + sNombrePuerto + " desconectado.");
                    sPuertoAnterior = null;
                }
                else
                {
                    MessageBox.Show("Puerto " + sPuertoAnterior + " desconectado.");
                }
            }
            else
            {
                MessageBox.Show("Puerto " + sNombrePuerto + " no está conectado.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER EL LED1
        private void BtnEncender1_Click(object sender, EventArgs e)
        {
            string sComando1 = "1";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando1);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA APAGAR EL LED1
        private void BtnApagar1_Click(object sender, EventArgs e)
        {
            string sComando2 = "2";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando2);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER EL LED2
        private void BtnEncender2_Click(object sender, EventArgs e)
        {
            string sComando3 = "3";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando3);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA APAGAR EL LED2
        private void BtnApagar2_Click(object sender, EventArgs e)
        {
            string sComando4 = "4";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando4);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if(PuertoSerie.IsOpen)
            {
                string sRecibido = PuertoSerie.ReadLine();
                switch (sRecibido.Trim())
                {
                    case "LED1 Encendido": 
                        pictureBox1.Image = Properties.Resources.led_VERDE_ON;
                        break;

                    case "LED1 Apagado": 
                        pictureBox1.Image = Properties.Resources.led_green_off; 
                        break;

                    case "LED2 Encendido": 
                        pictureBox2.Image = Properties.Resources.led_ROJO_on;
                        break;

                    case "LED2 Apagado": 
                        pictureBox2.Image = Properties.Resources.led_ROJO_off;
                        break;

                    default:
                        MessageBox.Show("Comando no reconocido" + sRecibido);
                        break;
                }
            }
        }
    }
}