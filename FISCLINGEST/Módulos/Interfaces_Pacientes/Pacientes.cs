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
    public partial class Pacientes : Form
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

        private Menu_Principal _menuPrincipal;
        public Pacientes(Menu_Principal menuprincipal)
        {
            InitializeComponent();
            _menuPrincipal = menuprincipal;
        }
        public Pacientes(){}

        private void btn_Directorio_Pacientes_Click(object sender, EventArgs e)
        {
            _menuPrincipal.AbrirFormEnPanel(new Módulos.Interfaces_Pacientes.Directorio_Pacientes());


        }

        private void btn_ListaEspera_Click(object sender, EventArgs e)
        {
            _menuPrincipal.AbrirFormEnPanel(new Módulos.Interfaces_Pacientes.Lista_de_espera.Lista_Espera());
        }

        private void Pacientes_Load(object sender, EventArgs e)
        {

            //Aplicar redondeo a los controles existentes
            // Redondear Botón directorio de pacientes
            btn_Directorio_Pacientes.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_Directorio_Pacientes.Width, btn_Directorio_Pacientes.Height, 15, 15));
            
            // Redondear Botón lista de espera
            btn_ListaEspera.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ListaEspera.Width, btn_ListaEspera.Height, 15, 15));
        }
    }
}
