namespace FISCLINGEST.Módulos
{
    partial class loguin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(loguin));
            this.Panel_Titulo_IniciarSesion = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cerrar_loguin = new System.Windows.Forms.PictureBox();
            this.btn_validarContraseña = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_User = new System.Windows.Forms.TextBox();
            this.txt_Password = new System.Windows.Forms.TextBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Panel_Titulo_IniciarSesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Panel_Titulo_IniciarSesion
            // 
            this.Panel_Titulo_IniciarSesion.BackColor = System.Drawing.Color.MidnightBlue;
            this.Panel_Titulo_IniciarSesion.Controls.Add(this.pictureBox4);
            this.Panel_Titulo_IniciarSesion.Controls.Add(this.label8);
            this.Panel_Titulo_IniciarSesion.Controls.Add(this.btn_Cerrar_loguin);
            this.Panel_Titulo_IniciarSesion.Location = new System.Drawing.Point(0, 0);
            this.Panel_Titulo_IniciarSesion.Name = "Panel_Titulo_IniciarSesion";
            this.Panel_Titulo_IniciarSesion.Size = new System.Drawing.Size(361, 46);
            this.Panel_Titulo_IniciarSesion.TabIndex = 0;
            this.Panel_Titulo_IniciarSesion.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Panel_Titulo_IniciarSesion_MouseDown);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::FISCLINGEST.Properties.Resources.Icono_FISCLINGENT;
            this.pictureBox4.Location = new System.Drawing.Point(8, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(37, 38);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 21;
            this.pictureBox4.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(51, 12);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(107, 19);
            this.label8.TabIndex = 20;
            this.label8.Text = "Iniciar sesión";
            // 
            // btn_Cerrar_loguin
            // 
            this.btn_Cerrar_loguin.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar1;
            this.btn_Cerrar_loguin.Location = new System.Drawing.Point(331, 12);
            this.btn_Cerrar_loguin.Name = "btn_Cerrar_loguin";
            this.btn_Cerrar_loguin.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar_loguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar_loguin.TabIndex = 10;
            this.btn_Cerrar_loguin.TabStop = false;
            this.btn_Cerrar_loguin.Click += new System.EventHandler(this.btn_Cerrar_loguin_Click);
            // 
            // btn_validarContraseña
            // 
            this.btn_validarContraseña.BackColor = System.Drawing.Color.Maroon;
            this.btn_validarContraseña.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.btn_validarContraseña.FlatAppearance.BorderSize = 0;
            this.btn_validarContraseña.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_validarContraseña.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold);
            this.btn_validarContraseña.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btn_validarContraseña.Location = new System.Drawing.Point(120, 341);
            this.btn_validarContraseña.Name = "btn_validarContraseña";
            this.btn_validarContraseña.Size = new System.Drawing.Size(113, 33);
            this.btn_validarContraseña.TabIndex = 2;
            this.btn_validarContraseña.Text = "Ingresar";
            this.btn_validarContraseña.UseVisualStyleBackColor = false;
            this.btn_validarContraseña.Click += new System.EventHandler(this.btn_validarContraseña_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(136, 176);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(116, 251);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Contraseña:";
            // 
            // txt_User
            // 
            this.txt_User.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_User.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_User.ForeColor = System.Drawing.Color.Maroon;
            this.txt_User.Location = new System.Drawing.Point(96, 221);
            this.txt_User.Name = "txt_User";
            this.txt_User.Size = new System.Drawing.Size(153, 27);
            this.txt_User.TabIndex = 5;
            this.txt_User.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_Password
            // 
            this.txt_Password.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.txt_Password.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Password.ForeColor = System.Drawing.Color.Maroon;
            this.txt_Password.Location = new System.Drawing.Point(96, 290);
            this.txt_Password.Name = "txt_Password";
            this.txt_Password.Size = new System.Drawing.Size(153, 27);
            this.txt_Password.TabIndex = 6;
            this.txt_Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_Password.UseSystemPasswordChar = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = global::FISCLINGEST.Properties.Resources.icono_contrasena_rojo_transparente;
            this.pictureBox3.Location = new System.Drawing.Point(61, 281);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(29, 29);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 8;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FISCLINGEST.Properties.Resources.usuarios_icono_rojo_transparente;
            this.pictureBox2.Location = new System.Drawing.Point(61, 221);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(29, 29);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FISCLINGEST.Properties.Resources.iconio_loguin_FISCLINGENT;
            this.pictureBox1.Location = new System.Drawing.Point(120, 66);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(125, 88);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // loguin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(361, 422);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.txt_Password);
            this.Controls.Add(this.txt_User);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_validarContraseña);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.Panel_Titulo_IniciarSesion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "loguin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "loguin";
            this.Load += new System.EventHandler(this.loguin_Load);
            this.Panel_Titulo_IniciarSesion.ResumeLayout(false);
            this.Panel_Titulo_IniciarSesion.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Panel_Titulo_IniciarSesion;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_validarContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_User;
        private System.Windows.Forms.TextBox txt_Password;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox btn_Cerrar_loguin;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label8;
    }
}