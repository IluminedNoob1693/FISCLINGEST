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

namespace FISCLINGEST.Módulos.Interfaces_Administracion
{
    public partial class RespaldosBD : Form
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
        public RespaldosBD()
        {
            InitializeComponent();
            this.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, this.Width, this.Height, 20, 20));
            this.Load += RespaldosBD_Load; // Asegura que el evento Load esté suscrito
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_Titulo_GenerarRespaldoBD_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbx_CerrarRespaldoBD_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_Ruta_RespaldoBD_Click(object sender, EventArgs e)
        {

        }

        private void btn_GenerarRespaldoBD_Click(object sender, EventArgs e)
        {

        }

        private void RespaldosBD_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón para seleccionar ruta de respaldo
            btn_Ruta_RespaldoBD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Ruta_RespaldoBD.Width, btn_Ruta_RespaldoBD.Height, 15, 15));

            // Redondear Botón para generar respaldo
            btn_GenerarRespaldoBD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_GenerarRespaldoBD.Width, btn_GenerarRespaldoBD.Height, 15, 15));

            //Redondear fechador para seleccionar fecha de respaldo
            dtp_FechaHora_Respaldo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaHora_Respaldo.Width, dtp_FechaHora_Respaldo.Height, 10, 10));

            //Redondear txt para mostrar autor del respaldo
            txt_AutorRespaldoBD.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_AutorRespaldoBD.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_AutorRespaldoBD.Width, txt_AutorRespaldoBD.Height, 10, 10));
        }
    }
}
