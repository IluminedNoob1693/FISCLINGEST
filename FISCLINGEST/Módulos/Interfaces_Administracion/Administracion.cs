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

namespace FISCLINGEST
{
    public partial class Administracion : Form
    {
        private Menu_Principal _menuPrincipal;
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,     // X-coordenada esquina superior izquierda
            int nTopRect,      // Y-coordenada esquina superior izquierda
            int nRightRect,    // X-coordenada esquina inferior derecha
            int nBottomRect,   // Y-coordenada esquina inferior derecha
            int nWidthEllipse, // ancho de la elipse
            int nHeightEllipse // alto de la elipse
        );
        public Administracion(Menu_Principal menuPrincipal)
        {
            InitializeComponent();
            _menuPrincipal = menuPrincipal;
        }
        public Administracion(){}
        private void btn_GestionUsuarios_Click(object sender, EventArgs e)
        {
            _menuPrincipal.AbrirFormEnPanel(new Módulos.Interfaces_Administracion.Interfaces_Usuarios.Usuarios());
            
        }

        private void btn_ExportarReportes_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form er = new Form();
            er = new Módulos.Interfaces_Administracion.Exportar_Reportes();
            er.Show();
            
        }

        private void btn_Respaldos_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form rbd = new Form();
            rbd = new Módulos.Interfaces_Administracion.RespaldosBD();
            rbd.Show();
        }

        private void Administracion_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de gestión de usuarios
            btn_GestionUsuarios.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_GestionUsuarios.Width, btn_GestionUsuarios.Height, 15, 15));

            //Redondear el botón de exportar reportes
            btn_ExportarReportes.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ExportarReportes.Width, btn_ExportarReportes.Height, 15, 15));

            //Redondear el botón de respaldos
            btn_Respaldos.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Respaldos.Width, btn_Respaldos.Height, 15, 15));
        }
    }
}
