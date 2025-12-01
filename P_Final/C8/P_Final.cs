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
using System.Threading;
using System.Security.Cryptography;
using System.Drawing.Drawing2D;

namespace C8
{
    public partial class Form1 : Form
    {
        private bool modoAutomaticoActivo = false; // Bandera para el modo automático
        private CancellationTokenSource cts;       // Token para cancelar la tarea asíncrona
        private bool hayAgua = true; // comprobamos que hay agua



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

        // FUNCIÓN DE EVENTO PARA CONECTAR AL PUERTO SERIE SELECCIONADO
        private void BtnConectar_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre del puerto seleccionado en el ComboBox (CBPuertos).
            string sNombrePuerto = CBPuertos.SelectedItem?.ToString();

            // Verifica si no se seleccionó ningún puerto.
            if (string.IsNullOrEmpty(sNombrePuerto))
            {
                // Muestra un mensaje indicando que se debe seleccionar un puerto antes de conectar.
                MessageBox.Show("Por favor, selecciona un puerto antes de intentar conectar.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return; // Sale de la función porque no se puede proceder sin un puerto seleccionado.
            }

            try
            {
                // Verifica si el puerto serie no está abierto.
                if (!PuertoSerie.IsOpen)
                {
                    // Configura el nombre del puerto y lo abre.
                    PuertoSerie.PortName = sNombrePuerto;
                    PuertoSerie.Open();

                    // Muestra un mensaje indicando que el puerto se conectó exitosamente.
                    MessageBox.Show("Puerto " + sNombrePuerto + " conectado.",
                                    "Éxito",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);

                    // Guarda el nombre del puerto conectado para futuras comparaciones.
                    sPuertoAnterior = sNombrePuerto;
                }
                else
                {
                    // Si el puerto ya está abierto, verifica si es el mismo que se intentó conectar.
                    if (sPuertoAnterior == sNombrePuerto)
                    {
                        // Muestra un mensaje indicando que el puerto ya está conectado.
                        MessageBox.Show("Puerto " + sNombrePuerto + " ya está conectado.",
                                        "Información",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Muestra un mensaje indicando que otro puerto está conectado y se debe desconectar primero.
                        MessageBox.Show("Puerto " + sPuertoAnterior + " está conectado, favor de desconectarlo primero.",
                                        "Atención",
                                        MessageBoxButtons.OK,
                                        MessageBoxIcon.Warning);
                    }
                }
            }
            catch (UnauthorizedAccessException)
            {
                // Captura errores de acceso no autorizado al puerto.
                MessageBox.Show("No se puede acceder al puerto " + sNombrePuerto + ". Verifica los permisos.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (System.IO.IOException)
            {
                // Captura errores relacionados con el puerto no disponible o inexistente.
                MessageBox.Show("El puerto " + sNombrePuerto + " no está disponible o no existe.",
                                "Error",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                // Captura cualquier otro tipo de error no especificado anteriormente.
                MessageBox.Show("Ocurrió un error al intentar conectar al puerto:\n" + ex.Message,
                                "Error inesperado",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
            }
        }


        //FUNCIÓN DE EVENTO PARA DESCONECTAR AL PUERTO SERIE SELECCIONADO
        private void BtnDesconectar_Click(object sender, EventArgs e)
        {
            // Obtiene el nombre del puerto seleccionado en el ComboBox
            string sNombrePuerto = CBPuertos.SelectedItem.ToString();

            // Verifica si el puerto seleccionado es el mismo que el último conectado
            if (sNombrePuerto == sPuertoAnterior)
            {
                // Si el puerto serie está abierto, lo cierra
                if (PuertoSerie.IsOpen)
                {
                    PuertoSerie.Close(); // Cierra la conexión al puerto serie
                    MessageBox.Show("Puerto " + sNombrePuerto + " desconectado."); // Muestra un mensaje indicando que se desconectó
                    sPuertoAnterior = null; // Resetea el registro del último puerto conectado
                }
                else
                {
                    // Si el puerto ya estaba cerrado, informa que ya está desconectado
                    MessageBox.Show("Puerto " + sPuertoAnterior + " desconectado.");
                }
            }
            else
            {
                // Si el puerto seleccionado no coincide con el último conectado, informa que no está conectado
                MessageBox.Show("Puerto " + sNombrePuerto + " no está conectado.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER El PANEL LED 1
        private void BtnEncender1_Click(object sender, EventArgs e)
        {
            string sComando1 = "2";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando1);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }
        //FUNCIÓN DE EVENTO PARA APAGAR EL PANEL LED 1
        private void BtnApagar1_Click(object sender, EventArgs e)
        {
            string sComando2 = "3";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando2);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER EL PANEL LED 2
        private void BtnEncender2_Click(object sender, EventArgs e)
        {
            string sComando3 = "4";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando3);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA APAGAR EL PANEL LED 2
        private void BtnApagar2_Click(object sender, EventArgs e)
        {
            string sComando4 = "5";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando4);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER LA BOMBA DE AGUA
        private void BtnEncender3_Click(object sender, EventArgs e)
        {
            // Verificar si hay agua antes de enviar el comando
            if (!hayAgua)
            {
                MessageBox.Show("Advertencia: No hay agua suficiente para activar este actuador.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; // Salir del evento sin enviar el comando
            }

            string sComando5 = "6"; // Comando para encender la bomba
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando5); // Enviar el comando al puerto serie
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //FUNCIÓN DE EVENTO PARA APAGAR LA BOMBA DE AGUA
        private void BtnApagar3_Click(object sender, EventArgs e)
        {
            string sComando6 = "7";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando6);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA ENCENDER EL BUZZER
        private void BtnEncender4_Click(object sender, EventArgs e)
        {
            string sComando7 = "8";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando7);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //FUNCIÓN DE EVENTO PARA CERRAR EL BUZZER
        private void BtnApagar4_Click(object sender, EventArgs e)
        {
            string sComando8 = "9";
            if (PuertoSerie.IsOpen)
            {
                PuertoSerie.WriteLine(sComando8);
            }
            else
            {
                MessageBox.Show("Por favor conectese a un puerto serie primero.");
            }
        }

        //ESTADOS DE ACTUADORES
        private void PuertoSerie_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
                string sRecibido = PuertoSerie.ReadLine().Trim();
                if (sRecibido.StartsWith("Luz1:"))
                {
                    // Extraer el valor después de "Luz1:"
                    string valorLuz1 = sRecibido.Substring(5).Trim().Replace("%", "");
                    // Actualizar la etiqueta en el hilo principal
                    this.Invoke(new Action(() =>
                    {
                        lblLuz1.Text = $"Luz1: {valorLuz1}%";
                    }));
                }
                if (sRecibido.StartsWith("Luz2:"))
                {
                    // Extraer el valor después de "Luz1:"
                    string valorLuz1 = sRecibido.Substring(5).Trim().Replace("%", "");
                    // Actualizar la etiqueta en el hilo principal
                    this.Invoke(new Action(() =>
                    {
                        lblLuz2.Text = $"Luz2: {valorLuz1}%";
                    }));
                }
                if (sRecibido.StartsWith("Humedad:"))
                {
                    // Extraer el valor después de "Humedad:"
                    string valorHumedad = sRecibido.Substring(9).Trim().Replace("%", ""); // Quitar el "%"

                    // Intentar convertir el valor a flotante
                    if (float.TryParse(valorHumedad, out float humedad))
                    {
                        // Actualizar la barra de progreso en el hilo principal
                        this.Invoke(new Action(() =>
                        {
                            // Convertir el valor flotante a entero para la barra de progreso
                            int progreso = (int)Math.Round(humedad);

                            progressBarHumedad.Value = Math.Min(Math.Max(progreso, progressBarHumedad.Minimum), progressBarHumedad.Maximum);
                            lblHumedad.Text = $"Humedad: {humedad:F1}%"; // Mostrar con un decimal
                        }));
                    }
                    else
                    {
                        // Manejar errores de conversión
                        this.Invoke(new Action(() =>
                        {
                            lblHumedad.Text = "Error al leer humedad";
                        }));
                    }
                }
                switch (sRecibido.Trim())
                {
                    case "LED 1 activado":
                        pictureBox1.Image = Properties.Resources.led_VERDE_ON;
                        break;
                    case "LED 1 desactivado":
                        pictureBox1.Image = Properties.Resources.led_green_off;
                        break;
                    case "LED 2 activado":
                        pictureBox2.Image = Properties.Resources.led_ROJO_on;
                        break;
                    case "LED 2 desactivado":
                        pictureBox2.Image = Properties.Resources.led_ROJO_off;
                        break;
                    case "Bomba activada":
                        pictureBox3.Image = Properties.Resources.led_VERDE_ON;
                        break;
                    case "Bomba desactivada":
                        pictureBox3.Image = Properties.Resources.led_green_off;
                        break;
                    case "Buzzer activado":
                        pictureBox4.Image = Properties.Resources.Sirena;
                        break;
                    case "Buzzer desactivado":
                        pictureBox4.Image = Properties.Resources.SirenaAp;
                        break;
                    case "Nivel de agua: Suficiente":
                        pictureBox5.Image = Properties.Resources.gotaAgua;
                        break;
                    case "Nivel de agua: Bajo":
                        pictureBox5.Image = Properties.Resources.noHayagua;
                        break;
                    case "Modo Automatico":
                        pictureBox11.Image = Properties.Resources.led_VERDE_ON;
                        break;
                    case "Modo Manual":
                        pictureBox11.Image = Properties.Resources.led_ROJO_on;
                        break;
                    default:
                        break;
                }
            }
        }

        //FUNCION DE BOTON MANUAL
        private void buttonManual_Click(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
                try
                {
                    // Enviar comando para activar el modo manual
                    PuertoSerie.Write("1");

                    // Habilitar los botones en el panel de actuadores (si es necesario)
                    foreach (Control control in panelActuadores.Controls)
                    {
                        if (control is System.Windows.Forms.Button)
                        {
                            control.Enabled = true;
                        }
                    }

                    // Restablecer los valores de los labels
                    lblHumedad.Text = "Humedad";
                    lblLuz1.Text = "Luz1";
                    lblLuz2.Text = "Luz2";

                    // Restablecer la barra de progreso
                    progressBarHumedad.Value = progressBarHumedad.Minimum;

                    // Vaciar la PictureBox
                    pictureBox5.Image = null;

                    // Mostrar confirmación
                    MessageBox.Show("Modo manual activo y valores reiniciados.");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el comando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El puerto no está conectado. Conéctalo antes de activar el modo manual.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }



        // Función de botón automático
        private async void buttonAuto_Click_1(object sender, EventArgs e)
        {
            if (PuertoSerie.IsOpen)
            {
                try
                {
                    // Enviar comando para activar el modo manual
                    PuertoSerie.Write("0");
                    foreach (Control control in panelActuadores.Controls)
                    {
                        if (control is System.Windows.Forms.Button)
                        {
                            control.Enabled = false;
                        }
                    }

                    MessageBox.Show("Modo automatico activo");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al enviar el comando: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("El puerto no está conectado. Conéctalo antes de activar el modo automatico.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelActuadores_Paint(object sender, PaintEventArgs e)
        {
            // Activar suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            int radius = 60; // Curvatura de las esquinas
            GraphicsPath path = new GraphicsPath();

            // Crear el rectángulo con esquinas redondeadas
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panelActuadores.Width - radius - 1, 0, radius, radius), -90, 90);
            path.AddArc(new Rectangle(panelActuadores.Width - radius - 1, panelActuadores.Height - radius - 1, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panelActuadores.Height - radius - 1, radius, radius), 90, 90);
            path.CloseFigure();

            // Asignar forma al panel
            panelActuadores.Region = new Region(path);

            // Borde exterior neón
            using (Pen neonOuter = new Pen(Color.FromArgb(0, 255, 150), 6))
            {
                e.Graphics.DrawPath(neonOuter, path);
            }

            // Borde interior neón
            using (Pen neonInner = new Pen(Color.Lime, 2))
            {
                Rectangle innerRect = new Rectangle(3, 3, panelActuadores.Width - 7, panelActuadores.Height - 7);
                GraphicsPath innerPath = RoundedRect(innerRect, radius - 6);
                e.Graphics.DrawPath(neonInner, innerPath);
            }
        }

        // Función para crear rectángulo redondeado reutilizable
        private GraphicsPath RoundedRect(Rectangle rect, int radius)
        {
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(rect.X, rect.Y, radius, radius, 180, 90);
            path.AddArc(rect.Right - radius, rect.Y, radius, radius, -90, 90);
            path.AddArc(rect.Right - radius, rect.Bottom - radius, radius, radius, 0, 90);
            path.AddArc(rect.X, rect.Bottom - radius, radius, radius, 90, 90);
            path.CloseFigure();
            return path;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            // Activar suavizado
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            Panel panel = (Panel)sender;
            int radius = 45; // Ajusta la curvatura si quieres

            // Crear path con esquinas redondeadas
            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(new Rectangle(0, 0, radius, radius), 180, 90);
            path.AddArc(new Rectangle(panel.Width - radius - 1, 0, radius, radius), -90, 90);
            path.AddArc(new Rectangle(panel.Width - radius - 1, panel.Height - radius - 1, radius, radius), 0, 90);
            path.AddArc(new Rectangle(0, panel.Height - radius - 1, radius, radius), 90, 90);
            path.CloseFigure();

            // Aplicar forma redondeada
            panel.Region = new Region(path);

            // Borde exterior neón
            using (Pen neonOuter = new Pen(Color.FromArgb(0, 255, 150), 6))
            {
                e.Graphics.DrawPath(neonOuter, path);
            }

            // Borde interior neón
            Rectangle innerRect = new Rectangle(4, 4, panel.Width - 9, panel.Height - 9);
            GraphicsPath innerPath = RoundedRect(innerRect, radius - 10);

            using (Pen neonInner = new Pen(Color.Lime, 2))
            {
                e.Graphics.DrawPath(neonInner, innerPath);
            }
        }
    }
}