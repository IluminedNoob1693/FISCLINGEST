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
    public partial class Consultar_Agenda : Form
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
        public Consultar_Agenda()
        {
            InitializeComponent();
                this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
                this.Load += Consultar_Agenda_Load;
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloConsultarCita_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbx_CerrarConsultaCita_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ConsultarCitas_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Agenda_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes

            //Redondear el botón de consultar
            btn_ConsultarCitas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ConsultarCitas.Width, btn_ConsultarCitas.Height, 15, 15));

            //Redondear fecha de inicio busqueda
            dtp_FechaHora_Entrada.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaHora_Entrada.Width, dtp_FechaHora_Entrada.Height, 15, 15));

            //Redondear fecha de fin busqueda
            dtp_FechaHora_Salida.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaHora_Salida.Width, dtp_FechaHora_Salida.Height, 15, 15));

            //Redondear estado de la cita
            cbx_ConsultarEstadoCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_ConsultarEstadoCita.Width, cbx_ConsultarEstadoCita.Height, 15, 15));
        }
    }
}
