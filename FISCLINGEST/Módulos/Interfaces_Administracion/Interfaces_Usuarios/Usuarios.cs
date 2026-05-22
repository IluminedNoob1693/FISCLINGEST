using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FISCLINGEST.Módulos.Interfaces_Administracion.Interfaces_Usuarios
{
    public partial class Usuarios : Form
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
        public Usuarios()
        {
            InitializeComponent();
        }

        private void btn_AgregarUsuario_Click(object sender, EventArgs e)
        {
            Form AgregarUsuario = new Módulos.Interfaces_Usuarios.Agregar_Usuario();
            AgregarUsuario.ShowDialog();
        }

        private void btn_EditarUsuario_Click(object sender, EventArgs e)
        {

        }
        private void btn_DesactivarUsuario_Click(object sender, EventArgs e)
        {

        }

        private void Usuarios_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de agregar usuario
            btn_AgregarUsuario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgregarUsuario.Width, btn_AgregarUsuario.Height, 15, 15));

            //Redondear el botón de editar usuario
            btn_EditarUsuario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EditarUsuario.Width, btn_EditarUsuario.Height, 15, 15));

            //Redondear el botón de desactivar usuario
            btn_DesactivarUsuario.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_DesactivarUsuario.Width, btn_DesactivarUsuario.Height, 15, 15));
        }
    }
}
