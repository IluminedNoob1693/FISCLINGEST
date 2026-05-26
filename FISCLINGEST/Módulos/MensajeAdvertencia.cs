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

namespace FISCLINGEST.Módulos.Interfaces_Pacientes
{
    public partial class MensajeAdvertencia : Form
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
        public MensajeAdvertencia()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += MensajeAdvertencia_Load;
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void btn_CerrarAdvertencia_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void panel_TituloAdvertencia_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_CancelarAdvertencia_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Msg_Error = new Mensaje_Error();
            Msg_Error.ShowDialog();
        }
        private void btn_ConfirmarAdvertencia_Click(object sender, EventArgs e)
        {
            this.Close();
            Form Msg_Exito = new MensajeExito();
            Msg_Exito.ShowDialog();
        }

        private void MensajeAdvertencia_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón para confirmar eliminación
            btn_ConfirmarAdvertencia.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ConfirmarAdvertencia.Width, btn_ConfirmarAdvertencia.Height, 15, 15));

            // Redondear Botón para cancelar eliminación
            btn_CancelarAdvertencia.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_CancelarAdvertencia.Width, btn_CancelarAdvertencia.Height, 15, 15));
        }
    }
}
