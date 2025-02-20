using Bowling_Sim.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bowling_Sim
{
    public partial class Inicio : Form
    {
        public List<SimulacionResultado> simulaciones { get; set; }
        public Inicio()
        {
            simulaciones = new List<SimulacionResultado>();
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            var simulacion = new Simulacion(this);
            simulacion.Show();
        }
        public void CargarGrilla(SimulacionResultado simulacion)
        {
            //Obtener el índice de la última fila de datos, y agregar una nueva fila
            int ultimaFila = dgvSimulaciones.Rows.Add();

            dgvSimulaciones.Rows[ultimaFila].Cells["simulacion"].Value = ultimaFila + 1;
            dgvSimulaciones.Rows[ultimaFila].Cells["rondas"].Value = simulacion.rondas;
            dgvSimulaciones.Rows[ultimaFila].Cells["puntaje"].Value = simulacion.puntajeEsperado;

            dgvSimulaciones.Rows[ultimaFila].Cells["exitosMin3Pinos"].Value = simulacion.exitosMin3Pinos;
            dgvSimulaciones.Rows[ultimaFila].Cells["exitosMin4Pinos"].Value = simulacion.exitosMin4Pinos;

            dgvSimulaciones.Rows[ultimaFila].Cells["probabilidadMin3Pinos"].Value = simulacion.CalcularProbabilidadExitoMin3Pinos().ToString("P");
            dgvSimulaciones.Rows[ultimaFila].Cells["probabilidadMin4Pinos"].Value = simulacion.CalcularProbabilidadExitoMin4Pinoss().ToString("P");  
            
            dgvSimulaciones.Rows[ultimaFila].Cells["puntajeTotalMin3Pinos"].Value = simulacion.puntajeTotalMin3pinos;
            dgvSimulaciones.Rows[ultimaFila].Cells["puntajeTotalMin4Pinos"].Value = simulacion.puntajeTotalMin4pinos;

            dgvSimulaciones.Rows[ultimaFila].Cells["mediaMin3Pinos"].Value = simulacion.CalcularMediaMin3pinos();
            dgvSimulaciones.Rows[ultimaFila].Cells["mediaMin4Pinos"].Value = simulacion.CalcularMediaMin4pinos();

        }

        private void Inicio_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            dgvSimulaciones.Rows.Clear();
        }
    }
}
