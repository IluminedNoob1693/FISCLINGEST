using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FISCLINGEST
{
    public partial class UserControl_Dia : UserControl
    {
        // Guardamos la fecha completa asociada a este recuadro
        public DateTime FechaAsociada { get; private set; }
        public bool EstaBloqueado { get; private set; } = false;

        public enum EstadoCita { Disponible, Agendada, Reprogramada, Cancelada }
        private EstadoCita estadoActual = EstadoCita.Disponible;
        public UserControl_Dia()
        {
            InitializeComponent();
        }
        // Método para inicializar cada casilla con su número y fecha correspondientes
        public void ConfigurarDia(int numeroDia, DateTime fecha)
        {
            FechaAsociada = fecha;
            lbl_Dia.Text = numeroDia.ToString();
            AsignarEstado(EstadoCita.Disponible);
        }

        // Centraliza el comportamiento visual y los colores solicitados
        public void AsignarEstado(EstadoCita nuevoEstado)
        {
            if (EstaBloqueado) return; // Si está bloqueado, no cambia por estados de citas

            estadoActual = nuevoEstado;
            switch (nuevoEstado)
            {
                case EstadoCita.Disponible:
                    this.BackColor = Color.White;
                    /*lbl_Estado.Text = "Disponible";
                    lbl_Estado.ForeColor = Color.Gray;*/
                    break;
                case EstadoCita.Agendada:
                    this.BackColor = Color.LightGreen;
                    /*lbl_Estado.Text = "Agendada";
                    lbl_Estado.ForeColor = Color.DarkGreen;*/
                    break;
                case EstadoCita.Reprogramada:
                    this.BackColor = Color.LightYellow;
                    /*lbl_Estado.Text = "Reprogramada";   
                    lbl_Estado.ForeColor = Color.DarkGoldenrod;*/
                    break;
                case EstadoCita.Cancelada:
                    this.BackColor = Color.LightCoral;
                    /*lbl_Estado.Text = "Cancelada";
                    lbl_Estado.ForeColor = Color.DarkRed;*/
                    break;
            }
        }
        // Método para bloquear o desbloquear la interacción del día
        public void SetBloqueo(bool bloquear)
        {
            EstaBloqueado = bloquear;
            if (bloquear)
            {
                this.BackColor = Color.Gainsboro;
                lbl_Estado.Text = "Bloqueado";
                lbl_Estado.ForeColor = Color.DarkGray;
                this.Cursor = Cursors.No;
            }
            else
            {
                this.Cursor = Cursors.Hand;
                AsignarEstado(EstadoCita.Disponible);
            }
        }

    }
}
