using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;


using Bowling_Sim.Clases;

namespace Bowling_Sim
{
    public partial class Simulacion : Form
    {
        private Inicio pantallaInicial;
        private SimulacionResultado simulacionResultado;
        private int desde;
        private int hasta;

        public Simulacion(Inicio pantallaInicial)
        {
            this.pantallaInicial = pantallaInicial;

            InitializeComponent();
        }

        private void btnSimular_Click(object sender, EventArgs e)
        {
            if (!ValidarCampos())
            {
                MessageBox.Show("Por favor, complete todos los campos con valores mayores a 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                dgvRondas.Rows.Clear();

                simulacionResultado = new SimulacionResultado();
                simulacionResultado.rondas = Convert.ToInt32(txtBoxRondas.Text);
                simulacionResultado.puntajeEsperado = Convert.ToInt32(txtBoxPuntajeMayor.Text);
                simulacionResultado.exitosMin3Pinos = 0;
                simulacionResultado.exitosMin4Pinos = 0;

                Random randomBola1 = new Random();
                Thread.Sleep(1);
                Random randomBola2 = new Random();

                int puntosAcumuladosMin3Pinos = 0;
                int puntosAcumuladosMin4Pinos = 0;

                //Obtener los valores de los TextBox para el rango
                desde = int.TryParse(txtBoxDesde.Text, out int d) ? d : 0;
                //Si no se proporciona hasta, se establece como desde + 500
                hasta = int.TryParse(txtBoxHasta.Text, out int h) ? h : (desde + 500);

                //Si hasta se proporciona pero desde no, se calcula desde como hasta - 500
                if (hasta > 0 && txtBoxDesde.Text.Trim() == "")
                {
                    if (hasta > 500) desde = hasta - 500;
                    else desde = 0;
                }

                // Validar que 'desde' sea menor que 'hasta'
                if (desde >= hasta)
                {
                    MessageBox.Show("El valor 'Desde' debe ser menor que el valor 'Hasta'.", "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return; 
                }

                //rango permitido (0-1000)
                if (hasta - desde > 1000)
                {
                    MessageBox.Show("El rango permitido entre 'Desde' y 'Hasta' no puede ser mayor a 1000.", "Error de Rango", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                for (int ronda = 0; ronda < simulacionResultado.rondas; ronda++)
                {
                    (puntosAcumuladosMin3Pinos, puntosAcumuladosMin4Pinos) =
                        SimularRonda(ronda, randomBola1, randomBola2, puntosAcumuladosMin3Pinos, puntosAcumuladosMin4Pinos);
                }
                pantallaInicial.CargarGrilla(simulacionResultado);
            }
        }

        private bool ValidarCampos()
        {
            //Verifica que los TextBox no estén vacíos
            if (string.IsNullOrWhiteSpace(txtBoxRondas.Text) ||
                string.IsNullOrWhiteSpace(txtBoxPuntajeMayor.Text))
            {
                return false;
            }

            //Verifica que los valores sean números positivos
            if (!int.TryParse(txtBoxRondas.Text, out int rondas) || rondas <= 0 ||
                !int.TryParse(txtBoxPuntajeMayor.Text, out int puntaje) || puntaje <= 0) 
            {
                return false;
            }
            return true;
        }

        public (int, int) SimularRonda(int ronda, Random randomBola1, Random randomBola2,
            int puntosAcumuladosMin3Pinos, int puntosAcumuladosMin4Pinos)
        {
            int ultimaFila = 0;
            int numRonda = ronda + 1;
            if (numRonda >= desde && numRonda <= hasta)
            {
                //Obtener el índice de la última fila de datos, y agregar una nueva fila
                ultimaFila = dgvRondas.Rows.Add();
                //cargo en la grilla la ronda
                dgvRondas.Rows[ultimaFila].Cells["ronda"].Value = numRonda;
            }
            double rndBola1 = Math.Round(randomBola1.NextDouble() * 0.99, 2);
            cargarDatoRonda("rndBola1", numRonda, rndBola1.ToString(), ultimaFila);
        
            int bola1CantPinosMin3 = GetBola1CantidadPinos(rndBola1, "min3");
            int bola1CantPinosMin4 = GetBola1CantidadPinos(rndBola1, "min4");

            cargarDatoRonda("bola1CantidadPinosMin3", numRonda, bola1CantPinosMin3.ToString(), ultimaFila);
            cargarDatoRonda("bola1CantidadPinosMin4", numRonda, bola1CantPinosMin4.ToString(), ultimaFila);

            int totalPuntosMin3 = 0;
            int totalPuntosMin4 = 0;
            //Si bola1CantPinosMin3 = 10 entonces bola1CantPinosMin4 = 10, con las probabilidades dadas por defecto
            if (bola1CantPinosMin3 != 10) {
                double rndBola2 = Math.Round(randomBola2.NextDouble() * 0.99, 2);
                cargarDatoRonda("rndBola2", numRonda, rndBola2.ToString(), ultimaFila);

                totalPuntosMin3 = CalcularPuntosBola(bola1CantPinosMin3, rndBola2, 
                    "bola2CantidadPinosMin3", numRonda, ultimaFila);

                if (bola1CantPinosMin4 != 10)
                    totalPuntosMin4 = CalcularPuntosBola(bola1CantPinosMin4, rndBola2, 
                        "bola2CantidadPinosMin4", numRonda, ultimaFila);
                else totalPuntosMin4 = 20; //chuza
            }
            else
            {
                //chuza
                totalPuntosMin3 = 20;
                totalPuntosMin4 = 20;
            }

            cargarDatoRonda("totalPuntosMin3", numRonda, totalPuntosMin3.ToString(), ultimaFila);
            cargarDatoRonda("totalPuntosMin4", numRonda, totalPuntosMin4.ToString(), ultimaFila);

            if ((ronda + 1) % 10 == 1)
            {
                puntosAcumuladosMin3Pinos = 0;
                puntosAcumuladosMin4Pinos = 0;

            }
            puntosAcumuladosMin3Pinos += totalPuntosMin3;
            puntosAcumuladosMin4Pinos += totalPuntosMin4;

            cargarDatoRonda("totalPuntosAcumuladosMin3", numRonda, puntosAcumuladosMin3Pinos.ToString(), ultimaFila);
            cargarDatoRonda("totalPuntosAcumuladosMin4", numRonda, puntosAcumuladosMin4Pinos.ToString(), ultimaFila);

            determinarExito(numRonda, puntosAcumuladosMin3Pinos, puntosAcumuladosMin4Pinos);
            cargarDatoRonda("exitosMin3", numRonda, simulacionResultado.exitosMin3Pinos.ToString(), ultimaFila);
            cargarDatoRonda("exitosMin4", numRonda, simulacionResultado.exitosMin4Pinos.ToString(), ultimaFila);

            simulacionResultado.puntajeTotalMin3pinos += totalPuntosMin3;
            simulacionResultado.puntajeTotalMin4pinos += totalPuntosMin4;
            cargarDatoRonda("puntajeTotalAcumaladoMin3", numRonda, simulacionResultado.puntajeTotalMin3pinos.ToString(), ultimaFila);
            cargarDatoRonda("puntajeTotalAcumaladoMin4", numRonda, simulacionResultado.puntajeTotalMin4pinos.ToString(), ultimaFila);

            return (puntosAcumuladosMin3Pinos, puntosAcumuladosMin4Pinos);
        }
        public void cargarDatoRonda(string nombreColumna, int numRonda, string dato, int ultimaFila)
        {
            if (numRonda >= desde && numRonda <= hasta)
                dgvRondas.Rows[ultimaFila].Cells[$"{nombreColumna}"].Value = dato;
        }
        public int GetBola1CantidadPinos(double rndBola, string tipo)
        {
            // Limites de probabilidades que corresponden a los rangos de la Bola 1,
            // si es Min 3 o Min 4 pinos
            var limites = tipo == "min3" ? new[] { 0.04, 0.1, 0.18, 0.29, 0.43, 0.6, 0.83 }
                                          : new[] { 0.06, 0.14, 0.25, 0.39, 0.56, 0.79 };

            //creo una Lista con la cantidad de pinos, para min 3 pinos y si no para min 4 pinos
            var valoresPinos = tipo == "min3" ? new[] { 3, 4, 5, 6, 7, 8, 9, 10 }
                                              : new[] { 4, 5, 6, 7, 8, 9, 10 };

            // Por defecto es 10 si no cae en ninguno de los rangos anteriores
            int cantidadPinos = 10;

            for (int i = 0; i < limites.Length; i++)
            {
                if (rndBola <= limites[i])
                {
                    cantidadPinos = valoresPinos[i];
                    break;
                }
            }
            return cantidadPinos;
        }
        public int CalcularPuntosBola(int bola1CantPinos, double rndBola2, string dato, int numRonda, int ultimaFila)
        {
            int totalPuntos = 0;

            int bola2CantPinos = GetBola2CantPinos(rndBola2, bola1CantPinos);
            cargarDatoRonda(dato, numRonda, bola2CantPinos.ToString(), ultimaFila);

            int totalCantPinos = bola1CantPinos + bola2CantPinos;
            //Si no tiro los 10 pinos el total de puntos es = a la cantidad de pinos tirados, 
            //caso contrario vale 15.
            return totalPuntos = (totalCantPinos != 10) ? totalCantPinos : 15;           
        }
        public int GetBola2CantPinos(double rndBola2, int cantPinosBola1)
        {

            double[] limites = DeterminasLimites(cantPinosBola1);

            //El máximo número de pinos que puedo tirar en la segunda bola
            //Tambien Por defecto es 10 si no cae en ninguno de los rangos anteriores
            int cantidadPinosBola2 = 10 - cantPinosBola1;

            //Crear un arreglo con, con todas las posibilidades de pinos tirado para la 2da bola
            int[] valoresPinos = new int[cantidadPinosBola2 + 1];  
            for (int i = 0; i <= cantidadPinosBola2; i++)
            {
                valoresPinos[i] = i;
            }

            for (int i = 0; i < limites.Length; i++)
            {
                if (rndBola2 <= limites[i])
                {
                    cantidadPinosBola2 = valoresPinos[i];
                    break;
                }
            }
            return cantidadPinosBola2;
        }
        public double[] DeterminasLimites(int cantPinosBola1)
        {
            //Probabilidades para la 2da Bola, de acuerdo cuantos pinos se tiro en la 1ra Bola
            double[] limites;

            // Según los pinos tirados en la primera bola, seleccionamos el conjunto adecuado de límites
            switch (cantPinosBola1)
            {
                case 3:
                    limites = new[] { 0.03 , 0.1 , 0.2 , 0.35 , 0.55 , 0.8 , 0.9 };
                    break;
                case 4:
                    limites = new[] { 0.08 , 0.17 , 0.28 , 0.43 , 0.63 , 0.83 };
                    break;
                case 5:
                    limites = new[] { 0.03 , 0.1 , 0.2 , 0.4 , 0.55 , 0.8 };
                    break;
                case 6:
                    limites = new[] { 0, 0.04 , 0.2 , 0.7 };
                    break;
                case 7:
                    limites = new[] { 0.02 , 0.12 , 0.57 };
                    break;
                case 8:
                    limites = new[] { 0.04 , 0.24 };
                    break;
                case 9:
                    limites = new[] { 0.06 };
                    break;
                default:
                    throw new ArgumentOutOfRangeException("La cantidad de pinos en la primera bola debe estar entre 3 y 9.");
            }
            return limites;
        }
        public void determinarExito(int numRonda, int puntosAcumuladosMin3Pinos, int puntosAcumuladosMin4Pinos)
        {
            if (numRonda % 10 == 0)
            {
                if (puntosAcumuladosMin3Pinos > simulacionResultado.puntajeEsperado)
                    simulacionResultado.exitosMin3Pinos += 1;

                if (puntosAcumuladosMin4Pinos > simulacionResultado.puntajeEsperado)
                    simulacionResultado.exitosMin4Pinos += 1;
            }
        }
        private void txtBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Permitir solo números y la tecla de retroceso
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si no es un número
            }
            // Permitir solo hasta 6 dígitos
            TextBox textBox = sender as TextBox;
            if (textBox != null && textBox.Text.Length >= 6 && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Cancelar el evento si se alcanza el límite de 6 dígitos
            }
        }

        private void dgvRondas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            



        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}


