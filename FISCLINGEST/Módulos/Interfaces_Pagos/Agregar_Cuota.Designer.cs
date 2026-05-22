namespace FISCLINGEST.Módulos.Interfaces_Pagos
{
    partial class Agregar_Cuota
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
            this.panel_TituloAgregarCuota = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cerrar_AgregarPaciente = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_ImporteCuota = new System.Windows.Forms.TextBox();
            this.btn_ValidarPago = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dpt_FechaPago = new System.Windows.Forms.DateTimePicker();
            this.cbx_EstadoPagoActivo = new System.Windows.Forms.CheckBox();
            this.cbx_EstadoPagoAnulado = new System.Windows.Forms.CheckBox();
            this.txt_FolioPaciente = new System.Windows.Forms.TextBox();
            this.txt_FolioCaja = new System.Windows.Forms.TextBox();
            this.panel_TituloAgregarCuota.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_AgregarPaciente)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TituloAgregarCuota
            // 
            this.panel_TituloAgregarCuota.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_TituloAgregarCuota.Controls.Add(this.pictureBox1);
            this.panel_TituloAgregarCuota.Controls.Add(this.label8);
            this.panel_TituloAgregarCuota.Controls.Add(this.btn_Cerrar_AgregarPaciente);
            this.panel_TituloAgregarCuota.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TituloAgregarCuota.Location = new System.Drawing.Point(0, 0);
            this.panel_TituloAgregarCuota.Name = "panel_TituloAgregarCuota";
            this.panel_TituloAgregarCuota.Size = new System.Drawing.Size(341, 46);
            this.panel_TituloAgregarCuota.TabIndex = 2;
            this.panel_TituloAgregarCuota.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TituloAgregarCuota_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::FISCLINGEST.Properties.Resources.Icono_FISCLINGENT;
            this.pictureBox1.Location = new System.Drawing.Point(3, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(37, 38);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(46, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Registrar nueva cuota";
            // 
            // btn_Cerrar_AgregarPaciente
            // 
            this.btn_Cerrar_AgregarPaciente.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar1;
            this.btn_Cerrar_AgregarPaciente.Location = new System.Drawing.Point(311, 9);
            this.btn_Cerrar_AgregarPaciente.Name = "btn_Cerrar_AgregarPaciente";
            this.btn_Cerrar_AgregarPaciente.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar_AgregarPaciente.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar_AgregarPaciente.TabIndex = 10;
            this.btn_Cerrar_AgregarPaciente.TabStop = false;
            this.btn_Cerrar_AgregarPaciente.Click += new System.EventHandler(this.btn_Cerrar_AgregarPaciente_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(228, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 5;
            this.label1.Text = "Importe:";
            // 
            // txt_ImporteCuota
            // 
            this.txt_ImporteCuota.BackColor = System.Drawing.Color.LightBlue;
            this.txt_ImporteCuota.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_ImporteCuota.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_ImporteCuota.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_ImporteCuota.Location = new System.Drawing.Point(232, 93);
            this.txt_ImporteCuota.Multiline = true;
            this.txt_ImporteCuota.Name = "txt_ImporteCuota";
            this.txt_ImporteCuota.Size = new System.Drawing.Size(86, 22);
            this.txt_ImporteCuota.TabIndex = 4;
            this.txt_ImporteCuota.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_ValidarPago
            // 
            this.btn_ValidarPago.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ValidarPago.FlatAppearance.BorderSize = 0;
            this.btn_ValidarPago.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ValidarPago.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ValidarPago.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ValidarPago.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ValidarPago.Location = new System.Drawing.Point(111, 304);
            this.btn_ValidarPago.Name = "btn_ValidarPago";
            this.btn_ValidarPago.Size = new System.Drawing.Size(99, 32);
            this.btn_ValidarPago.TabIndex = 17;
            this.btn_ValidarPago.Text = "Guardar";
            this.btn_ValidarPago.UseVisualStyleBackColor = false;
            this.btn_ValidarPago.Click += new System.EventHandler(this.btn_ValidarPago_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(46, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(135, 21);
            this.label2.TabIndex = 18;
            this.label2.Text = "Fecha de pago:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(205, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(87, 21);
            this.label3.TabIndex = 19;
            this.label3.Text = "Folio caja:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(32, 138);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 21);
            this.label4.TabIndex = 20;
            this.label4.Text = "Folio paciente:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(90, 222);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(143, 21);
            this.label5.TabIndex = 21;
            this.label5.Text = "Estado del pago:";
            // 
            // dpt_FechaPago
            // 
            this.dpt_FechaPago.Location = new System.Drawing.Point(21, 95);
            this.dpt_FechaPago.Name = "dpt_FechaPago";
            this.dpt_FechaPago.Size = new System.Drawing.Size(198, 20);
            this.dpt_FechaPago.TabIndex = 22;
            // 
            // cbx_EstadoPagoActivo
            // 
            this.cbx_EstadoPagoActivo.AutoSize = true;
            this.cbx_EstadoPagoActivo.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbx_EstadoPagoActivo.Location = new System.Drawing.Point(68, 263);
            this.cbx_EstadoPagoActivo.Name = "cbx_EstadoPagoActivo";
            this.cbx_EstadoPagoActivo.Size = new System.Drawing.Size(56, 17);
            this.cbx_EstadoPagoActivo.TabIndex = 23;
            this.cbx_EstadoPagoActivo.Text = "Activo";
            this.cbx_EstadoPagoActivo.UseVisualStyleBackColor = true;
            // 
            // cbx_EstadoPagoAnulado
            // 
            this.cbx_EstadoPagoAnulado.AutoSize = true;
            this.cbx_EstadoPagoAnulado.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.cbx_EstadoPagoAnulado.Location = new System.Drawing.Point(197, 263);
            this.cbx_EstadoPagoAnulado.Name = "cbx_EstadoPagoAnulado";
            this.cbx_EstadoPagoAnulado.Size = new System.Drawing.Size(65, 17);
            this.cbx_EstadoPagoAnulado.TabIndex = 24;
            this.cbx_EstadoPagoAnulado.Text = "Anulado";
            this.cbx_EstadoPagoAnulado.UseVisualStyleBackColor = true;
            // 
            // txt_FolioPaciente
            // 
            this.txt_FolioPaciente.BackColor = System.Drawing.Color.LightBlue;
            this.txt_FolioPaciente.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FolioPaciente.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_FolioPaciente.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_FolioPaciente.Location = new System.Drawing.Point(23, 172);
            this.txt_FolioPaciente.Multiline = true;
            this.txt_FolioPaciente.Name = "txt_FolioPaciente";
            this.txt_FolioPaciente.Size = new System.Drawing.Size(133, 22);
            this.txt_FolioPaciente.TabIndex = 25;
            this.txt_FolioPaciente.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txt_FolioCaja
            // 
            this.txt_FolioCaja.BackColor = System.Drawing.Color.LightBlue;
            this.txt_FolioCaja.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_FolioCaja.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_FolioCaja.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_FolioCaja.Location = new System.Drawing.Point(185, 172);
            this.txt_FolioCaja.Multiline = true;
            this.txt_FolioCaja.Name = "txt_FolioCaja";
            this.txt_FolioCaja.Size = new System.Drawing.Size(133, 22);
            this.txt_FolioCaja.TabIndex = 26;
            this.txt_FolioCaja.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Agregar_Cuota
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(341, 360);
            this.Controls.Add(this.txt_FolioCaja);
            this.Controls.Add(this.txt_FolioPaciente);
            this.Controls.Add(this.cbx_EstadoPagoAnulado);
            this.Controls.Add(this.cbx_EstadoPagoActivo);
            this.Controls.Add(this.dpt_FechaPago);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_ValidarPago);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_ImporteCuota);
            this.Controls.Add(this.panel_TituloAgregarCuota);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Agregar_Cuota";
            this.Text = "Agregar_Cuota";
            this.Load += new System.EventHandler(this.Agregar_Cuota_Load);
            this.panel_TituloAgregarCuota.ResumeLayout(false);
            this.panel_TituloAgregarCuota.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_AgregarPaciente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TituloAgregarCuota;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btn_Cerrar_AgregarPaciente;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_ImporteCuota;
        private System.Windows.Forms.Button btn_ValidarPago;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dpt_FechaPago;
        private System.Windows.Forms.CheckBox cbx_EstadoPagoActivo;
        private System.Windows.Forms.CheckBox cbx_EstadoPagoAnulado;
        private System.Windows.Forms.TextBox txt_FolioPaciente;
        private System.Windows.Forms.TextBox txt_FolioCaja;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}