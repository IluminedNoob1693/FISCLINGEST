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
    public partial class Consultar_Cuotas : Form
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
        public Consultar_Cuotas()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Consultar_Cuotas_Load;
        }

        private void btn_CerrarConsultarCuotas_Click (object sender, EventArgs e)
        {
            this.Close();
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloConsultarCuota_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_ConsultarCuotas_Click(object sender, EventArgs e)
        {

        }

        private void Consultar_Cuotas_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de consultar
            btn_ConsultarCuotas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ConsultarCuotas.Width, btn_ConsultarCuotas.Height, 15, 15));

            //Redondear fecha de inicio busqueda
            cbx_MesHistorialCuotas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_MesHistorialCuotas.Width, cbx_MesHistorialCuotas.Height, 15, 15));

            //Redondear año de busqueda
            txt_AñoHistorialCuotas.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_AñoHistorialCuotas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_AñoHistorialCuotas.Width, txt_AñoHistorialCuotas.Height, 15, 15));

            //Redondear estado de la cuota
            cbx_EstadoPago.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_EstadoPago.Width, cbx_EstadoPago.Height, 15, 15));
        }
    }
}
