namespace FISCLINGEST.Módulos.Interfaces_Administracion.Interfaces_Usuarios
{
    partial class Usuarios
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
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_DesactivarUsuario = new System.Windows.Forms.Button();
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.btn_AgregarUsuario = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Location = new System.Drawing.Point(319, 152);
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.Size = new System.Drawing.Size(447, 233);
            this.dgv_Usuarios.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(311, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(455, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "GESTIONAR USUARIOS";
            // 
            // btn_DesactivarUsuario
            // 
            this.btn_DesactivarUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btn_DesactivarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_DesactivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_DesactivarUsuario.Image = global::FISCLINGEST.Properties.Resources.icron_Desactivar_Usuario;
            this.btn_DesactivarUsuario.Location = new System.Drawing.Point(567, 401);
            this.btn_DesactivarUsuario.Name = "btn_DesactivarUsuario";
            this.btn_DesactivarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btn_DesactivarUsuario.TabIndex = 13;
            this.btn_DesactivarUsuario.UseVisualStyleBackColor = false;
            this.btn_DesactivarUsuario.Click += new System.EventHandler(this.btn_DesactivarUsuario_Click);
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btn_EditarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_EditarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarUsuario.Image = global::FISCLINGEST.Properties.Resources.Icon_editar_usuario;
            this.btn_EditarUsuario.Location = new System.Drawing.Point(511, 401);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btn_EditarUsuario.TabIndex = 12;
            this.btn_EditarUsuario.UseVisualStyleBackColor = false;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // btn_AgregarUsuario
            // 
            this.btn_AgregarUsuario.BackColor = System.Drawing.Color.Maroon;
            this.btn_AgregarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_AgregarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarUsuario.Image = global::FISCLINGEST.Properties.Resources.icron_Agregar_Usuario;
            this.btn_AgregarUsuario.Location = new System.Drawing.Point(455, 401);
            this.btn_AgregarUsuario.Name = "btn_AgregarUsuario";
            this.btn_AgregarUsuario.Size = new System.Drawing.Size(50, 50);
            this.btn_AgregarUsuario.TabIndex = 11;
            this.btn_AgregarUsuario.UseVisualStyleBackColor = false;
            this.btn_AgregarUsuario.Click += new System.EventHandler(this.btn_AgregarUsuario_Click);
            // 
            // Usuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FISCLINGEST.Properties.Resources.Icon_Cert_fisioterapia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_DesactivarUsuario);
            this.Controls.Add(this.btn_EditarUsuario);
            this.Controls.Add(this.btn_AgregarUsuario);
            this.Controls.Add(this.dgv_Usuarios);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Usuarios";
            this.Text = "Usuarios";
            this.Load += new System.EventHandler(this.Usuarios_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_AgregarUsuario;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.Button btn_DesactivarUsuario;
    }
}