namespace FISCLINGEST
{
    partial class Cuotas
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txt_BuscarCuotas = new System.Windows.Forms.TextBox();
            this.btn_ExportarReporteCuotas = new System.Windows.Forms.Button();
            this.btn_ConsultarCuota = new System.Windows.Forms.Button();
            this.btn_AnularCuota = new System.Windows.Forms.Button();
            this.btn_EditarCuota = new System.Windows.Forms.Button();
            this.btn_AgregarCuota = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(318, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(443, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROL DE CUOTAS";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(240, 142);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(589, 313);
            this.dataGridView1.TabIndex = 1;
            // 
            // txt_BuscarCuotas
            // 
            this.txt_BuscarCuotas.Location = new System.Drawing.Point(240, 109);
            this.txt_BuscarCuotas.Name = "txt_BuscarCuotas";
            this.txt_BuscarCuotas.Size = new System.Drawing.Size(548, 20);
            this.txt_BuscarCuotas.TabIndex = 7;
            // 
            // btn_ExportarReporteCuotas
            // 
            this.btn_ExportarReporteCuotas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_ExportarReporteCuotas.FlatAppearance.BorderSize = 0;
            this.btn_ExportarReporteCuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ExportarReporteCuotas.Image = global::FISCLINGEST.Properties.Resources.Icon_Exportar_Cuota;
            this.btn_ExportarReporteCuotas.Location = new System.Drawing.Point(588, 470);
            this.btn_ExportarReporteCuotas.Name = "btn_ExportarReporteCuotas";
            this.btn_ExportarReporteCuotas.Size = new System.Drawing.Size(50, 50);
            this.btn_ExportarReporteCuotas.TabIndex = 6;
            this.btn_ExportarReporteCuotas.UseVisualStyleBackColor = false;
            this.btn_ExportarReporteCuotas.Click += new System.EventHandler(this.btn_ExportarReporteCuotas_Click);
            // 
            // btn_ConsultarCuota
            // 
            this.btn_ConsultarCuota.BackColor = System.Drawing.Color.Maroon;
            this.btn_ConsultarCuota.FlatAppearance.BorderSize = 0;
            this.btn_ConsultarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ConsultarCuota.Image = global::FISCLINGEST.Properties.Resources.Icon_Buscar_Cuota1;
            this.btn_ConsultarCuota.Location = new System.Drawing.Point(794, 101);
            this.btn_ConsultarCuota.Name = "btn_ConsultarCuota";
            this.btn_ConsultarCuota.Size = new System.Drawing.Size(35, 35);
            this.btn_ConsultarCuota.TabIndex = 5;
            this.btn_ConsultarCuota.UseVisualStyleBackColor = false;
            this.btn_ConsultarCuota.Click += new System.EventHandler(this.btn_ConsultarCuota_Click);
            // 
            // btn_AnularCuota
            // 
            this.btn_AnularCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AnularCuota.FlatAppearance.BorderSize = 0;
            this.btn_AnularCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AnularCuota.Image = global::FISCLINGEST.Properties.Resources.Icon_Anular_Cuota;
            this.btn_AnularCuota.Location = new System.Drawing.Point(532, 470);
            this.btn_AnularCuota.Name = "btn_AnularCuota";
            this.btn_AnularCuota.Size = new System.Drawing.Size(50, 50);
            this.btn_AnularCuota.TabIndex = 4;
            this.btn_AnularCuota.UseVisualStyleBackColor = false;
            this.btn_AnularCuota.Click += new System.EventHandler(this.btn_AnularCuota_Click);
            // 
            // btn_EditarCuota
            // 
            this.btn_EditarCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_EditarCuota.FlatAppearance.BorderSize = 0;
            this.btn_EditarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_EditarCuota.Image = global::FISCLINGEST.Properties.Resources.Icon_Editar_Cuota;
            this.btn_EditarCuota.Location = new System.Drawing.Point(476, 470);
            this.btn_EditarCuota.Name = "btn_EditarCuota";
            this.btn_EditarCuota.Size = new System.Drawing.Size(50, 50);
            this.btn_EditarCuota.TabIndex = 3;
            this.btn_EditarCuota.UseVisualStyleBackColor = false;
            this.btn_EditarCuota.Click += new System.EventHandler(this.btn_EditarCuota_Click);
            // 
            // btn_AgregarCuota
            // 
            this.btn_AgregarCuota.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btn_AgregarCuota.FlatAppearance.BorderSize = 0;
            this.btn_AgregarCuota.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_AgregarCuota.Image = global::FISCLINGEST.Properties.Resources.Icon_Agregar_Cuota;
            this.btn_AgregarCuota.Location = new System.Drawing.Point(420, 470);
            this.btn_AgregarCuota.Name = "btn_AgregarCuota";
            this.btn_AgregarCuota.Size = new System.Drawing.Size(50, 50);
            this.btn_AgregarCuota.TabIndex = 2;
            this.btn_AgregarCuota.UseVisualStyleBackColor = false;
            this.btn_AgregarCuota.Click += new System.EventHandler(this.btn_AgregarCuota_Click);
            // 
            // Cuotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FISCLINGEST.Properties.Resources.Icon_Cert_fisioterapia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.txt_BuscarCuotas);
            this.Controls.Add(this.btn_ExportarReporteCuotas);
            this.Controls.Add(this.btn_ConsultarCuota);
            this.Controls.Add(this.btn_AnularCuota);
            this.Controls.Add(this.btn_EditarCuota);
            this.Controls.Add(this.btn_AgregarCuota);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Cuotas";
            this.Text = "Cuotas";
            this.Load += new System.EventHandler(this.Cuotas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btn_AgregarCuota;
        private System.Windows.Forms.Button btn_EditarCuota;
        private System.Windows.Forms.Button btn_AnularCuota;
        private System.Windows.Forms.Button btn_ConsultarCuota;
        private System.Windows.Forms.Button btn_ExportarReporteCuotas;
        private System.Windows.Forms.TextBox txt_BuscarCuotas;
    }
}