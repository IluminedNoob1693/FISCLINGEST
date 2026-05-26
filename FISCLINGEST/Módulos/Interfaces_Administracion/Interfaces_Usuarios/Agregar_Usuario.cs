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

namespace FISCLINGEST.Módulos.Interfaces_Usuarios
{
    public partial class Agregar_Usuario : Form
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
        public Agregar_Usuario(int tituloUsuario)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Agregar_Usuario_Load;

            //Cambiar título del formulario y visibilidad de etiquetas según el valor de tituloUsuario
            if (tituloUsuario == 1)
            {
                lbl_AgregarUsuario.Visible = true;  // Mostrar primera
                lbl_EditarUsuario.Visible = false; // Ocultar segunda
            }
            else
            {
                lbl_AgregarUsuario.Visible = false; // Ocultar primera
                lbl_EditarUsuario.Visible = true;  // Mostrar segunda
            }
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloAgregarUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void pbx_CerrarAgregarUsuario_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ValidarUsuarioNuevo_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Usuario_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón para registrar nuevo usuario
            btn_ValidarUsuarioNuevo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarUsuarioNuevo.Width, btn_ValidarUsuarioNuevo.Height, 15, 15));

            // Redondear TextBox Nombre Completo
            txt_NomCompletoUser.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_NomCompletoUser.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_NomCompletoUser.Width, txt_NomCompletoUser.Height, 10, 10));

            // Redondear TextBox usuario
            txt_Username.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_Username.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_Username.Width, txt_Username.Height, 10, 10));

            // Redondear TextBox Contraseña
            txt_Password.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_Password.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_Password.Width, txt_Password.Height, 10, 10));

            //Redondear combobox tipo de usuario
            cbx_User_Rol.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_User_Rol.Width, cbx_User_Rol.Height, 10, 10));
        }
    }
}
