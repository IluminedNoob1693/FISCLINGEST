namespace FISCLINGEST
{
    partial class msg_Exito
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
            this.panel_TituloExito = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Cerrar_AgregarPaciente = new System.Windows.Forms.PictureBox();
            this.lbl_TituloDialogoExito = new System.Windows.Forms.Label();
            this.btn_Cerrar_loguin = new System.Windows.Forms.PictureBox();
            this.btn_MsgAceptar = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lbl_ExitoText = new System.Windows.Forms.Label();
            this.panel_TituloExito.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_AgregarPaciente)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TituloExito
            // 
            this.panel_TituloExito.BackColor = System.Drawing.Color.DarkGreen;
            this.panel_TituloExito.Controls.Add(this.pictureBox1);
            this.panel_TituloExito.Controls.Add(this.Cerrar_AgregarPaciente);
            this.panel_TituloExito.Controls.Add(this.lbl_TituloDialogoExito);
            this.panel_TituloExito.Controls.Add(this.btn_Cerrar_loguin);
            this.panel_TituloExito.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TituloExito.Location = new System.Drawing.Point(0, 0);
            this.panel_TituloExito.Name = "panel_TituloExito";
            this.panel_TituloExito.Size = new System.Drawing.Size(310, 46);
            this.panel_TituloExito.TabIndex = 24;
            this.panel_TituloExito.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TituloExito_MouseDown);
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
            // lbl_TituloDialogoExito
            // 
            this.lbl_TituloDialogoExito.AutoSize = true;
            this.lbl_TituloDialogoExito.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_TituloDialogoExito.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbl_TituloDialogoExito.Location = new System.Drawing.Point(49, 12);
            this.lbl_TituloDialogoExito.Name = "lbl_TituloDialogoExito";
            this.lbl_TituloDialogoExito.Size = new System.Drawing.Size(179, 19);
            this.lbl_TituloDialogoExito.TabIndex = 16;
            this.lbl_TituloDialogoExito.Text = "Titulo de dialogo exito";
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
            // btn_MsgAceptar
            // 
            this.btn_MsgAceptar.BackColor = System.Drawing.Color.ForestGreen;
            this.btn_MsgAceptar.FlatAppearance.BorderSize = 0;
            this.btn_MsgAceptar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_MsgAceptar.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_MsgAceptar.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_MsgAceptar.Location = new System.Drawing.Point(97, 165);
            this.btn_MsgAceptar.Name = "btn_MsgAceptar";
            this.btn_MsgAceptar.Size = new System.Drawing.Size(99, 32);
            this.btn_MsgAceptar.TabIndex = 27;
            this.btn_MsgAceptar.Text = "Aceptar";
            this.btn_MsgAceptar.UseVisualStyleBackColor = false;
            this.btn_MsgAceptar.Click += new System.EventHandler(this.btn_MsgAceptar_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::FISCLINGEST.Properties.Resources.Icon_msg_exito;
            this.pictureBox2.Location = new System.Drawing.Point(12, 80);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(54, 51);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // lbl_ExitoText
            // 
            this.lbl_ExitoText.Font = new System.Drawing.Font("Futura Md BT", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ExitoText.Location = new System.Drawing.Point(72, 59);
            this.lbl_ExitoText.Name = "lbl_ExitoText";
            this.lbl_ExitoText.Size = new System.Drawing.Size(215, 91);
            this.lbl_ExitoText.TabIndex = 25;
            this.lbl_ExitoText.Text = "Contenido mensaje de dialogo exito";
            this.lbl_ExitoText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // msg_Exito
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel_TituloExito);
            this.Controls.Add(this.btn_MsgAceptar);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_ExitoText);
            this.Name = "msg_Exito";
            this.Size = new System.Drawing.Size(310, 210);
            this.Load += new System.EventHandler(this.msg_Exito_Load);
            this.panel_TituloExito.ResumeLayout(false);
            this.panel_TituloExito.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Cerrar_AgregarPaciente)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_loguin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_TituloExito;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox Cerrar_AgregarPaciente;
        private System.Windows.Forms.Label lbl_TituloDialogoExito;
        private System.Windows.Forms.PictureBox btn_Cerrar_loguin;
        private System.Windows.Forms.Button btn_MsgAceptar;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lbl_ExitoText;
    }
}
