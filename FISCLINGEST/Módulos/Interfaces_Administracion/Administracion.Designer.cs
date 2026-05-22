namespace FISCLINGEST
{
    partial class Administracion
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
            this.btn_Respaldos = new System.Windows.Forms.Button();
            this.btn_ExportarReportes = new System.Windows.Forms.Button();
            this.btn_GestionUsuarios = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(207, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(606, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODULO DE ADMINISTRACIÓN";
            // 
            // btn_Respaldos
            // 
            this.btn_Respaldos.BackColor = System.Drawing.Color.Maroon;
            this.btn_Respaldos.FlatAppearance.BorderSize = 0;
            this.btn_Respaldos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Respaldos.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Respaldos.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Respaldos.Image = global::FISCLINGEST.Properties.Resources.Icon_submodulo_respaldos;
            this.btn_Respaldos.Location = new System.Drawing.Point(689, 160);
            this.btn_Respaldos.Name = "btn_Respaldos";
            this.btn_Respaldos.Size = new System.Drawing.Size(256, 318);
            this.btn_Respaldos.TabIndex = 5;
            this.btn_Respaldos.Text = "Respaldos";
            this.btn_Respaldos.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Respaldos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Respaldos.UseVisualStyleBackColor = false;
            this.btn_Respaldos.Click += new System.EventHandler(this.btn_Respaldos_Click);
            // 
            // btn_ExportarReportes
            // 
            this.btn_ExportarReportes.BackColor = System.Drawing.Color.Maroon;
            this.btn_ExportarReportes.FlatAppearance.BorderSize = 0;
            this.btn_ExportarReportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarReportes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportarReportes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ExportarReportes.Image = global::FISCLINGEST.Properties.Resources.Icon_submodulo_exportar_reporte;
            this.btn_ExportarReportes.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ExportarReportes.Location = new System.Drawing.Point(393, 160);
            this.btn_ExportarReportes.Name = "btn_ExportarReportes";
            this.btn_ExportarReportes.Size = new System.Drawing.Size(256, 318);
            this.btn_ExportarReportes.TabIndex = 4;
            this.btn_ExportarReportes.Text = "Exportar reportes";
            this.btn_ExportarReportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ExportarReportes.UseVisualStyleBackColor = false;
            this.btn_ExportarReportes.Click += new System.EventHandler(this.btn_ExportarReportes_Click);
            // 
            // btn_GestionUsuarios
            // 
            this.btn_GestionUsuarios.BackColor = System.Drawing.Color.Maroon;
            this.btn_GestionUsuarios.FlatAppearance.BorderSize = 0;
            this.btn_GestionUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_GestionUsuarios.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_GestionUsuarios.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_GestionUsuarios.Image = global::FISCLINGEST.Properties.Resources.Icon_Submodulo_Gestion_Usuarios;
            this.btn_GestionUsuarios.Location = new System.Drawing.Point(92, 160);
            this.btn_GestionUsuarios.Name = "btn_GestionUsuarios";
            this.btn_GestionUsuarios.Size = new System.Drawing.Size(256, 318);
            this.btn_GestionUsuarios.TabIndex = 3;
            this.btn_GestionUsuarios.Text = "Gestión de usuarios";
            this.btn_GestionUsuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_GestionUsuarios.UseVisualStyleBackColor = false;
            this.btn_GestionUsuarios.Click += new System.EventHandler(this.btn_GestionUsuarios_Click);
            // 
            // Administracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_Respaldos);
            this.Controls.Add(this.btn_ExportarReportes);
            this.Controls.Add(this.btn_GestionUsuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Administracion";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Administracion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_GestionUsuarios;
        private System.Windows.Forms.Button btn_ExportarReportes;
        private System.Windows.Forms.Button btn_Respaldos;
    }
}