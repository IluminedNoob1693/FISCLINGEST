namespace FISCLINGEST
{
    partial class Citas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btn_ExportarAgenda = new System.Windows.Forms.Button();
            this.btn_DesbloquearFecha = new System.Windows.Forms.Button();
            this.btn_BuscarCita = new System.Windows.Forms.Button();
            this.btn_AgendarCita = new System.Windows.Forms.Button();
            this.btn_CancelarCita = new System.Windows.Forms.Button();
            this.btn_BloquearFecha = new System.Windows.Forms.Button();
            this.btn_ReprogramarCita = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(324, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(381, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "GESTIÓN DE CITAS";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(372, 122);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.ShowWeekNumbers = true;
            this.monthCalendar1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Location = new System.Drawing.Point(310, 315);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(331, 150);
            this.dataGridView1.TabIndex = 0;
            // 
            // btn_ExportarAgenda
            // 
            this.btn_ExportarAgenda.BackColor = System.Drawing.Color.Maroon;
            this.btn_ExportarAgenda.FlatAppearance.BorderSize = 0;
            this.btn_ExportarAgenda.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarAgenda.Image = global::FISCLINGEST.Properties.Resources.Icon_Exportar_Agenda;
            this.btn_ExportarAgenda.Location = new System.Drawing.Point(310, 234);
            this.btn_ExportarAgenda.Name = "btn_ExportarAgenda";
            this.btn_ExportarAgenda.Size = new System.Drawing.Size(50, 50);
            this.btn_ExportarAgenda.TabIndex = 10;
            this.btn_ExportarAgenda.UseVisualStyleBackColor = false;
            this.btn_ExportarAgenda.Click += new System.EventHandler(this.btn_ExportarAgenda_Click);
            // 
            // btn_DesbloquearFecha
            // 
            this.btn_DesbloquearFecha.BackColor = System.Drawing.Color.Maroon;
            this.btn_DesbloquearFecha.FlatAppearance.BorderSize = 0;
            this.btn_DesbloquearFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DesbloquearFecha.Image = global::FISCLINGEST.Properties.Resources.Icon_Desbloquear_Agenda;
            this.btn_DesbloquearFecha.Location = new System.Drawing.Point(310, 178);
            this.btn_DesbloquearFecha.Name = "btn_DesbloquearFecha";
            this.btn_DesbloquearFecha.Size = new System.Drawing.Size(50, 50);
            this.btn_DesbloquearFecha.TabIndex = 9;
            this.btn_DesbloquearFecha.UseVisualStyleBackColor = false;
            this.btn_DesbloquearFecha.Click += new System.EventHandler(this.btn_DesbloquearFecha_Click);
            // 
            // btn_BuscarCita
            // 
            this.btn_BuscarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_BuscarCita.FlatAppearance.BorderSize = 0;
            this.btn_BuscarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarCita.Image = global::FISCLINGEST.Properties.Resources.Icon_Buscar_Cita;
            this.btn_BuscarCita.Location = new System.Drawing.Point(527, 471);
            this.btn_BuscarCita.Name = "btn_BuscarCita";
            this.btn_BuscarCita.Size = new System.Drawing.Size(50, 50);
            this.btn_BuscarCita.TabIndex = 8;
            this.btn_BuscarCita.UseVisualStyleBackColor = false;
            this.btn_BuscarCita.Click += new System.EventHandler(this.btn_BuscarCita_Click_1);
            // 
            // btn_AgendarCita
            // 
            this.btn_AgendarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AgendarCita.FlatAppearance.BorderSize = 0;
            this.btn_AgendarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgendarCita.Image = global::FISCLINGEST.Properties.Resources.Agendar_Cita;
            this.btn_AgendarCita.Location = new System.Drawing.Point(359, 471);
            this.btn_AgendarCita.Name = "btn_AgendarCita";
            this.btn_AgendarCita.Size = new System.Drawing.Size(50, 50);
            this.btn_AgendarCita.TabIndex = 7;
            this.btn_AgendarCita.UseVisualStyleBackColor = false;
            this.btn_AgendarCita.Click += new System.EventHandler(this.btn_AgendarCita_Click);
            // 
            // btn_CancelarCita
            // 
            this.btn_CancelarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_CancelarCita.FlatAppearance.BorderSize = 0;
            this.btn_CancelarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CancelarCita.Image = global::FISCLINGEST.Properties.Resources.Icon_cancelar_Cita;
            this.btn_CancelarCita.Location = new System.Drawing.Point(471, 471);
            this.btn_CancelarCita.Name = "btn_CancelarCita";
            this.btn_CancelarCita.Size = new System.Drawing.Size(50, 50);
            this.btn_CancelarCita.TabIndex = 6;
            this.btn_CancelarCita.UseVisualStyleBackColor = false;
            this.btn_CancelarCita.Click += new System.EventHandler(this.btn_CancelarCita_Click);
            // 
            // btn_BloquearFecha
            // 
            this.btn_BloquearFecha.BackColor = System.Drawing.Color.Maroon;
            this.btn_BloquearFecha.FlatAppearance.BorderSize = 0;
            this.btn_BloquearFecha.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BloquearFecha.Image = global::FISCLINGEST.Properties.Resources.Icon_Bloquear_Agenda;
            this.btn_BloquearFecha.Location = new System.Drawing.Point(310, 122);
            this.btn_BloquearFecha.Name = "btn_BloquearFecha";
            this.btn_BloquearFecha.Size = new System.Drawing.Size(50, 50);
            this.btn_BloquearFecha.TabIndex = 5;
            this.btn_BloquearFecha.UseVisualStyleBackColor = false;
            this.btn_BloquearFecha.Click += new System.EventHandler(this.btn_BloquearFecha_Click);
            // 
            // btn_ReprogramarCita
            // 
            this.btn_ReprogramarCita.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ReprogramarCita.FlatAppearance.BorderSize = 0;
            this.btn_ReprogramarCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ReprogramarCita.Image = global::FISCLINGEST.Properties.Resources.Icon_Reprogramar_Cita;
            this.btn_ReprogramarCita.Location = new System.Drawing.Point(415, 471);
            this.btn_ReprogramarCita.Name = "btn_ReprogramarCita";
            this.btn_ReprogramarCita.Size = new System.Drawing.Size(50, 50);
            this.btn_ReprogramarCita.TabIndex = 4;
            this.btn_ReprogramarCita.UseVisualStyleBackColor = false;
            this.btn_ReprogramarCita.Click += new System.EventHandler(this.btn_ReprogramarCita_Click);
            // 
            // Citas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_ExportarAgenda);
            this.Controls.Add(this.btn_DesbloquearFecha);
            this.Controls.Add(this.btn_BuscarCita);
            this.Controls.Add(this.btn_AgendarCita);
            this.Controls.Add(this.btn_CancelarCita);
            this.Controls.Add(this.btn_BloquearFecha);
            this.Controls.Add(this.btn_ReprogramarCita);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Citas";
            this.Text = "Cancelar cita";
            this.Load += new System.EventHandler(this.Citas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_ReprogramarCita;
        private System.Windows.Forms.Button btn_BloquearFecha;
        private System.Windows.Forms.Button btn_CancelarCita;
        private System.Windows.Forms.Button btn_AgendarCita;
        private System.Windows.Forms.Button btn_BuscarCita;
        private System.Windows.Forms.Button btn_DesbloquearFecha;
        private System.Windows.Forms.Button btn_ExportarAgenda;
    }
}