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

namespace FISCLINGEST.Módulos.Interfaces_Pacientes.Lista_de_Espera
{
    public partial class Agregar_ListEspera : Form
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
        public Agregar_ListEspera()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Agregar_ListEspera_Load;
        }

        private void btn_CerrarAgregarList_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void barra_AgregarListEspera_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void txt_telefonoPaciente_TextChanged(object sender, EventArgs e)
        {

        }

        private void Agregar_ListEspera_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de agregar
            btn_ValidarAgregarListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarAgregarListEspera.Width, btn_ValidarAgregarListEspera.Height, 15, 15));

            //Redondear textbox del nombre
            txt_NomListEspera.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_NomListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_NomListEspera.Width, txt_NomListEspera.Height, 10, 10));

            //Redondear textbox del teléfono
            txt_Tel_ListEspera.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_Tel_ListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_Tel_ListEspera.Width, txt_Tel_ListEspera.Height, 10, 10));

            //Redondear textbox del correo
            txt_TelRef_ListEspera.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_TelRef_ListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_TelRef_ListEspera.Width, txt_TelRef_ListEspera.Height, 10, 10));

            //redondear combobox del turno
            cbx_turnoListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_turnoListEspera.Width, cbx_turnoListEspera.Height, 10, 10));
        }
    }
}
