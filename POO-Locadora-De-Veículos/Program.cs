using static System.Runtime.InteropServices.JavaScript.JSType;

namespace POO_Locadora_De_Veículos
{
    //• Cadastre pelo menos um veículo de cada tipo.
    //• Exiba o modelo, marca, ano e custo do aluguel para um determinado número de dias
    public class Program
    {
        static void Main()
        {
            Veiculo carro = new Carro
            {
                Modelo = "Fusca",
                Marca = "Volkswagen",
                Ano = 1968,
                ValorBaseDiario = 79
            };

            Veiculo moto = new Moto
            {
                Modelo = "Night Rod Special",
                Marca = "Harley Davidson",
                Ano = 2014,
                ValorBaseDiario = 49
            };

            Veiculo caminhao = new Caminhao
            {
                Modelo = "770 S V8",
                Marca = "Scania",
                Ano = 2025,
                ValorBaseDiario = 289
            };

            int dias = 5;

            ExibirInformacoesVeiculo(carro, dias);
            ExibirInformacoesVeiculo(moto, dias);
            ExibirInformacoesVeiculo(caminhao, dias);
        }

        static void ExibirInformacoesVeiculo(Veiculo veiculo, int dias)
        {
            Console.WriteLine($"Modelo: {veiculo.Modelo}");
            Console.WriteLine($"Marca: {veiculo.Marca}");
            Console.WriteLine($"Ano: {veiculo.Ano}");
            Console.WriteLine($"Valor da locação por {dias} dias: R${veiculo.CalcularAluguel(dias):F2}");
            Console.WriteLine();
        }
    }
}