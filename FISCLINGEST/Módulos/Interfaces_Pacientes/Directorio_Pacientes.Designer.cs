namespace FISCLINGEST.Módulos.Interfaces_Pacientes
{
    partial class Directorio_Pacientes
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgv_directorio = new System.Windows.Forms.DataGridView();
            this.btn_EliminarPaciente = new System.Windows.Forms.Button();
            this.btn_VerHistorialClinico = new System.Windows.Forms.Button();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.btn_EditarPaciente = new System.Windows.Forms.Button();
            this.btn_AgregarPaciente = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_directorio)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(242, 127);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(505, 20);
            this.textBox5.TabIndex = 38;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(234, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(554, 45);
            this.label2.TabIndex = 31;
            this.label2.Text = "DIRECTORIO DE PACIENTES";
            // 
            // dgv_directorio
            // 
            this.dgv_directorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_directorio.Location = new System.Drawing.Point(242, 169);
            this.dgv_directorio.Name = "dgv_directorio";
            this.dgv_directorio.Size = new System.Drawing.Size(546, 243);
            this.dgv_directorio.TabIndex = 29;
            // 
            // btn_EliminarPaciente
            // 
            this.btn_EliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EliminarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_EliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarPaciente.Image = global::FISCLINGEST.Properties.Resources.Eliminar_paciente;
            this.btn_EliminarPaciente.Location = new System.Drawing.Point(484, 431);
            this.btn_EliminarPaciente.Name = "btn_EliminarPaciente";
            this.btn_EliminarPaciente.Size = new System.Drawing.Size(50, 50);
            this.btn_EliminarPaciente.TabIndex = 41;
            this.btn_EliminarPaciente.UseVisualStyleBackColor = false;
            this.btn_EliminarPaciente.Click += new System.EventHandler(this.btn_EliminarPaciente_Click);
            // 
            // btn_VerHistorialClinico
            // 
            this.btn_VerHistorialClinico.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_VerHistorialClinico.FlatAppearance.BorderSize = 0;
            this.btn_VerHistorialClinico.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_VerHistorialClinico.Image = global::FISCLINGEST.Properties.Resources.Icon_Ver_Historial_Clinico;
            this.btn_VerHistorialClinico.Location = new System.Drawing.Point(557, 431);
            this.btn_VerHistorialClinico.Name = "btn_VerHistorialClinico";
            this.btn_VerHistorialClinico.Size = new System.Drawing.Size(50, 50);
            this.btn_VerHistorialClinico.TabIndex = 40;
            this.btn_VerHistorialClinico.UseVisualStyleBackColor = false;
            this.btn_VerHistorialClinico.Click += new System.EventHandler(this.btn_VerHistorialClinico_Click);
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.BackColor = System.Drawing.Color.Maroon;
            this.btn_BuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_BuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarPaciente.Image = global::FISCLINGEST.Properties.Resources.Buscar_paciente;
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(753, 119);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(35, 35);
            this.btn_BuscarPaciente.TabIndex = 37;
            this.btn_BuscarPaciente.UseVisualStyleBackColor = false;
            this.btn_BuscarPaciente.Click += new System.EventHandler(this.btn_BuscarPaciente_Click);
            // 
            // btn_EditarPaciente
            // 
            this.btn_EditarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EditarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_EditarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarPaciente.Image = global::FISCLINGEST.Properties.Resources.Icon_editar_paciente;
            this.btn_EditarPaciente.Location = new System.Drawing.Point(415, 431);
            this.btn_EditarPaciente.Name = "btn_EditarPaciente";
            this.btn_EditarPaciente.Size = new System.Drawing.Size(50, 50);
            this.btn_EditarPaciente.TabIndex = 30;
            this.btn_EditarPaciente.UseVisualStyleBackColor = false;
            this.btn_EditarPaciente.Click += new System.EventHandler(this.btn_EditarPaciente_Click);
            // 
            // btn_AgregarPaciente
            // 
            this.btn_AgregarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AgregarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_AgregarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarPaciente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarPaciente.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AgregarPaciente.Image = global::FISCLINGEST.Properties.Resources.Agregar_paciente;
            this.btn_AgregarPaciente.Location = new System.Drawing.Point(340, 431);
            this.btn_AgregarPaciente.Name = "btn_AgregarPaciente";
            this.btn_AgregarPaciente.Size = new System.Drawing.Size(50, 50);
            this.btn_AgregarPaciente.TabIndex = 28;
            this.btn_AgregarPaciente.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AgregarPaciente.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AgregarPaciente.UseVisualStyleBackColor = false;
            this.btn_AgregarPaciente.Click += new System.EventHandler(this.btn_AgregarPaciente_Click);
            // 
            // Directorio_Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_EliminarPaciente);
            this.Controls.Add(this.btn_VerHistorialClinico);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_BuscarPaciente);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_EditarPaciente);
            this.Controls.Add(this.dgv_directorio);
            this.Controls.Add(this.btn_AgregarPaciente);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Directorio_Pacientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Agregar paciente";
            this.Load += new System.EventHandler(this.Directorio_Pacientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_directorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_EditarPaciente;
        private System.Windows.Forms.DataGridView dgv_directorio;
        private System.Windows.Forms.Button btn_AgregarPaciente;
        private System.Windows.Forms.Button btn_VerHistorialClinico;
        private System.Windows.Forms.Button btn_EliminarPaciente;
    }
}