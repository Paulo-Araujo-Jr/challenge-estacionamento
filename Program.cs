using System.Text.RegularExpressions;
using Projeto1.Model;

Estacionamento estacionamento = new();   
                     
Console.Clear();
Console.WriteLine("      ,-----,");
await Task.Delay(500);
Console.WriteLine("   ,--'---:---`--,");
await Task.Delay(500);
Console.WriteLine("  ==(o)-----(o)==J ");
await Task.Delay(500); 
Console.WriteLine(" `````````````````````````````");
await Task.Delay(3500);
           
string opcao = "";

while (opcao != "5")
{
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("         ESTACIONAMENTO DE VEÍCULOS");
    Console.WriteLine("----------------------------------------------");
    Console.WriteLine("Digite [1] Para estacionar um veículo");
    Console.WriteLine("Digite [2] Para listar os veículos estacoinados");
    Console.WriteLine("Digite [3] Buscar débito de veículo por placa");
    Console.WriteLine("Digite [4] Para mudar o valor da hora de estacionamento");
    Console.WriteLine("Digite [5] Para sair");
    Console.WriteLine("----------------------------------------------");
    Console.Write("\nEscolha uma opção: ");


    opcao = Console.ReadLine();

    switch (opcao)
    {
        case "1":
            Console.WriteLine("Digite a placa do veículo");
            Console.WriteLine("Formato: ABC-1234 ou ABC1A23:");
            string? placa = Console.ReadLine();

            if (
                    !string.IsNullOrWhiteSpace(placa) &&
                    Regex.IsMatch(placa, @"^[A-Z]{3}-\d{4}$", RegexOptions.IgnoreCase) ||
                    Regex.IsMatch(placa, @"^[A-Z]{3}\d[A-Z]\d{2}$", RegexOptions.IgnoreCase)
                )
            {
                Veiculo veiculo = new(placa);
                estacionamento.adicionarVeiculo(veiculo);
                Console.WriteLine("Veículo cadastrado com sucesso!");
            }
            else
            {
                Console.WriteLine("Placa inválida. O formato deve ser ABC-1234 ou ABC1A23.");
            }

            await Task.Delay(5000);
            break;

        case "2":
            Console.WriteLine("Listando veículos estacionados\n");
            estacionamento.listarVeiculos();
            Console.WriteLine("\nPressione [Enter] para continuar.");
            Console.ReadLine();
            break;

        case "3":
            Console.WriteLine("Digite a placa do veículo que deseja consultar:");
            string? placaConsulta = Console.ReadLine();

            if (!string.IsNullOrWhiteSpace(placaConsulta))
            {
                Veiculo? v = estacionamento.buscarVeiculoPorPlaca(placaConsulta);
                if (v == null)
                {
                    Console.WriteLine($"Veículo não encontrado com a placa: {placaConsulta}");
                }
            }
            Console.WriteLine("Pressione [Enter] para continuar.");
            Console.ReadLine();
            break;

        case "4":
            estacionamento.mudarValorHora();
            Console.WriteLine("Pressione [Enter] para continuar.");
            Console.ReadLine();
            break;

        default:
            Console.WriteLine("Opção inválida. Tente novamente.");
            break;
    }

    Console.Clear();
}
 
Console.WriteLine("    ____");
Console.WriteLine(" T_/_|  |_");
Console.WriteLine("(  _     _``-.");
Console.WriteLine("'-(_)---(_)--'");
Console.WriteLine(" `````````````````````````````");
Console.WriteLine("Obrigado por utilizar o sistema de estacionamento!");
await Task.Delay(1000);
Console.Write("Encerrando o programa");
await Task.Delay(500);
Console.Write(".");
await Task.Delay(500);
Console.Write(".");
await Task.Delay(200);
Console.Write(".");
await Task.Delay(500);
Console.Clear();
