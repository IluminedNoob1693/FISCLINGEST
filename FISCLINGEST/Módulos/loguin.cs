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

namespace FISCLINGEST.Módulos
{
    
    public partial class loguin : Form
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

        public loguin()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += loguin_Load;

        }

        private void btn_validarContraseña_Click(object sender, EventArgs e)
        {
            Form Menu_Principal = new Form();
            Menu_Principal = new Menu_Principal();
            Menu_Principal.Show();
            this.Hide();
        }

        private void btn_Cerrar_loguin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void Panel_Titulo_IniciarSesion_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void loguin_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón Iniciar Sesión
            btn_validarContraseña.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_validarContraseña.Width, btn_validarContraseña.Height, 15, 15));

            txt_Password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_Password.Width, txt_Password.Height, 10, 10));
            // Redondear TextBox Usuario
            txt_User.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_User.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_User.Width, txt_User .Height, 10, 10));

            // Redondear TextBox Contraseña
            txt_Password.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
        }
    }
}
