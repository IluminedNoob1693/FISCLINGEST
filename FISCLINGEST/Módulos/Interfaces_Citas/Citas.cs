using FISCLINGEST.Módulos.Interfaces_Citas;
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
using Microsoft.VisualBasic;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FISCLINGEST
{
    public partial class Citas : Form
    {
        // Variables globales para rastrear el mes y año en pantalla
        private int mesActivo;
        private int añoActivo;

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
            /*Form AgendarCita = new Módulos.Interfaces_Citas.Agendar_Cita(1);
            AgendarCita.ShowDialog();*/

            using (Agendar_Cita modal = new Agendar_Cita(1))
            {
                if (modal.ShowDialog() == DialogResult.OK)
                {
                    // Recorremos cada una de las citas creadas en el modal (pueden ser hasta 4)
                    foreach (CitasService cita in modal.CitasAgendadas)
                    {
                        // Buscamos la casilla física en el FlowLayoutPanel que coincida con la fecha de la cita
                        foreach (Control ctrl in flowDias.Controls)
                        {
                            if (ctrl is UserControl_Dia ucDia)
                            {
                                // Comparamos únicamente la propiedad de fecha (sin importar la hora para el color del día)
                                if (ucDia.FechaAsociada.Date == cita.FechaHora.Date)
                                {
                                    ucDia.AsignarEstado(UserControl_Dia.EstadoCita.Agendada);
                                    // Puedes romper el ciclo interno al encontrar la casilla
                                    break;
                                }
                            }
                        }
                    }

                    MessageBox.Show("Las citas han sido asignadas y resaltadas en el calendario.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }

        private void btn_ReprogramarCita_Click(object sender, EventArgs e)
        {
            Form ReprogramarCita = new Módulos.Interfaces_Citas.Agendar_Cita(2);
            ReprogramarCita.ShowDialog();

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

            // Arranca el calendario posicionándose en la fecha del sistema operativo
            DateTime fechaActual = DateTime.Now;
            mesActivo = fechaActual.Month;
            añoActivo = fechaActual.Year;

            DesplegarCalendario(mesActivo, añoActivo);
        }

        private void DesplegarCalendario(int mes, int año)
        {
            // 1. Limpiar los controles previos para evitar acumulación de memoria
            flowDias.Controls.Clear();

            // 2. Actualizar el encabezado textual del formulario
            DateTime primerDiaDelMes = new DateTime(año, mes, 1);
            lbl_MesAño.Text = primerDiaDelMes.ToString("MMMM yyyy").ToUpper();

            // 3. Determinar en qué día de la semana cae el primer día (0 = Domingo, 1 = Lunes...)
            int desplazamientoSemana = Convert.ToInt32(primerDiaDelMes.DayOfWeek);

            // 4. Agregar espacios en blanco de compensación al inicio del panel
            for (int i = 0; i < desplazamientoSemana; i++)
            {
                UserControl espacioVacio = new UserControl();
                espacioVacio.Size = new Size(50, 50); // Mismo tamaño exacto del ContenedorDia

                espacioVacio.Size = new Size(60, 50);   // Tamaño idéntico
                espacioVacio.Margin = new Padding(0);   // Fuerza margen cero
                espacioVacio.Padding = new Padding(0);  // Fuerza relleno cero

                // SOLUCIÓN CLAVE: Deben ser visibles, pero estéticamente ocultos
                espacioVacio.Visible = true;
                espacioVacio.BackColor = Color.Transparent; // O el color de fondo de tu Formulario

                // Deshabilitamos interacciones para que el usuario no pueda darles clic
                espacioVacio.Enabled = false;

                flowDias.Controls.Add(espacioVacio);
            }

            // 5. Obtener la cantidad exacta de días (Resuelve automáticamente años bisiestos y meses cortos)
            int totalDiasMes = DateTime.DaysInMonth(año, mes);

            // 6. Instanciar e inyectar dinámicamente cada casilla de día en el FlowLayoutPanel
            for (int dia = 1; dia <= totalDiasMes; dia++)
            {
                UserControl_Dia ucDia = new UserControl_Dia();
                ucDia.Size = new Size(60, 50);          // Dimensiones calculadas
                ucDia.Margin = new Padding(0);          // Elimina espacios externos
                ucDia.Padding = new Padding(0);         // Elimina espacios internos
                DateTime fechaCasilla = new DateTime(año, mes, dia);

                ucDia.ConfigurarDia(dia, fechaCasilla);

                // NUEVA VALIDACIÓN: Si la fecha de la casilla es estrictamente menor a hoy, se bloquea
                if (fechaCasilla < DateTime.Today)
                {
                    ucDia.SetBloqueo(true);
                }
                else
                {
                    // Solo suscribimos los eventos de clic a los días presentes o futuros
                    ucDia.Click += ValidarYModificarCasilla;

                    // Asegurar que si el usuario da clic sobre los Labels internos, también se dispare el evento
                    foreach (Control controlInterno in ucDia.Controls)
                    {
                        controlInterno.Click += (s, e) => ValidarYModificarCasilla(ucDia, e);
                    }

                    flowDias.Controls.Add(ucDia);
                }
            }
        }
        private void ValidarYModificarCasilla(object sender, EventArgs e)
        {
            UserControl_Dia diaSeleccionado = (UserControl_Dia)sender;

            // Validación básica: Evitar manipulación si el día está bloqueado por sistema
            if (diaSeleccionado.EstaBloqueado)
            {
                MessageBox.Show("Este día se encuentra deshabilitado para gestiones.", "Día Bloqueado", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Ejemplo de cuadro de diálogo interactivo o simulación de backend:
            // En un caso real, aquí abrirías un formulario secundario de gestión de citas
            string opciones = "Escribe el número de la acción que deseas realizar:\n" +
                              "1 - Agendar Cita (Verde)\n" +
                              "2 - Reprogramar Cita (Amarillo)\n" +
                              "3 - Cancelar Cita (Rojo)\n" +
                              "4 - Bloquear Día por completo (Gris)";

            string respuesta = Microsoft.VisualBasic.Interaction.InputBox(opciones, $"Gestión para el {diaSeleccionado.FechaAsociada.ToShortDateString()}", "1");

            switch (respuesta)
            {
                case "1":
                    diaSeleccionado.AsignarEstado(UserControl_Dia.EstadoCita.Agendada);
                    break;
                case "2":
                    diaSeleccionado.AsignarEstado(UserControl_Dia.EstadoCita.Reprogramada);
                    break;
                case "3":
                    diaSeleccionado.AsignarEstado(UserControl_Dia.EstadoCita.Cancelada);
                    break;
                case "4":
                    diaSeleccionado.SetBloqueo(true);
                    break;
                default:
                    // Si el cuadro se cierra o cancela, mantiene su estado original
                    break;
            }
        }

        private void btn_Anterior_Click(object sender, EventArgs e)
        {
            mesActivo--;
            if (mesActivo < 1)
            {
                mesActivo = 12;
                añoActivo--;
            }
            DesplegarCalendario(mesActivo, añoActivo);
        }

        private void btn_Siguiente_Click(object sender, EventArgs e)
        {
            mesActivo++;
            if (mesActivo > 12)
            {
                mesActivo = 1;
                añoActivo++;
            }
            DesplegarCalendario(mesActivo, añoActivo);
        }
        private void btn_ExportarAgenda_Click(object sender, EventArgs e)
        {
            Form ExportarAgenda = new Módulos.Interfaces_Administracion.Exportar_Reportes();
            ExportarAgenda.ShowDialog();
        }
    }
}
