namespace FISCLINGEST.Módulos.Interfaces_Administracion
{
    partial class Exportar_Reportes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Exportar_Reportes));
            this.panel_TituloExportarReporte = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btn_Cerrar_ExportarReportes = new System.Windows.Forms.PictureBox();
            this.txt_AñoReporte = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.btn_ExportarReporte = new System.Windows.Forms.Button();
            this.ckb_ReportePagos = new System.Windows.Forms.CheckBox();
            this.ckb_ReporteAgenda = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.cbx_Tipo_Periodo = new System.Windows.Forms.ComboBox();
            this.cbx_MesReporte = new System.Windows.Forms.ComboBox();
            this.txt_SemanaReporte = new System.Windows.Forms.TextBox();
            this.dtp_FechaReporte = new System.Windows.Forms.DateTimePicker();
            this.txt_AutorReporte = new System.Windows.Forms.TextBox();
            this.btn_Ruta_Archivo = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.panel_TituloExportarReporte.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_ExportarReportes)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_TituloExportarReporte
            // 
            this.panel_TituloExportarReporte.BackColor = System.Drawing.Color.MidnightBlue;
            this.panel_TituloExportarReporte.Controls.Add(this.pictureBox1);
            this.panel_TituloExportarReporte.Controls.Add(this.label8);
            this.panel_TituloExportarReporte.Controls.Add(this.btn_Cerrar_ExportarReportes);
            this.panel_TituloExportarReporte.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_TituloExportarReporte.Location = new System.Drawing.Point(0, 0);
            this.panel_TituloExportarReporte.Name = "panel_TituloExportarReporte";
            this.panel_TituloExportarReporte.Size = new System.Drawing.Size(540, 46);
            this.panel_TituloExportarReporte.TabIndex = 4;
            this.panel_TituloExportarReporte.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel_TituloExportarReporte_MouseDown);
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
            this.label8.Location = new System.Drawing.Point(54, 11);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(141, 19);
            this.label8.TabIndex = 16;
            this.label8.Text = "Exportar reportes ";
            // 
            // btn_Cerrar_ExportarReportes
            // 
            this.btn_Cerrar_ExportarReportes.Image = global::FISCLINGEST.Properties.Resources.icon_cerrar1;
            this.btn_Cerrar_ExportarReportes.Location = new System.Drawing.Point(510, 12);
            this.btn_Cerrar_ExportarReportes.Name = "btn_Cerrar_ExportarReportes";
            this.btn_Cerrar_ExportarReportes.Size = new System.Drawing.Size(18, 18);
            this.btn_Cerrar_ExportarReportes.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_Cerrar_ExportarReportes.TabIndex = 10;
            this.btn_Cerrar_ExportarReportes.TabStop = false;
            this.btn_Cerrar_ExportarReportes.Click += new System.EventHandler(this.btn_Cerrar_ExportarReportes_Click);
            // 
            // txt_AñoReporte
            // 
            this.txt_AñoReporte.BackColor = System.Drawing.Color.LightBlue;
            this.txt_AñoReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AñoReporte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_AñoReporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_AñoReporte.Location = new System.Drawing.Point(45, 201);
            this.txt_AñoReporte.Multiline = true;
            this.txt_AñoReporte.Name = "txt_AñoReporte";
            this.txt_AñoReporte.Size = new System.Drawing.Size(84, 30);
            this.txt_AñoReporte.TabIndex = 44;
            this.txt_AñoReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(193, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 21);
            this.label1.TabIndex = 46;
            this.label1.Text = "Tipo de periodo:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(65, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 21);
            this.label3.TabIndex = 48;
            this.label3.Text = "Año:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label4.Location = new System.Drawing.Point(235, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 21);
            this.label4.TabIndex = 49;
            this.label4.Text = "Mes:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label5.Location = new System.Drawing.Point(409, 167);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(79, 21);
            this.label5.TabIndex = 50;
            this.label5.Text = "Semana:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label6.Location = new System.Drawing.Point(65, 265);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(153, 21);
            this.label6.TabIndex = 51;
            this.label6.Text = "Fecha del reporte:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(409, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 21);
            this.label7.TabIndex = 52;
            this.label7.Text = "Formato:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(218, 355);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 21);
            this.label9.TabIndex = 53;
            this.label9.Text = "Ruta archivo:";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label11.Location = new System.Drawing.Point(313, 265);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 21);
            this.label11.TabIndex = 54;
            this.label11.Text = "Generado por:";
            // 
            // btn_ExportarReporte
            // 
            this.btn_ExportarReporte.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ExportarReporte.FlatAppearance.BorderColor = System.Drawing.Color.DeepSkyBlue;
            this.btn_ExportarReporte.FlatAppearance.BorderSize = 0;
            this.btn_ExportarReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarReporte.Font = new System.Drawing.Font("Futura Md BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ExportarReporte.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ExportarReporte.Location = new System.Drawing.Point(213, 448);
            this.btn_ExportarReporte.Name = "btn_ExportarReporte";
            this.btn_ExportarReporte.Size = new System.Drawing.Size(128, 32);
            this.btn_ExportarReporte.TabIndex = 55;
            this.btn_ExportarReporte.Text = "Exportar";
            this.btn_ExportarReporte.UseVisualStyleBackColor = false;
            this.btn_ExportarReporte.Click += new System.EventHandler(this.btn_ExportarReporte_Click);
            // 
            // ckb_ReportePagos
            // 
            this.ckb_ReportePagos.AutoSize = true;
            this.ckb_ReportePagos.FlatAppearance.BorderSize = 0;
            this.ckb_ReportePagos.ForeColor = System.Drawing.Color.LightBlue;
            this.ckb_ReportePagos.Location = new System.Drawing.Point(453, 112);
            this.ckb_ReportePagos.Name = "ckb_ReportePagos";
            this.ckb_ReportePagos.Size = new System.Drawing.Size(47, 17);
            this.ckb_ReportePagos.TabIndex = 57;
            this.ckb_ReportePagos.Text = "PDF";
            this.ckb_ReportePagos.UseVisualStyleBackColor = true;
            // 
            // ckb_ReporteAgenda
            // 
            this.ckb_ReporteAgenda.AutoSize = true;
            this.ckb_ReporteAgenda.FlatAppearance.BorderSize = 0;
            this.ckb_ReporteAgenda.ForeColor = System.Drawing.Color.LightBlue;
            this.ckb_ReporteAgenda.Location = new System.Drawing.Point(384, 112);
            this.ckb_ReporteAgenda.Name = "ckb_ReporteAgenda";
            this.ckb_ReporteAgenda.Size = new System.Drawing.Size(54, 17);
            this.ckb_ReporteAgenda.TabIndex = 56;
            this.ckb_ReporteAgenda.Text = "Excell";
            this.ckb_ReporteAgenda.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(23, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(133, 21);
            this.label10.TabIndex = 45;
            this.label10.Text = "Tipo de reporte:";
            // 
            // cbx_Tipo_Periodo
            // 
            this.cbx_Tipo_Periodo.BackColor = System.Drawing.Color.LightBlue;
            this.cbx_Tipo_Periodo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_Tipo_Periodo.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbx_Tipo_Periodo.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbx_Tipo_Periodo.FormattingEnabled = true;
            this.cbx_Tipo_Periodo.Items.AddRange(new object[] {
            "Agenda-semanal ",
            "Agenda-mensual",
            "Pagos-mensual ",
            "Pagos-Anual"});
            this.cbx_Tipo_Periodo.Location = new System.Drawing.Point(182, 104);
            this.cbx_Tipo_Periodo.Name = "cbx_Tipo_Periodo";
            this.cbx_Tipo_Periodo.Size = new System.Drawing.Size(161, 29);
            this.cbx_Tipo_Periodo.TabIndex = 58;
            // 
            // cbx_MesReporte
            // 
            this.cbx_MesReporte.BackColor = System.Drawing.Color.LightBlue;
            this.cbx_MesReporte.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbx_MesReporte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.cbx_MesReporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.cbx_MesReporte.FormattingEnabled = true;
            this.cbx_MesReporte.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbx_MesReporte.Location = new System.Drawing.Point(197, 202);
            this.cbx_MesReporte.Name = "cbx_MesReporte";
            this.cbx_MesReporte.Size = new System.Drawing.Size(138, 29);
            this.cbx_MesReporte.TabIndex = 60;
            // 
            // txt_SemanaReporte
            // 
            this.txt_SemanaReporte.BackColor = System.Drawing.Color.LightBlue;
            this.txt_SemanaReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_SemanaReporte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_SemanaReporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_SemanaReporte.Location = new System.Drawing.Point(404, 200);
            this.txt_SemanaReporte.Multiline = true;
            this.txt_SemanaReporte.Name = "txt_SemanaReporte";
            this.txt_SemanaReporte.Size = new System.Drawing.Size(97, 30);
            this.txt_SemanaReporte.TabIndex = 61;
            this.txt_SemanaReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dtp_FechaReporte
            // 
            this.dtp_FechaReporte.Location = new System.Drawing.Point(43, 302);
            this.dtp_FechaReporte.Name = "dtp_FechaReporte";
            this.dtp_FechaReporte.Size = new System.Drawing.Size(200, 20);
            this.dtp_FechaReporte.TabIndex = 62;
            // 
            // txt_AutorReporte
            // 
            this.txt_AutorReporte.BackColor = System.Drawing.Color.LightBlue;
            this.txt_AutorReporte.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txt_AutorReporte.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.txt_AutorReporte.ForeColor = System.Drawing.Color.MidnightBlue;
            this.txt_AutorReporte.Location = new System.Drawing.Point(296, 302);
            this.txt_AutorReporte.Multiline = true;
            this.txt_AutorReporte.Name = "txt_AutorReporte";
            this.txt_AutorReporte.Size = new System.Drawing.Size(167, 30);
            this.txt_AutorReporte.TabIndex = 64;
            this.txt_AutorReporte.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btn_Ruta_Archivo
            // 
            this.btn_Ruta_Archivo.BackColor = System.Drawing.Color.DimGray;
            this.btn_Ruta_Archivo.FlatAppearance.BorderSize = 0;
            this.btn_Ruta_Archivo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Ruta_Archivo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Ruta_Archivo.Image = global::FISCLINGEST.Properties.Resources.Icon_Exportar_Reporte;
            this.btn_Ruta_Archivo.Location = new System.Drawing.Point(255, 391);
            this.btn_Ruta_Archivo.Name = "btn_Ruta_Archivo";
            this.btn_Ruta_Archivo.Size = new System.Drawing.Size(35, 40);
            this.btn_Ruta_Archivo.TabIndex = 63;
            this.btn_Ruta_Archivo.UseVisualStyleBackColor = false;
            this.btn_Ruta_Archivo.Click += new System.EventHandler(this.btn_Ruta_Archivo_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.ForeColor = System.Drawing.Color.SkyBlue;
            this.radioButton1.Location = new System.Drawing.Point(24, 116);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(62, 17);
            this.radioButton1.TabIndex = 65;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Agenda";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ForeColor = System.Drawing.Color.LightBlue;
            this.radioButton2.Location = new System.Drawing.Point(101, 116);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(55, 17);
            this.radioButton2.TabIndex = 66;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Pagos";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Exportar_Reportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(540, 500);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.txt_AutorReporte);
            this.Controls.Add(this.btn_Ruta_Archivo);
            this.Controls.Add(this.dtp_FechaReporte);
            this.Controls.Add(this.txt_SemanaReporte);
            this.Controls.Add(this.cbx_MesReporte);
            this.Controls.Add(this.cbx_Tipo_Periodo);
            this.Controls.Add(this.ckb_ReportePagos);
            this.Controls.Add(this.ckb_ReporteAgenda);
            this.Controls.Add(this.btn_ExportarReporte);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txt_AñoReporte);
            this.Controls.Add(this.panel_TituloExportarReporte);
            this.ForeColor = System.Drawing.Color.MidnightBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Exportar_Reportes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exportar_Reportes";
            this.Load += new System.EventHandler(this.Exportar_Reportes_Load);
            this.panel_TituloExportarReporte.ResumeLayout(false);
            this.panel_TituloExportarReporte.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_Cerrar_ExportarReportes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_TituloExportarReporte;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox btn_Cerrar_ExportarReportes;
        private System.Windows.Forms.TextBox txt_AñoReporte;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btn_ExportarReporte;
        private System.Windows.Forms.CheckBox ckb_ReportePagos;
        private System.Windows.Forms.CheckBox ckb_ReporteAgenda;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cbx_Tipo_Periodo;
        private System.Windows.Forms.ComboBox cbx_MesReporte;
        private System.Windows.Forms.TextBox txt_SemanaReporte;
        private System.Windows.Forms.DateTimePicker dtp_FechaReporte;
        private System.Windows.Forms.Button btn_Ruta_Archivo;
        private System.Windows.Forms.TextBox txt_AutorReporte;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}