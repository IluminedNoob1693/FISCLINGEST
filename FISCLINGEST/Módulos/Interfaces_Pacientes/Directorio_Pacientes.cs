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
    public partial class Directorio_Pacientes : Form
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
        public Directorio_Pacientes(Agregar_Paciente agregar_Paciente)
        {
            InitializeComponent();
        }

        private void btn_AgregarPaciente_Click(object sender, EventArgs e)
        {
            Form AgregarPaciente = new Agregar_Paciente(1);
            AgregarPaciente.ShowDialog();
        }

        private void btn_EditarPaciente_Click(object sender, EventArgs e)
        {
          Form EditarPaciente = new Agregar_Paciente(2);
            EditarPaciente.ShowDialog();
            
        }

        private void btn_EliminarPaciente_Click(object sender, EventArgs e)
        {
            /*Form EliminarPaciente = new Msg_Advertencia();
            ((Msg_Advertencia)EliminarPaciente).TituloAdvertencia = "Eliminar Paciente";
            ((Msg_Advertencia)EliminarPaciente).MensajeAdvertencia = "¿Está seguro de que desea eliminar este paciente?";
            EliminarPaciente.ShowDialog();*/
        }

        private void btn_VerHistorialClinico_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void Directorio_Pacientes_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón Agregar Paciente
            btn_AgregarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgregarPaciente.Width, btn_AgregarPaciente.Height, 15, 15));

            // Redondear Botón Editar Paciente
            btn_EditarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EditarPaciente.Width, btn_EditarPaciente.Height, 15, 15));

            // Redondear Botón Eliminar Paciente
            btn_EliminarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EliminarPaciente.Width, btn_EliminarPaciente.Height, 15, 15));

            // Redondear Botón Ver Historial Clínico
            btn_VerHistorialClinico.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_VerHistorialClinico.Width, btn_VerHistorialClinico.Height, 15, 15));

            // Redondear Botón Buscar Paciente
            btn_BuscarPaciente.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_BuscarPaciente.Width, btn_BuscarPaciente.Height, 15, 15));
        }
    }
}
