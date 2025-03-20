using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Locadora_De_Veículos
{
    // classe base Veiculo que implementa IVeiculo e contém:
          //• Modelo
          //• Marca
          //• Ano
          //• Valor base diário do aluguel
          //• Método CalcularAluguel(int dias) (será sobrescrito pelas classes filhas).
    public abstract class Veiculo : IVeiculo
    {
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public int Ano { get; set; }
        public double ValorBaseDiario { get; set; }

        public abstract double CalcularAluguel(int dias);
    }
}
