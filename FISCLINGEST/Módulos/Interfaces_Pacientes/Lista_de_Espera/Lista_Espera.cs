using FISCLINGEST.Módulos.Interfaces_Pacientes.Lista_de_Espera;
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

namespace FISCLINGEST.Módulos.Interfaces_Pacientes.Lista_de_espera
{
    public partial class Lista_Espera : Form
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
        public Lista_Espera()
        {
            InitializeComponent();
        }

        private void btn_AgregarListEspera_Click(object sender, EventArgs e)
        {
            Form Agregar_ListaEspera = new Agregar_ListEspera(1);
            Agregar_ListaEspera.ShowDialog();
        }

        private void btn_EditarListEspera_Click(object sender, EventArgs e)
        {
            Form Editar_ListaEspera = new Agregar_ListEspera(2);
            Editar_ListaEspera.ShowDialog();
        }

        private void btn_EliminarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void btn_BuscarPaciente_Click(object sender, EventArgs e)
        {

        }

        private void Lista_Espera_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            // Redondear Botón Agregar a Lista de Espera
            btn_AgregarListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_AgregarListEspera.Width, btn_AgregarListEspera.Height, 15, 15));
            
            // Redondear Botón Editar paciente de Lista de Espera
            btn_EditarListEspera.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EditarListEspera.Width, btn_EditarListEspera.Height, 15, 15));

            // Redondear Botón Eliminar paciente de Lista de Espera
            btn_EliminarPaciente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_EliminarPaciente.Width, btn_EliminarPaciente.Height, 15, 15));

            // Redondear Botón Buscar paciente de Lista de Espera
            btn_BuscarPaciente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_BuscarPaciente.Width, btn_BuscarPaciente.Height, 15, 15));
        }
    }
}
