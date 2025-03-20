using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_Locadora_De_Veículos
{
    //Herdam de Veiculo e sobrescrevem CalcularAluguel(int dias):
    //• Carro: custo do aluguel é valor base diário x dias.
    public class Carro : Veiculo
    {
        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiario * dias;
        }
    }
}
