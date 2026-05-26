namespace FISCLINGEST
{
    partial class Menu_Principal
    {
        /// <summary>
        /// Variable del diseñador requerida.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén utilizando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido del método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu_Principal));
            this.Menu_Vertical = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Barra_Título = new System.Windows.Forms.Panel();
            this.Panel_contenedor = new System.Windows.Forms.Panel();
            this.btn_minimizar = new System.Windows.Forms.PictureBox();
            this.btn_Cerrar = new System.Windows.Forms.PictureBox();
            this.btn_Maximizar = new System.Windows.Forms.PictureBox();
            this.btn_restaurar = new System.Windows.Forms.PictureBox();
            this.btn_Contraer = new System.Windows.Forms.PictureBox();
            this.btn_CerrarSesion = new System.Windows.Forms.Button();
            this.logo_menu = new System.Windows.Forms.PictureBox();
            this.btn_Administracion = new System.Windows.Forms.Button();
            this.btn_Citas = new System.Windows.Forms.Button();
            this.btn_Cuotas = new System.Windows.Forms.Button();
            this.btn_Pacientes = new System.Windows.Forms.Button();
            this.Menu_Vertical.SuspendLayout();
            this.Barra_Título.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Contraer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_menu)).BeginInit();
            this.SuspendLayout();
            // 
            // Menu_Vertical
            // 
            this.Menu_Vertical.BackColor = System.Drawing.Color.DarkRed;
            this.Menu_Vertical.Controls.Add(this.btn_CerrarSesion);
            this.Menu_Vertical.Controls.Add(this.label1);
            this.Menu_Vertical.Controls.Add(this.logo_menu);
            this.Menu_Vertical.Controls.Add(this.btn_Administracion);
            this.Menu_Vertical.Controls.Add(this.btn_Citas);
            this.Menu_Vertical.Controls.Add(this.btn_Cuotas);
            this.Menu_Vertical.Controls.Add(this.btn_Pacientes);
            this.Menu_Vertical.Dock = System.Windows.Forms.DockStyle.Left;
            this.Menu_Vertical.Location = new System.Drawing.Point(0, 0);
            this.Menu_Vertical.Name = "Menu_Vertical";
            this.Menu_Vertical.Size = new System.Drawing.Size(250, 611);
            this.Menu_Vertical.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(52, 562);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 25);
            this.label1.TabIndex = 9;
            this.label1.Text = "Cerrar sesión";
            // 
            // Barra_Título
            // 
            this.Barra_Título.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.Barra_Título.Controls.Add(this.btn_minimizar);
            this.Barra_Título.Controls.Add(this.btn_Cerrar);
            this.Barra_Título.Controls.Add(this.btn_Maximizar);
            this.Barra_Título.Controls.Add(this.btn_restaurar);
            this.Barra_Título.Controls.Add(this.btn_Contraer);
            this.Barra_Título.Dock = System.Windows.Forms.DockStyle.Top;
            this.Barra_Título.Location = new System.Drawing.Point(250, 0);
            this.Barra_Título.Name = "Barra_Título";
            this.Barra_Título.Size = new System.Drawing.Size(1034, 45);
            this.Barra_Título.TabIndex = 1;
            this.Barra_Título.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Barra_Título_MouseDown);
            // 
            // Panel_contenedor
            // 
            this.Panel_contenedor.BackColor = System.Drawing.Color.White;
            this.Panel_contenedor.BackgroundImage = global::FISCLINGEST.Properties.Resources.Icon_Cert_fisioterapia;
            this.Panel_contenedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel_contenedor.Location = new System.Drawing.Point(250, 45);
            this.Panel_contenedor.Name = "Panel_contenedor";
            this.Panel_contenedor.Size = new System.Drawing.Size(1034, 566);
            this.Panel_contenedor.TabIndex = 2;
            // 
            // btn_minimizar
            // 
            this.btn_minimizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimizar.Image = global::FISCLINGEST.Properties.Resources.minimizar_Icon;
            this.btn_minimizar.Location = new System.Drawing.Point(958, 12);
            this.btn_minimizar.Name = "btn_minimizar";
            this.btn_minimizar.Size = new System.Drawing.Size(18, 18);
            this.btn_minimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_minimizar.TabIndex = 8;
            this.btn_minimizar.TabStop = false;
            this.btn_minimizar.Click += new System.EventHandler(this.btn_minimizar_Click);
            // 
            // btn_Cerrar
            // 
            this.btn_Cerrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Cerrar.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar;
            this.btn_Cerrar.Location = new System.Drawing.Point(1006, 12);
            this.btn_Cerrar.Name = "btn_Cerrar";
            this.btn_Cerrar.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar.TabIndex = 7;
            this.btn_Cerrar.TabStop = false;
            this.btn_Cerrar.Click += new System.EventHandler(this.btn_Cerrar_Click);
            // 
            // btn_Maximizar
            // 
            this.btn_Maximizar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Maximizar.Image = global::FISCLINGEST.Properties.Resources.icon_maximizar1;
            this.btn_Maximizar.Location = new System.Drawing.Point(982, 12);
            this.btn_Maximizar.Name = "btn_Maximizar";
            this.btn_Maximizar.Size = new System.Drawing.Size(18, 18);
            this.btn_Maximizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Maximizar.TabIndex = 6;
            this.btn_Maximizar.TabStop = false;
            this.btn_Maximizar.Click += new System.EventHandler(this.btn_Maximizar_Click);
            // 
            // btn_restaurar
            // 
            this.btn_restaurar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_restaurar.Image = global::FISCLINGEST.Properties.Resources.icon_restaurar;
            this.btn_restaurar.Location = new System.Drawing.Point(982, 12);
            this.btn_restaurar.Name = "btn_restaurar";
            this.btn_restaurar.Size = new System.Drawing.Size(18, 18);
            this.btn_restaurar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_restaurar.TabIndex = 5;
            this.btn_restaurar.TabStop = false;
            this.btn_restaurar.Visible = false;
            this.btn_restaurar.Click += new System.EventHandler(this.btn_restaurar_Click);
            // 
            // btn_Contraer
            // 
            this.btn_Contraer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Contraer.Image = global::FISCLINGEST.Properties.Resources.Mobile_Menu_Icon;
            this.btn_Contraer.Location = new System.Drawing.Point(6, 4);
            this.btn_Contraer.Name = "btn_Contraer";
            this.btn_Contraer.Size = new System.Drawing.Size(35, 35);
            this.btn_Contraer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Contraer.TabIndex = 4;
            this.btn_Contraer.TabStop = false;
            this.btn_Contraer.Click += new System.EventHandler(this.btn_Contraer_Click);
            // 
            // btn_CerrarSesion
            // 
            this.btn_CerrarSesion.BackColor = System.Drawing.Color.Maroon;
            this.btn_CerrarSesion.FlatAppearance.BorderSize = 0;
            this.btn_CerrarSesion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_CerrarSesion.Image = global::FISCLINGEST.Properties.Resources.Icon_cerrar_sesion;
            this.btn_CerrarSesion.Location = new System.Drawing.Point(77, 473);
            this.btn_CerrarSesion.Name = "btn_CerrarSesion";
            this.btn_CerrarSesion.Size = new System.Drawing.Size(90, 86);
            this.btn_CerrarSesion.TabIndex = 4;
            this.btn_CerrarSesion.UseVisualStyleBackColor = false;
            this.btn_CerrarSesion.Click += new System.EventHandler(this.btn_CerrarSesion_Click);
            // 
            // logo_menu
            // 
            this.logo_menu.Image = global::FISCLINGEST.Properties.Resources.Icono_FISCLINGENT;
            this.logo_menu.Location = new System.Drawing.Point(77, 12);
            this.logo_menu.Name = "logo_menu";
            this.logo_menu.Size = new System.Drawing.Size(90, 84);
            this.logo_menu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logo_menu.TabIndex = 0;
            this.logo_menu.TabStop = false;
            // 
            // btn_Administracion
            // 
            this.btn_Administracion.BackColor = System.Drawing.Color.Maroon;
            this.btn_Administracion.FlatAppearance.BorderSize = 0;
            this.btn_Administracion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Administracion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Administracion.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Administracion.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Administracion.Image = global::FISCLINGEST.Properties.Resources.Icon_modulo_Administración1;
            this.btn_Administracion.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Administracion.Location = new System.Drawing.Point(0, 251);
            this.btn_Administracion.Name = "btn_Administracion";
            this.btn_Administracion.Size = new System.Drawing.Size(250, 40);
            this.btn_Administracion.TabIndex = 3;
            this.btn_Administracion.Text = "Administracion";
            this.btn_Administracion.UseVisualStyleBackColor = false;
            this.btn_Administracion.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // btn_Citas
            // 
            this.btn_Citas.BackColor = System.Drawing.Color.Maroon;
            this.btn_Citas.FlatAppearance.BorderSize = 0;
            this.btn_Citas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Citas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Citas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Citas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Citas.Image = global::FISCLINGEST.Properties.Resources.Icon_Agenda_citas;
            this.btn_Citas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Citas.Location = new System.Drawing.Point(0, 159);
            this.btn_Citas.Name = "btn_Citas";
            this.btn_Citas.Size = new System.Drawing.Size(250, 40);
            this.btn_Citas.TabIndex = 2;
            this.btn_Citas.Text = "Citas";
            this.btn_Citas.UseVisualStyleBackColor = false;
            this.btn_Citas.Click += new System.EventHandler(this.btn_Citas_Click);
            // 
            // btn_Cuotas
            // 
            this.btn_Cuotas.BackColor = System.Drawing.Color.Maroon;
            this.btn_Cuotas.FlatAppearance.BorderSize = 0;
            this.btn_Cuotas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Cuotas.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Cuotas.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Cuotas.Image = global::FISCLINGEST.Properties.Resources.Icon_Modulo_Cuotas;
            this.btn_Cuotas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Cuotas.Location = new System.Drawing.Point(0, 205);
            this.btn_Cuotas.Name = "btn_Cuotas";
            this.btn_Cuotas.Size = new System.Drawing.Size(250, 40);
            this.btn_Cuotas.TabIndex = 1;
            this.btn_Cuotas.Text = "Cuotas";
            this.btn_Cuotas.UseVisualStyleBackColor = false;
            this.btn_Cuotas.Click += new System.EventHandler(this.btn_Cuotas_Click);
            // 
            // btn_Pacientes
            // 
            this.btn_Pacientes.BackColor = System.Drawing.Color.Maroon;
            this.btn_Pacientes.FlatAppearance.BorderSize = 0;
            this.btn_Pacientes.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(48)))));
            this.btn_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Pacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Pacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Pacientes.Image = global::FISCLINGEST.Properties.Resources.Icon_modulo_pacientes;
            this.btn_Pacientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_Pacientes.Location = new System.Drawing.Point(0, 113);
            this.btn_Pacientes.Name = "btn_Pacientes";
            this.btn_Pacientes.Size = new System.Drawing.Size(250, 40);
            this.btn_Pacientes.TabIndex = 0;
            this.btn_Pacientes.Text = "Pacientes";
            this.btn_Pacientes.UseVisualStyleBackColor = false;
            this.btn_Pacientes.Click += new System.EventHandler(this.btn_Pacientes_Click);
            // 
            // Menu_Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1284, 611);
            this.Controls.Add(this.Panel_contenedor);
            this.Controls.Add(this.Barra_Título);
            this.Controls.Add(this.Menu_Vertical);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "Menu_Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Menu_Principal_Load);
            this.Menu_Vertical.ResumeLayout(false);
            this.Menu_Vertical.PerformLayout();
            this.Barra_Título.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Maximizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_restaurar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Contraer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logo_menu)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Menu_Vertical;
        private System.Windows.Forms.Panel Barra_Título;
        private System.Windows.Forms.Button btn_Administracion;
        private System.Windows.Forms.Button btn_Citas;
        private System.Windows.Forms.Button btn_Cuotas;
        private System.Windows.Forms.Button btn_Pacientes;
        private System.Windows.Forms.PictureBox logo_menu;
        private System.Windows.Forms.PictureBox btn_Contraer;
        private System.Windows.Forms.PictureBox btn_restaurar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox btn_Maximizar;
        private System.Windows.Forms.PictureBox btn_Cerrar;
        private System.Windows.Forms.Panel Panel_contenedor;
        private System.Windows.Forms.PictureBox btn_minimizar;
        private System.Windows.Forms.Button btn_CerrarSesion;
    }
}

