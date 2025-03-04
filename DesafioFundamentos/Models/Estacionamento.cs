namespace DesafioFundamentos.Models
{
    public class Estacionamento
    {
        public decimal precoInicial = 0;
        public decimal precoPorHora = 0;
        public List<string> veiculos = new List<string>();

        public void AdicionarVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para estacionar:");
            string placa = Console.ReadLine();
            veiculos.Add(placa);
        }

        public void RemoverVeiculo()
        {
            Console.WriteLine("Digite a placa do veículo para remover:");
            string placa = Console.ReadLine();

        
            if (veiculos.Any(x => x.ToUpper() == placa.ToUpper()))
            {
                Console.WriteLine("Digite a quantidade de horas que o veículo permaneceu estacionado:");
                int horas = Convert.ToInt32(Console.ReadLine());
                decimal valorTotal = precoInicial + precoPorHora * horas;
                veiculos.Remove(placa);

                Console.WriteLine($"O veículo {placa} foi removido e o preço total foi de: R$ {valorTotal}");
            }
            else
            {
                Console.WriteLine("Desculpe, esse veículo não está estacionado aqui. Confira se digitou a placa corretamente");
            }
        }

        public void ListarVeiculos()
        {
            // Verifica se há veículos no estacionamento
            if (veiculos.Any())
            {
                Console.WriteLine("Os veículos estacionados são:");
                foreach (var veiculo in veiculos)
                {
                    Console.WriteLine(veiculo);
                }
            }
            else
            {
                Console.WriteLine("Não há veículos estacionados.");
            }
        }

        public void AtualizarPlaca()
        {
            Console.WriteLine("Digite a placa que será atualizada");
            string placaatual = Console.ReadLine();

            if (veiculos.Contains(placaatual))
            {
                Console.WriteLine("Digite a nova placa");
                string novaPlaca = Console.ReadLine();

                int index = veiculos.IndexOf(placaatual);
                veiculos[index] = novaPlaca;

                Console.WriteLine("Placa atualizada com sucesso");
            }
            else
            {
                Console.WriteLine("Placa inválida. A placa não existe na lista.");
            }
        }
    }
}
