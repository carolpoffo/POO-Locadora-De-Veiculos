using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace POO_Locadora_De_Veículos
{
    //Herdam de Veiculo e sobrescrevem CalcularAluguel(int dias):
    //• Moto: custo do aluguel tem um desconto de 10% sobre o total.
    public class Moto : Veiculo
    {
        public override double CalcularAluguel(int dias)
        {
            return ValorBaseDiario * dias;
        }
    }
}
