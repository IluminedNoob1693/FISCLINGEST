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

namespace FISCLINGEST
{
    public partial class Menu_Principal : Form  
    {
        public Menu_Principal()
        {
            InitializeComponent();
        }

        //Para contraer el panel lateral
        private void btn_Menu_Click(object sender, EventArgs e)
        {
            if (Menu_Vertical.Width == 250)
            {
                Menu_Vertical.Width = 70;
            }
            else
                Menu_Vertical.Width = 250;
        }
        //Botones para cerrar, minimizar, y restaurar o maximizar el programa
        private void btn_Cerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_minimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_Maximizar_Click(object sender, EventArgs e)
        {
            
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
        private void AbrirFormEnPanel(object Formhijo)
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
            AbrirFormEnPanel(new Pacientes());
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
            AbrirFormEnPanel(new Usuarios());
        }
    }
}
