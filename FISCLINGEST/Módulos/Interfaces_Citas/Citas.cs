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
    public partial class Citas : Form
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
        public Citas()
        {
            InitializeComponent();
        }

        private void btn_AgendarCita_Click(object sender, EventArgs e)
        {
            Form AgendarCita = new Módulos.Interfaces_Citas.Agendar_Cita();
            AgendarCita.ShowDialog();
        }

        private void btn_ReprogramarCita_Click(object sender, EventArgs e)
        {

        }

        private void btn_CancelarCita_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarCita_Click_1(object sender, EventArgs e)
        {
            Form ConsultarAgenda = new Módulos.Interfaces_Citas.Consultar_Agenda();
            ConsultarAgenda.ShowDialog();
        }

        private void btn_BloquearFecha_Click(object sender, EventArgs e)
        {

        }

        private void btn_DesbloquearFecha_Click(object sender, EventArgs e)
        {

        }

        private void Citas_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de agregar
            btn_AgendarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgendarCita.Width, btn_AgendarCita.Height, 15, 15));
            
            //Redondear el botón de reprogramar
            btn_ReprogramarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ReprogramarCita.Width, btn_ReprogramarCita.Height, 15, 15));
            
            //Redondear el botón de cancelar    
            btn_CancelarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_CancelarCita.Width, btn_CancelarCita.Height, 15, 15));
            
            //Redondear el botón de buscar cita
            btn_BuscarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_BuscarCita.Width, btn_BuscarCita.Height, 15, 15));
            
            //Redondear el botón de bloquear fecha   
            btn_BloquearFecha.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_BloquearFecha.Width, btn_BloquearFecha.Height, 15, 15));
            
            //Redondear el botón de desbloquear fecha
            btn_DesbloquearFecha.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_DesbloquearFecha.Width, btn_DesbloquearFecha.Height, 15, 15));
        }

        private void btn_ExportarAgenda_Click(object sender, EventArgs e)
        {
            Form ExportarAgenda = new Módulos.Interfaces_Administracion.Exportar_Reportes();
            ExportarAgenda.ShowDialog();
        }
    }
}
