using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Locadora_De_Veículos
{
    //Herdam de Veiculo e sobrescrevem CalcularAluguel(int dias):
    //• Caminhao: custo do aluguel tem um acréscimo de 20% sobre o total.
    public class Caminhao : Veiculo
    {
        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiario * dias;
        }
    }
}
