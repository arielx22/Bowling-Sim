namespace Bowling_Sim
{
    partial class Simulacion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxHasta = new System.Windows.Forms.TextBox();
            this.txtBoxDesde = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPuntajeMayor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxRondas = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSimular = new System.Windows.Forms.Button();
            this.dgvRondas = new System.Windows.Forms.DataGridView();
            this.ronda = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndBola1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bola1CantidadPinosMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bola1CantidadPinosMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rndBola2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bola2CantidadPinosMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bola2CantidadPinosMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPuntosMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPuntosMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPuntosAcumuladosMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalPuntosAcumuladosMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitosMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.exitosMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeTotalAcumaladoMin3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.puntajeTotalAcumaladoMin4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRondas)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtBoxHasta);
            this.groupBox1.Controls.Add(this.txtBoxDesde);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxPuntajeMayor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxRondas);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(350, 90);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parametros";
            // 
            // txtBoxHasta
            // 
            this.txtBoxHasta.Location = new System.Drawing.Point(258, 55);
            this.txtBoxHasta.Name = "txtBoxHasta";
            this.txtBoxHasta.Size = new System.Drawing.Size(77, 20);
            this.txtBoxHasta.TabIndex = 9;
            this.txtBoxHasta.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // txtBoxDesde
            // 
            this.txtBoxDesde.Location = new System.Drawing.Point(79, 55);
            this.txtBoxDesde.Name = "txtBoxDesde";
            this.txtBoxDesde.Size = new System.Drawing.Size(77, 20);
            this.txtBoxDesde.TabIndex = 8;
            this.txtBoxDesde.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(214, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Hasta:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(32, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Desde:";
            // 
            // txtBoxPuntajeMayor
            // 
            this.txtBoxPuntajeMayor.Location = new System.Drawing.Point(258, 23);
            this.txtBoxPuntajeMayor.Name = "txtBoxPuntajeMayor";
            this.txtBoxPuntajeMayor.Size = new System.Drawing.Size(77, 20);
            this.txtBoxPuntajeMayor.TabIndex = 5;
            this.txtBoxPuntajeMayor.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(165, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Puntaje Mayor a:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBoxRondas
            // 
            this.txtBoxRondas.Location = new System.Drawing.Point(79, 23);
            this.txtBoxRondas.Name = "txtBoxRondas";
            this.txtBoxRondas.Size = new System.Drawing.Size(77, 20);
            this.txtBoxRondas.TabIndex = 3;
            this.txtBoxRondas.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtBox_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(26, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rondas:";
            // 
            // btnSimular
            // 
            this.btnSimular.Location = new System.Drawing.Point(368, 70);
            this.btnSimular.Name = "btnSimular";
            this.btnSimular.Size = new System.Drawing.Size(75, 23);
            this.btnSimular.TabIndex = 7;
            this.btnSimular.Text = "Simular";
            this.btnSimular.UseVisualStyleBackColor = true;
            this.btnSimular.Click += new System.EventHandler(this.btnSimular_Click);
            // 
            // dgvRondas
            // 
            this.dgvRondas.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvRondas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRondas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ronda,
            this.rndBola1,
            this.bola1CantidadPinosMin3,
            this.bola1CantidadPinosMin4,
            this.rndBola2,
            this.bola2CantidadPinosMin3,
            this.bola2CantidadPinosMin4,
            this.totalPuntosMin3,
            this.totalPuntosMin4,
            this.totalPuntosAcumuladosMin3,
            this.totalPuntosAcumuladosMin4,
            this.exitosMin3,
            this.exitosMin4,
            this.puntajeTotalAcumaladoMin3,
            this.puntajeTotalAcumaladoMin4});
            this.dgvRondas.Location = new System.Drawing.Point(12, 130);
            this.dgvRondas.Name = "dgvRondas";
            this.dgvRondas.ReadOnly = true;
            this.dgvRondas.Size = new System.Drawing.Size(1545, 377);
            this.dgvRondas.TabIndex = 8;
            this.dgvRondas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRondas_CellContentClick);
            // 
            // ronda
            // 
            this.ronda.HeaderText = "Ronda";
            this.ronda.Name = "ronda";
            this.ronda.ReadOnly = true;
            // 
            // rndBola1
            // 
            this.rndBola1.HeaderText = "RND 1ra Bola";
            this.rndBola1.Name = "rndBola1";
            this.rndBola1.ReadOnly = true;
            // 
            // bola1CantidadPinosMin3
            // 
            this.bola1CantidadPinosMin3.HeaderText = "1ra Bola Cant. Pinos (Min. 3 Pinos)";
            this.bola1CantidadPinosMin3.Name = "bola1CantidadPinosMin3";
            this.bola1CantidadPinosMin3.ReadOnly = true;
            // 
            // bola1CantidadPinosMin4
            // 
            this.bola1CantidadPinosMin4.HeaderText = "1ra Bola Cant. Pinos (Min. 4 Pinos)";
            this.bola1CantidadPinosMin4.Name = "bola1CantidadPinosMin4";
            this.bola1CantidadPinosMin4.ReadOnly = true;
            // 
            // rndBola2
            // 
            this.rndBola2.HeaderText = "RND 2da Bola";
            this.rndBola2.Name = "rndBola2";
            this.rndBola2.ReadOnly = true;
            // 
            // bola2CantidadPinosMin3
            // 
            this.bola2CantidadPinosMin3.HeaderText = "2da Bola Cant. Pinos (Min. 3 Pinos)";
            this.bola2CantidadPinosMin3.Name = "bola2CantidadPinosMin3";
            this.bola2CantidadPinosMin3.ReadOnly = true;
            // 
            // bola2CantidadPinosMin4
            // 
            this.bola2CantidadPinosMin4.HeaderText = "2da Bola Cant. Pinos (Min. 4 Pinos)";
            this.bola2CantidadPinosMin4.Name = "bola2CantidadPinosMin4";
            this.bola2CantidadPinosMin4.ReadOnly = true;
            // 
            // totalPuntosMin3
            // 
            this.totalPuntosMin3.HeaderText = "Total Puntos (Min. 3 Pinos)";
            this.totalPuntosMin3.Name = "totalPuntosMin3";
            this.totalPuntosMin3.ReadOnly = true;
            // 
            // totalPuntosMin4
            // 
            this.totalPuntosMin4.HeaderText = "Total Puntos (Min. 4 Pinos)";
            this.totalPuntosMin4.Name = "totalPuntosMin4";
            this.totalPuntosMin4.ReadOnly = true;
            // 
            // totalPuntosAcumuladosMin3
            // 
            this.totalPuntosAcumuladosMin3.HeaderText = "Total Puntos Acumulado 10 Rondas (Min. 3 Pinos) ";
            this.totalPuntosAcumuladosMin3.Name = "totalPuntosAcumuladosMin3";
            this.totalPuntosAcumuladosMin3.ReadOnly = true;
            // 
            // totalPuntosAcumuladosMin4
            // 
            this.totalPuntosAcumuladosMin4.HeaderText = "Total Puntos Acumulado 10 Rondas (Min. 4 Pinos)";
            this.totalPuntosAcumuladosMin4.Name = "totalPuntosAcumuladosMin4";
            this.totalPuntosAcumuladosMin4.ReadOnly = true;
            // 
            // exitosMin3
            // 
            this.exitosMin3.HeaderText = "Exitos (Min. 3 pinos)";
            this.exitosMin3.Name = "exitosMin3";
            this.exitosMin3.ReadOnly = true;
            // 
            // exitosMin4
            // 
            this.exitosMin4.HeaderText = "Exitos (Min. 4 pinos)";
            this.exitosMin4.Name = "exitosMin4";
            this.exitosMin4.ReadOnly = true;
            // 
            // puntajeTotalAcumaladoMin3
            // 
            this.puntajeTotalAcumaladoMin3.HeaderText = "Puntaje Total Acumalado (Min. 3 Pinos)";
            this.puntajeTotalAcumaladoMin3.Name = "puntajeTotalAcumaladoMin3";
            this.puntajeTotalAcumaladoMin3.ReadOnly = true;
            // 
            // puntajeTotalAcumaladoMin4
            // 
            this.puntajeTotalAcumaladoMin4.HeaderText = "Puntaje Total Acumalado (Min. 4 Pinos)";
            this.puntajeTotalAcumaladoMin4.Name = "puntajeTotalAcumaladoMin4";
            this.puntajeTotalAcumaladoMin4.ReadOnly = true;
            // 
            // Simulacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1569, 519);
            this.Controls.Add(this.dgvRondas);
            this.Controls.Add(this.btnSimular);
            this.Controls.Add(this.groupBox1);
            this.Name = "Simulacion";
            this.Text = "Simulacion";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRondas)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtBoxRondas;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSimular;
        private System.Windows.Forms.DataGridView dgvRondas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxPuntajeMayor;
        private System.Windows.Forms.TextBox txtBoxHasta;
        private System.Windows.Forms.TextBox txtBoxDesde;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ronda;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndBola1;
        private System.Windows.Forms.DataGridViewTextBoxColumn bola1CantidadPinosMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bola1CantidadPinosMin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn rndBola2;
        private System.Windows.Forms.DataGridViewTextBoxColumn bola2CantidadPinosMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn bola2CantidadPinosMin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPuntosMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPuntosMin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPuntosAcumuladosMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalPuntosAcumuladosMin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitosMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn exitosMin4;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeTotalAcumaladoMin3;
        private System.Windows.Forms.DataGridViewTextBoxColumn puntajeTotalAcumaladoMin4;
    }
}