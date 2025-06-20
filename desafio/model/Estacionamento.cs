using System.Globalization;
using System.Text.RegularExpressions;

namespace Projeto1.Model
{
    public class Estacionamento
    {
        public List<Veiculo> veiculosEstacionados { get; set; } = new();

        public double valorHora { get; set; } = 3.0;

        public void adicionarVeiculo(Veiculo veiculo)
        {
            if (veiculosEstacionados.Any(v => v.placa.Equals(veiculo.placa, StringComparison.OrdinalIgnoreCase)))
            {
                Console.WriteLine("Veículo já está estacionado.");
            }
            else
            {
                veiculosEstacionados.Add(veiculo);
            }
        }

        public void listarVeiculos()
        {
            double valor = 0.0;
            foreach (Veiculo v in veiculosEstacionados)
            {
                valor = v.CalcularValor(valorHora);
                Console.WriteLine($"Placa: {v.placa.ToUpper()}, Data de Entrada: {v.dataEntrada}, Valor a Pagar: R$ {valor:F2}");
            }
        }

        public Veiculo? buscarVeiculoPorPlaca(string placa)
        {
            foreach (Veiculo v in veiculosEstacionados)
            {
                if (v.placa.Equals(placa, StringComparison.OrdinalIgnoreCase))
                {
                    v.dataSaida = DateTime.Now;

                    double valor = v.CalcularValor(valorHora);

                    Console.WriteLine($"Veículo encontrado:");
                    Console.WriteLine($"Placa: {v.placa.ToUpper()}");
                    Console.WriteLine($"Entrada: {v.dataEntrada}");
                    Console.WriteLine($"Saída: {v.dataSaida}");
                    Console.WriteLine($"Tempo: {v.CalcularTempoPermanencia().TotalMinutes:N0} minutos");
                    Console.WriteLine($"Valor a pagar: R$ {valor:F2}");
                    veiculosEstacionados.Remove(v);

                    return v;
                }
            }
            Console.WriteLine("Veículo não encontrado.");
            return null;
        }
        public void mudarValorHora()
        {
            Console.WriteLine($"\nValor da hora de estacionamento atual: R${valorHora}");
            Console.WriteLine("Digite o novo valor da hora de estacionamento (ex: 10.50):");
            string? novoValor = Console.ReadLine();
           if (Regex.IsMatch(novoValor, @"^\d+(\.\d+)?$"))
            {
                if (double.TryParse(novoValor, NumberStyles.Any, CultureInfo.InvariantCulture, out double valor))
                {
                    valorHora = valor;
                    Console.WriteLine($"\nValor da hora de estacionamento atualizado para R$ {valorHora:F2}");
                }
                else
                {
                    Console.WriteLine("Erro ao converter o valor.");
                }
            }
            else
            {
                Console.WriteLine("O valor deve ser um número positivo válido (ex: 10.50).");
            }
        }
    }
}
