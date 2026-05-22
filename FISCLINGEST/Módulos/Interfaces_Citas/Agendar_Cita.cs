using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FISCLINGEST.Módulos.Interfaces_Citas
{
    public partial class Agendar_Cita : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // X-coordenada esquina superior izquierda
            int nTopRect,      // Y-coordenada esquina superior izquierda
            int nRightRect,    // X-coordenada esquina inferior derecha
            int nBottomRect,   // Y-coordenada esquina inferior derecha
            int nWidthEllipse, // ancho de la elipse
            int nHeightEllipse // alto de la elipse
        );
        public Agendar_Cita()
        {
            InitializeComponent();
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                this.Load += Agendar_Cita_Load;
        }
             
        private void Cerrar_AgregarPaciente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_BusquedaPacienteCita_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_ValidarCita_Click(object sender, EventArgs e)
        {

        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloAgendarCita_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Agendar_Cita_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de validar
            btn_ValidarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarCita.Width, btn_ValidarCita.Height, 15, 15));

            //Redondear textbox del nombre
            txt_BusquedaPacienteCita.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_BusquedaPacienteCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_BusquedaPacienteCita.Width, txt_BusquedaPacienteCita.Height, 15, 15));

            // Redondear el DateTimePicker
            dtp_FechaCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaCita.Width, dtp_FechaCita.Height, 15, 15));

            // Redondear el ComboBox
            cbx_EstadoCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_EstadoCita.Width, cbx_EstadoCita.Height, 15, 15));

            // Redondear el ComboBox de hora
            cbx_TipoPaciente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_TipoPaciente.Width, cbx_TipoPaciente.Height, 15, 15));

            //Redondear el ComboBox de tipo de terapia
            cbx_TipoTerapia.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_TipoTerapia.Width, cbx_TipoTerapia.Height, 15, 15));
        }
    }
}
