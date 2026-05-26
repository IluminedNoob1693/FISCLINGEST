namespace FISCLINGEST.Módulos.Interfaces_Pacientes.Lista_de_espera
{
    partial class Lista_Espera
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
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dgv_directorio = new System.Windows.Forms.DataGridView();
            this.btn_EliminarPaciente = new System.Windows.Forms.Button();
            this.btn_BuscarPaciente = new System.Windows.Forms.Button();
            this.btn_EditarListEspera = new System.Windows.Forms.Button();
            this.btn_AgregarListEspera = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_directorio)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(368, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(357, 45);
            this.label1.TabIndex = 2;
            this.label1.Text = "LISTA DE ESPERA";
            // 
            // textBox5
            // 
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(244, 110);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(505, 20);
            this.textBox5.TabIndex = 46;
            // 
            // dgv_directorio
            // 
            this.dgv_directorio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_directorio.Location = new System.Drawing.Point(244, 152);
            this.dgv_directorio.Name = "dgv_directorio";
            this.dgv_directorio.Size = new System.Drawing.Size(546, 243);
            this.dgv_directorio.TabIndex = 43;
            // 
            // btn_EliminarPaciente
            // 
            this.btn_EliminarPaciente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EliminarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_EliminarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EliminarPaciente.Image = global::FISCLINGEST.Properties.Resources.Eliminar_Lista_Espera;
            this.btn_EliminarPaciente.Location = new System.Drawing.Point(549, 411);
            this.btn_EliminarPaciente.Name = "btn_EliminarPaciente";
            this.btn_EliminarPaciente.Size = new System.Drawing.Size(50, 50);
            this.btn_EliminarPaciente.TabIndex = 48;
            this.btn_EliminarPaciente.UseVisualStyleBackColor = false;
            this.btn_EliminarPaciente.Click += new System.EventHandler(this.btn_EliminarPaciente_Click);
            // 
            // btn_BuscarPaciente
            // 
            this.btn_BuscarPaciente.BackColor = System.Drawing.Color.Maroon;
            this.btn_BuscarPaciente.FlatAppearance.BorderSize = 0;
            this.btn_BuscarPaciente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_BuscarPaciente.Image = global::FISCLINGEST.Properties.Resources.Buscar_paciente;
            this.btn_BuscarPaciente.Location = new System.Drawing.Point(755, 102);
            this.btn_BuscarPaciente.Name = "btn_BuscarPaciente";
            this.btn_BuscarPaciente.Size = new System.Drawing.Size(35, 35);
            this.btn_BuscarPaciente.TabIndex = 45;
            this.btn_BuscarPaciente.UseVisualStyleBackColor = false;
            this.btn_BuscarPaciente.Click += new System.EventHandler(this.btn_BuscarPaciente_Click);
            // 
            // btn_EditarListEspera
            // 
            this.btn_EditarListEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EditarListEspera.FlatAppearance.BorderSize = 0;
            this.btn_EditarListEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarListEspera.Image = global::FISCLINGEST.Properties.Resources.Icon_editar_lista_espera;
            this.btn_EditarListEspera.Location = new System.Drawing.Point(480, 411);
            this.btn_EditarListEspera.Name = "btn_EditarListEspera";
            this.btn_EditarListEspera.Size = new System.Drawing.Size(50, 50);
            this.btn_EditarListEspera.TabIndex = 44;
            this.btn_EditarListEspera.UseVisualStyleBackColor = false;
            this.btn_EditarListEspera.Click += new System.EventHandler(this.btn_EditarListEspera_Click);
            // 
            // btn_AgregarListEspera
            // 
            this.btn_AgregarListEspera.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AgregarListEspera.FlatAppearance.BorderSize = 0;
            this.btn_AgregarListEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarListEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_AgregarListEspera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_AgregarListEspera.Image = global::FISCLINGEST.Properties.Resources.Añadir_Lista_Espera;
            this.btn_AgregarListEspera.Location = new System.Drawing.Point(405, 411);
            this.btn_AgregarListEspera.Name = "btn_AgregarListEspera";
            this.btn_AgregarListEspera.Size = new System.Drawing.Size(50, 50);
            this.btn_AgregarListEspera.TabIndex = 42;
            this.btn_AgregarListEspera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_AgregarListEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_AgregarListEspera.UseVisualStyleBackColor = false;
            this.btn_AgregarListEspera.Click += new System.EventHandler(this.btn_AgregarListEspera_Click);
            // 
            // Lista_Espera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FISCLINGEST.Properties.Resources.Icon_Cert_fisioterapia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_EliminarPaciente);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.btn_BuscarPaciente);
            this.Controls.Add(this.btn_EditarListEspera);
            this.Controls.Add(this.dgv_directorio);
            this.Controls.Add(this.btn_AgregarListEspera);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Lista_Espera";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Lista_Espera";
            this.Load += new System.EventHandler(this.Lista_Espera_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_directorio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EliminarPaciente;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button btn_BuscarPaciente;
        private System.Windows.Forms.Button btn_EditarListEspera;
        private System.Windows.Forms.DataGridView dgv_directorio;
        private System.Windows.Forms.Button btn_AgregarListEspera;
    }
}