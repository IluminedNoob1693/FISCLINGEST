using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SQLite;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FISCLINGEST
{
    public partial class Menu_Principal : Form  
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
        public Menu_Principal()
        {
            InitializeComponent();
        }

        //Para contraer el panel lateral
        private void btn_Contraer_Click(object sender, EventArgs e)
        {
            if (Menu_Vertical.Width == 250)
            {
                Menu_Vertical.Width = 53;
            }
            else
                Menu_Vertical.Width = 250;
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void Barra_Título_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Para poder abrir otras ventanas dentro de la principal
        public void AbrirFormEnPanel(object Formhijo)
        {
            if (this.Panel_contenedor.Controls.Count > 0)
                this.Panel_contenedor.Controls.RemoveAt(0);
            Form fh = Formhijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.Panel_contenedor.Controls.Add(fh);
            this.Panel_contenedor.Tag = fh;
            fh.Show();
        }

        private void btn_Pacientes_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Pacientes(this));
        }

        private void btn_Citas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Citas());
        }

        private void btn_Cuotas_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Cuotas());
        }

        private void Usuarios_Click(object sender, EventArgs e)
        {
            AbrirFormEnPanel(new Administracion(this));
        }

        //Botones para cerrar, minimizar, y restaurar o maximizar el programa
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btn_restaurar.Visible = true;
            btn_Maximizar.Visible = false;

        }

        private void btn_restaurar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btn_restaurar.Visible = false;
            btn_Maximizar.Visible = true;

        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_CerrarSesion_Click(object sender, EventArgs e)
        {
            this.Close();
            Form lg = new Form();
            lg = new Módulos.loguin();
            lg.Show();
        }

        private void Menu_Principal_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón Cerrar Sesión
            btn_CerrarSesion.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_CerrarSesion.Width, btn_CerrarSesion.Height, 15, 15));
        }
    }
}
