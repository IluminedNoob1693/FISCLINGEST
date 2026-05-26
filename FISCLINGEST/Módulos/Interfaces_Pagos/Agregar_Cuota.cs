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

namespace FISCLINGEST.Módulos.Interfaces_Pagos
{
    public partial class Agregar_Cuota : Form
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
        public Agregar_Cuota(int tituloCuota)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Agregar_Cuota_Load;

         //Cambiar título del formulario y visibilidad de etiquetas según el valor de tituloCuota
            if (tituloCuota == 1)
            {
                lbl_AgregarCuota.Visible = true;  // Mostrar primera
                lbl_EditarCuota.Visible = false; // Ocultar segunda
            }
            else
            {
                lbl_AgregarCuota.Visible = false; // Ocultar primera
                lbl_EditarCuota.Visible = true;  // Mostrar segunda
            }
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloAgregarCuota_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Cerrar_AgregarPaciente_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ValidarPago_Click(object sender, EventArgs e)
        {

        }

        private void Agregar_Cuota_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de validar
            btn_ValidarPago.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarPago.Width, btn_ValidarPago.Height, 15, 15));

            //Redondear la fecha de pago
            dpt_FechaPago.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dpt_FechaPago.Width, dpt_FechaPago.Height, 15, 15));

            //Redondear txt importe
            txt_ImporteCuota.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_ImporteCuota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_ImporteCuota.Width, txt_ImporteCuota.Height, 15, 15));

            //Redondear txt folio paciente
            txt_FolioPaciente.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_FolioPaciente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_FolioPaciente.Width, txt_FolioPaciente.Height, 15, 15));

            //Redondear txt folio caja
            txt_FolioCaja.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_FolioCaja.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_FolioCaja.Width, txt_FolioCaja.Height, 15, 15));


        }
    }
}
