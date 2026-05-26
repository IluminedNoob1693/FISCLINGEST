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
    public partial class msg_Exito : UserControl
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
        public msg_Exito()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            Load += msg_Exito_Load;
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private const int WM_NCLBUTTONDOWN = 0xA1;
        private const int HT_CAPTION = 0x2;
        // ---------------------------------------------------------

        public string TituloDialogoExito
        {
            get { return lbl_TituloDialogoExito.Text; }
            set { lbl_TituloDialogoExito.Text = value; }
        }

        public string DescripcionDialogoExito
        {
            get { return lbl_ExitoText.Text; }
            set { lbl_ExitoText.Text = value; }
        }

        private void panel_TituloExito_MouseDown(object sender, MouseEventArgs e)
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

        private void btn_MsgAceptar_Click(object sender, EventArgs e)
        {
            // Remueve este control de su padre (el panel)
            if (this.Parent != null)
            {
                this.ParentForm?.Close(); // Cierra el formulario que contiene este control
            }
        }

        private void msg_Exito_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
                btn_MsgAceptar.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_MsgAceptar.Width, btn_MsgAceptar.Height, 15, 15));
        }
    }
}
