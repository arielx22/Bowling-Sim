using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bowling_Sim.Clases
{
    public class SimulacionResultado
    {
        public SimulacionResultado() { }
        public int rondas { get; set; }
        public int puntajeEsperado { get; set; }
        public int exitosMin3Pinos { get; set; }
        public int exitosMin4Pinos { get; set; }
        public double puntajeTotalMin3pinos { get; set; }
        public double puntajeTotalMin4pinos { get; set; }
        public double CalcularProbabilidadExitoMin3Pinos()
        {
            //Prob. de exitos (cada 10 rondas)
            return (double) this.exitosMin3Pinos / (this.rondas / 10);
        }
        public double CalcularProbabilidadExitoMin4Pinoss()
        {
            //Prob. de exitos (cada 10 rondas)
            return (double) this.exitosMin4Pinos / (this.rondas / 10);
        }
        public double CalcularMediaMin3pinos()
        {
            return (double) this.puntajeTotalMin3pinos / this.rondas;
        }
        public double CalcularMediaMin4pinos()
        {
            return (double) this.puntajeTotalMin3pinos / this.rondas;
        }

    }
}
