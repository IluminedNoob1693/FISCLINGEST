namespace FISCLINGEST
{
    partial class Pacientes
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
            this.btn_ListaEspera = new System.Windows.Forms.Button();
            this.btn_Directorio_Pacientes = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Swis721 Hv BT", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(245, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(484, 45);
            this.label1.TabIndex = 1;
            this.label1.Text = "MODULO DE PACIENTES";
            // 
            // btn_ListaEspera
            // 
            this.btn_ListaEspera.BackColor = System.Drawing.Color.Maroon;
            this.btn_ListaEspera.FlatAppearance.BorderSize = 0;
            this.btn_ListaEspera.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ListaEspera.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ListaEspera.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_ListaEspera.Image = global::FISCLINGEST.Properties.Resources.Lista_Espera;
            this.btn_ListaEspera.Location = new System.Drawing.Point(511, 165);
            this.btn_ListaEspera.Name = "btn_ListaEspera";
            this.btn_ListaEspera.Size = new System.Drawing.Size(256, 318);
            this.btn_ListaEspera.TabIndex = 3;
            this.btn_ListaEspera.Text = "Lista de espera";
            this.btn_ListaEspera.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_ListaEspera.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_ListaEspera.UseVisualStyleBackColor = false;
            this.btn_ListaEspera.Click += new System.EventHandler(this.btn_ListaEspera_Click);
            // 
            // btn_Directorio_Pacientes
            // 
            this.btn_Directorio_Pacientes.BackColor = System.Drawing.Color.Maroon;
            this.btn_Directorio_Pacientes.FlatAppearance.BorderSize = 0;
            this.btn_Directorio_Pacientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Directorio_Pacientes.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Directorio_Pacientes.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_Directorio_Pacientes.Image = global::FISCLINGEST.Properties.Resources.Directorio_pacientes;
            this.btn_Directorio_Pacientes.Location = new System.Drawing.Point(176, 162);
            this.btn_Directorio_Pacientes.Name = "btn_Directorio_Pacientes";
            this.btn_Directorio_Pacientes.Size = new System.Drawing.Size(256, 318);
            this.btn_Directorio_Pacientes.TabIndex = 2;
            this.btn_Directorio_Pacientes.Text = "Directorio de pacientes";
            this.btn_Directorio_Pacientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btn_Directorio_Pacientes.UseVisualStyleBackColor = false;
            this.btn_Directorio_Pacientes.Click += new System.EventHandler(this.btn_Directorio_Pacientes_Click);
            // 
            // Pacientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::FISCLINGEST.Properties.Resources.Icon_Cert_fisioterapia;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1034, 566);
            this.Controls.Add(this.btn_ListaEspera);
            this.Controls.Add(this.btn_Directorio_Pacientes);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Pacientes";
            this.Text = "Pacientes";
            this.Load += new System.EventHandler(this.Pacientes_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_Directorio_Pacientes;
        private System.Windows.Forms.Button btn_ListaEspera;
    }
}