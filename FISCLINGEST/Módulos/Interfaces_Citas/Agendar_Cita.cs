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

namespace FISCLINGEST.Módulos.Interfaces_Citas
{
    public partial class Agendar_Cita : Form
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
        // Propiedad pública para que el Form1 pueda leer las citas aprobadas
        public List<CitasService> CitasAgendadas { get; private set; } = new List<CitasService>();

        public Agendar_Cita(int tituloCita)
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 20, 20));
            this.Load += Agendar_Cita_Load;

            //Cambiar título del formulario y visibilidad de etiquetas según el valor de tituloCita
            if (tituloCita == 1)
            {
                lbl_AgendarCita.Visible = true;  // Mostrar primera
                lbl_EditarCita.Visible = false; // Ocultar segunda
            }
            else
            {
                lbl_AgendarCita.Visible = false; // Ocultar primera
                lbl_EditarCita.Visible = true;  // Mostrar segunda
            }

        }

        private void Cerrar_AgendarCita_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txt_BusquedaPacienteCita_TextChanged(object sender, EventArgs e)
        {

        }
        private void btn_AgregarCita_Click(object sender, EventArgs e)
        {
            // Combinar la fecha de un componente con la hora del otro
            DateTime fechaSeleccionada = dtp_FechaCita.Value.Date;
            DateTime horaSeleccionada = dtp_HoraCita.Value;
            DateTime fechaHoraCombinada = fechaSeleccionada.Add(horaSeleccionada.TimeOfDay);

            // VALIDACIÓN DE HORA: Evita agendar horas que ya transcurrieron el día de hoy
            if (fechaHoraCombinada < DateTime.Now)
            {
                MessageBox.Show("No puedes agendar una cita en una hora o fecha que ya ha pasado.", "Fecha Inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar el límite máximo solicitado
            if (CitasAgendadas.Count >= 4)
            {
                MessageBox.Show("Solo puedes agendar un máximo de 4 citas a la vez.", "Límite alcanzado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Evitar duplicados exactos en la lista
            if (CitasAgendadas.Exists(c => c.FechaHora == fechaHoraCombinada))
            {
                MessageBox.Show("Ya has agregado una cita exactamente a esa misma hora.", "Cita Duplicada", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Registrar la cita
            CitasService nuevaCita = new CitasService { FechaHora = fechaHoraCombinada };
            CitasAgendadas.Add(nuevaCita);

            // Reflejar en la interfaz de usuario
            Lst_Citas.Items.Add(fechaHoraCombinada.ToString("dd/MM/yyyy - hh:mm tt"));
        }
        private void btn_EliminarCita_Click(object sender, EventArgs e)
        {
            if (Lst_Citas.SelectedIndex != -1)
            {
                int indice = Lst_Citas.SelectedIndex;
                CitasAgendadas.RemoveAt(indice);
                Lst_Citas.Items.RemoveAt(indice);
            }
        }
        private void btn_ValidarCita_Click(object sender, EventArgs e)
        {
            if (CitasAgendadas.Count == 0)
            {
                MessageBox.Show("Debes agregar al menos una cita para continuar.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            this.DialogResult = DialogResult.OK; // Cierra el modal indicando éxito
            this.Close();
        }

        //Para poder mover la ventana a cualquier direccion
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void panel_TituloAgendarCita_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Agendar_Cita_Load(object sender, EventArgs e)
        {
            //Aplicar redondeo a los controles existentes
            //Redondear el botón de validar
            btn_ValidarCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, btn_ValidarCita.Width, btn_ValidarCita.Height, 15, 15));

            //Redondear textbox del nombre
            txt_BusquedaPacienteCita.BorderStyle = BorderStyle.None; // Recomendado para textboxes redondeados
            txt_BusquedaPacienteCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, txt_BusquedaPacienteCita.Width, txt_BusquedaPacienteCita.Height, 15, 15));

            // Redondear el DateTimePicker
            dtp_FechaCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, dtp_FechaCita.Width, dtp_FechaCita.Height, 15, 15));

            // Redondear el ComboBox
            cbx_EstadoCita.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_EstadoCita.Width, cbx_EstadoCita.Height, 15, 15));

            // Redondear el ComboBox de hora
            cbx_TipoPaciente.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_TipoPaciente.Width, cbx_TipoPaciente.Height, 15, 15));

            //Redondear el ComboBox de tipo de terapia
            cbx_TipoTerapia.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, cbx_TipoTerapia.Width, cbx_TipoTerapia.Height, 15, 15));

            // Restringe el calendario para que la fecha mínima seleccionable sea el día de hoy
            dtp_FechaCita.MinDate = DateTime.Today;
        }
    }
}   
