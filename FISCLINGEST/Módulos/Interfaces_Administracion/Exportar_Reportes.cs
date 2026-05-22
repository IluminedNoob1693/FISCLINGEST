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

namespace FISCLINGEST.Módulos.Interfaces_Administracion
{
    public partial class Exportar_Reportes : Form
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
        public Exportar_Reportes()
        {
            InitializeComponent();
        }
        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloExportarReporte_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btn_Ruta_Archivo_Click(object sender, EventArgs e)
        {

        }

        private void btn_Cerrar_ExportarReportes_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_ExportarReporte_Click(object sender, EventArgs e)
        {

        }

        private void Exportar_Reportes_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón para seleccionar ruta de archivo
            btn_Ruta_Archivo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Ruta_Archivo.Width, btn_Ruta_Archivo.Height, 15, 15));

            // Redondear Botón para exportar reporte
            btn_ExportarReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ExportarReporte.Width, btn_ExportarReporte.Height, 15, 15));

            //redondear combobox del tipo de periodo
            cbx_Tipo_Periodo.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_Tipo_Periodo.Width, cbx_Tipo_Periodo .Height, 10, 10));

            //redondear combobox del formato
            cbx_Formato.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_Formato.Width, cbx_Formato.Height, 10, 10));

            //redondear textbox de año
            txt_AñoReporte.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_AñoReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_AñoReporte.Width, txt_AñoReporte   .Height, 10, 10));

            //redondear combobox del mes
            cbx_MesReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_MesReporte.Width, cbx_MesReporte.Height, 10, 10));

            //redondear txt de semana
           txt_SemanaReporte.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
           txt_SemanaReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_SemanaReporte.Width, txt_SemanaReporte.Height, 10, 10));

            //redondear dtp de fecha inicio
            dtp_FechaReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaReporte.Width, dtp_FechaReporte.Height, 10, 10));

            //redondear txt de autor del reporte
            txt_AutorReporte.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_AutorReporte.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_AutorReporte.Width, txt_AutorReporte.Height, 10, 10));


        }
    }
}
