using FISCLINGEST.Módulos.Interfaces_Pagos;
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
    public partial class Cuotas : Form
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
        public Cuotas()
        {
            InitializeComponent();
        }

        private void btn_AgregarCuota_Click(object sender, EventArgs e)
        {
            Form agregarCuota = new Agregar_Cuota(1);
            agregarCuota.ShowDialog();
        }

        private void btn_EditarCuota_Click(object sender, EventArgs e)
        {
            Form editarCuota = new Agregar_Cuota(2);
            editarCuota.ShowDialog();
        }

        private void btn_AnularCuota_Click(object sender, EventArgs e)
        {

        }

        private void btn_ExportarReporteCuotas_Click(object sender, EventArgs e)
        {
            Form ExportarCuotas = new Módulos.Interfaces_Administracion.Exportar_Reportes();
            ExportarCuotas.ShowDialog();
        }

        private void btn_ConsultarCuota_Click(object sender, EventArgs e)
        {
            Form consultarCuotas = new Consultar_Cuotas();
            consultarCuotas.ShowDialog();
        }

        private void Cuotas_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de agregar cuota
            btn_AgregarCuota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgregarCuota.Width, btn_AgregarCuota.Height, 15, 15));
            
            //Redondear el botón de editar cuota
            btn_EditarCuota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EditarCuota.Width, btn_EditarCuota.Height, 15, 15));
            
            //Redondear el botón de anular cuota
            btn_AnularCuota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AnularCuota.Width, btn_AnularCuota.Height, 15, 15));
            
            //Redondear el botón de exportar reporte de cuotas
            btn_ExportarReporteCuotas.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ExportarReporteCuotas.Width, btn_ExportarReporteCuotas.Height, 15, 15));
                
            //Redondear el botón de consultar cuota
            btn_ConsultarCuota.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ConsultarCuota.Width, btn_ConsultarCuota.Height, 10, 10));
        }
    }
}
