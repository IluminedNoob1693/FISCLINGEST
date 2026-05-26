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

namespace FISCLINGEST.Módulos.Interfaces_Pacientes
{
    public partial class Agregar_Paciente : Form
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
        public Agregar_Paciente(int tituloPaciente)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Agregar_Paciente_Load;

            //Cambiar título del formulario y visibilidad de etiquetas según el valor de tituloPaciente
            if (tituloPaciente == 1)
            {
                lbl_AgregarPaciente.Visible = true;  // Mostrar primera
                lbl_EditarPaciente.Visible = false; // Ocultar segunda
            }
            else
            {
                lbl_AgregarPaciente.Visible = false; // Ocultar primera
                lbl_EditarPaciente.Visible = true;  // Mostrar segunda
            }
        }

        public Agregar_Paciente()
        {

        }

        private void btn_ValidarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_AgregarHistorial_Click(object sender, EventArgs e)
        {

        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloAgregarPac_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Cerrar_AgregarPaciente_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Agregar_Paciente_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón Agregar Historial
            btn_AgregarHistorial.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgregarHistorial.Width, btn_AgregarHistorial.Height, 15, 15));

            // Redondear Botón Validar Paciente
            btn_ValidarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarPaciente.Width, btn_ValidarPaciente.Height, 15, 15));

            // Redondear TextBox Nombre Paciente
            txt_NombrePaciente.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_NombrePaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_NombrePaciente.Width, txt_NombrePaciente.Height, 10, 10));

            // Redondear TextBox telefono
            txt_telefonoPaciente.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_telefonoPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_telefonoPaciente.Width, txt_telefonoPaciente.Height, 10, 10));

            // Redondear TextBox folio
            txt_Folio.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_Folio.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_Folio.Width, txt_Folio.Height, 10, 10));


            // Redondear TextBox telefono de contacto
            txt_ContactoPaciente.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_ContactoPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ContactoPaciente.Width, txt_ContactoPaciente.Height, 10, 10));
            
            // Redondear ComboBox tipo de paciente
            cbx_TipoPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_TipoPaciente.Width, cbx_TipoPaciente.Height, 10, 10));
        }
    }
}
