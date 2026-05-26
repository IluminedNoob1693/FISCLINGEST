using FISCLINGEST.Módulos;
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

namespace FISCLINGEST
{
    public partial class Msg_Advertencia : UserControl
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
        public Msg_Advertencia()
        {
            InitializeComponent();
            panel_TituloAdvertencia.MouseDown += panel_TituloAdvertencia_MouseDown;
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Msg_Advertencia_Load;
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        // ---------------------------------------------------------

        public string TituloAdvertencia
        {
            get { return lbl_TituloAdvertencia.Text; }
            set { lbl_TituloAdvertencia.Text = value; }
        }

        public string DescripcionAdvertencia
        {
            get { return lbl_AdvertenciaText.Text; }
            set { lbl_AdvertenciaText.Text = value; }
        }

        private void btn_CerrarAdvertencizClick(object sender, EventArgs e)
        {
            // Remueve este control de su padre (el panel)
            if (this.Parent != null)
            {
                this.ParentForm?.Close(); // Cierra el formulario que contiene este control
            }
        }

        private void panel_TituloAdvertencia_MouseDown(object sender, MouseEventArgs e)
        {

            if (e.Button == MouseButtons.Left)
            {
                // 1. Liberar la captura del mouse del control
                ReleaseCapture();

                // 2. Enviar el mensaje al formulario padre (ParentForm)
                // Usamos FindForm() por si el control está anidado en otro panel
                SendMessage(this.FindForm().Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void btn_CancelarAdvertencia_Click(object sender, EventArgs e)
        {
            /*Form FrmDestino = this.FindForm();
            FrmDestino.Hide();
            Form Msg_Error = new Msg_Error();
            Msg_Error.StartPosition = FormStartPosition.CenterScreen;
            Msg_Error.ShowDialog(FrmDestino);
            FrmDestino.Close();*/
        }

        private void btn_ConfirmarAdvertencia_Click(object sender, EventArgs e)
        {
            /*Form FrmDestino = this.FindForm();
            FrmDestino.Hide();
            Form Msg_Exito = new MensajeExito();
            Msg_Exito.StartPosition = FormStartPosition.CenterScreen;
            Msg_Exito.ShowDialog(FrmDestino);
            FrmDestino.Close();*/
        }

        private void Msg_Advertencia_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            btn_CancelarAdvertencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_CancelarAdvertencia.Width, btn_CancelarAdvertencia.Height, 20, 20));
            btn_ConfirmarAdvertencia.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ConfirmarAdvertencia.Width, btn_ConfirmarAdvertencia.Height, 20, 20));
            btn_CancelarAdvertencia.FlatAppearance.BorderSize = 0;
        }
    }
}
