namespace Bowling_Sim
{
    partial class Inicio
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgvSimulaciones = new System.Windows.Forms.DataGridView();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.simulacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rondas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitosMIn3Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitosMIn4Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadMin3Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.probabilidadMin4Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeTotalMin3Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeTotalMin4Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaMin3Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.mediaMin4Pinos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(12, 12);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 9;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgvSimulaciones
            // 
            this.dgvSimulaciones.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvSimulaciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSimulaciones.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.simulacion,
            this.rondas,
            this.puntaje,
            this.exitosMIn3Pinos,
            this.exitosMIn4Pinos,
            this.probabilidadMin3Pinos,
            this.probabilidadMin4Pinos,
            this.puntajeTotalMin3Pinos,
            this.puntajeTotalMin4Pinos,
            this.mediaMin3Pinos,
            this.mediaMin4Pinos});
            this.dgvSimulaciones.Location = new System.Drawing.Point(12, 41);
            this.dgvSimulaciones.Name = "dgvSimulaciones";
            this.dgvSimulaciones.ReadOnly = true;
            this.dgvSimulaciones.Size = new System.Drawing.Size(1146, 195);
            this.dgvSimulaciones.TabIndex = 10;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(93, 12);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // simulacion
            // 
            this.simulacion.HeaderText = "Simulacion";
            this.simulacion.Name = "simulacion";
            this.simulacion.ReadOnly = true;
            // 
            // rondas
            // 
            this.rondas.HeaderText = "Rondas";
            this.rondas.Name = "rondas";
            this.rondas.ReadOnly = true;
            // 
            // puntaje
            // 
            this.puntaje.HeaderText = "Puntaje x*";
            this.puntaje.Name = "puntaje";
            this.puntaje.ReadOnly = true;
            // 
            // exitosMIn3Pinos
            // 
            this.exitosMIn3Pinos.HeaderText = "Cant. Puntaje>x* (Min. 3 pinos)";
            this.exitosMIn3Pinos.Name = "exitosMIn3Pinos";
            this.exitosMIn3Pinos.ReadOnly = true;
            // 
            // exitosMIn4Pinos
            // 
            this.exitosMIn4Pinos.HeaderText = "Cant. Puntaje>x* (Min. 4 pinos)";
            this.exitosMIn4Pinos.Name = "exitosMIn4Pinos";
            this.exitosMIn4Pinos.ReadOnly = true;
            // 
            // probabilidadMin3Pinos
            // 
            this.probabilidadMin3Pinos.HeaderText = "Pr(x>x*) (Min. 3 pinos)";
            this.probabilidadMin3Pinos.Name = "probabilidadMin3Pinos";
            this.probabilidadMin3Pinos.ReadOnly = true;
            // 
            // probabilidadMin4Pinos
            // 
            this.probabilidadMin4Pinos.HeaderText = "Pr(x>x*) (Min. 4 pinos)";
            this.probabilidadMin4Pinos.Name = "probabilidadMin4Pinos";
            this.probabilidadMin4Pinos.ReadOnly = true;
            // 
            // puntajeTotalMin3Pinos
            // 
            this.puntajeTotalMin3Pinos.HeaderText = "Puntaje Total Acumulado (Min. 3 Pinos)";
            this.puntajeTotalMin3Pinos.Name = "puntajeTotalMin3Pinos";
            this.puntajeTotalMin3Pinos.ReadOnly = true;
            // 
            // puntajeTotalMin4Pinos
            // 
            this.puntajeTotalMin4Pinos.HeaderText = "Puntaje Total Acumulado (Min. 4 Pinos)";
            this.puntajeTotalMin4Pinos.Name = "puntajeTotalMin4Pinos";
            this.puntajeTotalMin4Pinos.ReadOnly = true;
            // 
            // mediaMin3Pinos
            // 
            this.mediaMin3Pinos.HeaderText = "Media (Min. 3 Pinos)";
            this.mediaMin3Pinos.Name = "mediaMin3Pinos";
            this.mediaMin3Pinos.ReadOnly = true;
            // 
            // mediaMin4Pinos
            // 
            this.mediaMin4Pinos.HeaderText = "Media (Min. 4 pinos)";
            this.mediaMin4Pinos.Name = "mediaMin4Pinos";
            this.mediaMin4Pinos.ReadOnly = true;
            // 
            // Inicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1170, 248);
            this.Controls.Add(this.btnLimpiar);
            this.Controls.Add(this.dgvSimulaciones);
            this.Controls.Add(this.btnSimular);
            this.Name = "Inicio";
            this.Text = "Bowling";
            this.Load += new System.EventHandler(this.Inicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSimulaciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dgvSimulaciones;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.DataGridViewTextBoxColumn simulacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn rondas;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitosMIn3Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitosMIn4Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadMin3Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn probabilidadMin4Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeTotalMin3Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeTotalMin4Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaMin3Pinos;
        private System.Windows.Forms.DataGridViewTextBoxColumn mediaMin4Pinos;
    }
}

