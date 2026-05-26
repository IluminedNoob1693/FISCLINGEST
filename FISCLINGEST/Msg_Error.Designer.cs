namespace FISCLINGEST
{
    partial class Msg_Error
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
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

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbl_ErrorText = new System.Windows.Forms.Label();
            this.panel_TituloError = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cerrar_AgregarPaciente = new System.Windows.Forms.PictureBox();
            this.lbl_TituloDialogoError = new System.Windows.Forms.Label();
            this.btn_Cerrar_loguin = new System.Windows.Forms.PictureBox();
            this.btn_ConfirmarError = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel_TituloError.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_AgregarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_ErrorText
            // 
            this.lbl_ErrorText.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ErrorText.Location = new System.Drawing.Point(79, 80);
            this.lbl_ErrorText.Name = "lbl_ErrorText";
            this.lbl_ErrorText.Size = new System.Drawing.Size(184, 70);
            this.lbl_ErrorText.TabIndex = 28;
            this.lbl_ErrorText.Text = "Contenido mensaje de error.";
            this.lbl_ErrorText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_TituloError
            // 
            this.panel_TituloError.BackColor = System.Drawing.Color.Maroon;
            this.panel_TituloError.Controls.Add(this.pictureBox1);
            this.panel_TituloError.Controls.Add(this.Cerrar_AgregarPaciente);
            this.panel_TituloError.Controls.Add(this.lbl_TituloDialogoError);
            this.panel_TituloError.Controls.Add(this.btn_Cerrar_loguin);
            this.panel_TituloError.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TituloError.Location = new System.Drawing.Point(0, 0);
            this.panel_TituloError.Name = "panel_TituloError";
            this.panel_TituloError.Size = new System.Drawing.Size(310, 46);
            this.panel_TituloError.TabIndex = 27;
            this.panel_TituloError.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TituloError_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FISCLINGEST.Properties.Resources.Icono_FISCLINGENT;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 19;
            this.pictureBox1.TabStop = false;
            // 
            // Cerrar_AgregarPaciente
            // 
            this.Cerrar_AgregarPaciente.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar1;
            this.Cerrar_AgregarPaciente.Location = new System.Drawing.Point(370, 12);
            this.Cerrar_AgregarPaciente.Name = "Cerrar_AgregarPaciente";
            this.Cerrar_AgregarPaciente.Size = new System.Drawing.Size(18, 18);
            this.Cerrar_AgregarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Cerrar_AgregarPaciente.TabIndex = 17;
            this.Cerrar_AgregarPaciente.TabStop = false;
            // 
            // lbl_TituloDialogoError
            // 
            this.lbl_TituloDialogoError.AutoSize = true;
            this.lbl_TituloDialogoError.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloDialogoError.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TituloDialogoError.Location = new System.Drawing.Point(49, 12);
            this.lbl_TituloDialogoError.Name = "lbl_TituloDialogoError";
            this.lbl_TituloDialogoError.Size = new System.Drawing.Size(87, 19);
            this.lbl_TituloDialogoError.TabIndex = 16;
            this.lbl_TituloDialogoError.Text = "Titulo error";
            // 
            // btn_Cerrar_loguin
            // 
            this.btn_Cerrar_loguin.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar1;
            this.btn_Cerrar_loguin.Location = new System.Drawing.Point(470, 12);
            this.btn_Cerrar_loguin.Name = "btn_Cerrar_loguin";
            this.btn_Cerrar_loguin.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar_loguin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar_loguin.TabIndex = 10;
            this.btn_Cerrar_loguin.TabStop = false;
            // 
            // btn_ConfirmarError
            // 
            this.btn_ConfirmarError.BackColor = System.Drawing.Color.Maroon;
            this.btn_ConfirmarError.FlatAppearance.BorderSize = 0;
            this.btn_ConfirmarError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConfirmarError.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ConfirmarError.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ConfirmarError.Location = new System.Drawing.Point(96, 162);
            this.btn_ConfirmarError.Name = "btn_ConfirmarError";
            this.btn_ConfirmarError.Size = new System.Drawing.Size(99, 32);
            this.btn_ConfirmarError.TabIndex = 30;
            this.btn_ConfirmarError.Text = "Aceptar";
            this.btn_ConfirmarError.UseVisualStyleBackColor = false;
            this.btn_ConfirmarError.Click += new System.EventHandler(this.btn_ConfirmarError_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FISCLINGEST.Properties.Resources.Icon_msg_error;
            this.pictureBox2.Location = new System.Drawing.Point(19, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 29;
            this.pictureBox2.TabStop = false;
            // 
            // Msg_Error
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lbl_ErrorText);
            this.Controls.Add(this.panel_TituloError);
            this.Controls.Add(this.btn_ConfirmarError);
            this.Controls.Add(this.pictureBox2);
            this.Name = "Msg_Error";
            this.Size = new System.Drawing.Size(310, 210);
            this.Load += new System.EventHandler(this.Msg_Error_Load);
            this.panel_TituloError.ResumeLayout(false);
            this.panel_TituloError.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_AgregarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_ErrorText;
        private System.Windows.Forms.Panel panel_TituloError;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Cerrar_AgregarPaciente;
        private System.Windows.Forms.Label lbl_TituloDialogoError;
        private System.Windows.Forms.PictureBox btn_Cerrar_loguin;
        private System.Windows.Forms.Button btn_ConfirmarError;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}
