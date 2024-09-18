using System;

namespace SistemaDeReservaDePassagem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o nome do cliente: ");
            string nomeCliente = Console.ReadLine();

            Cliente cliente = new Cliente { Nome = nomeCliente };

            Economica Economica = new Economica("Recife", "Salvador", DateTime.Now.AddDays(7), 2, 300)
            {
                ClienteFrequente = true
            };
            Executiva Executiva = new Executiva("Belo Horizonte", "Miami", DateTime.Now.AddDays(14), 1, 1500);
            PrimeiraClasse PrimeiraClasse = new PrimeiraClasse("Brasília", "Tóquio", DateTime.Now.AddDays(21), 1, 2500);

            cliente.ReservarPassagem(Economica);
            cliente.ReservarPassagem(Executiva);
            cliente.ReservarPassagem(PrimeiraClasse);

            Console.WriteLine($"\nResumo das reservas do cliente: {cliente.Nome}");

            for (int i = 0; i < cliente.QuantidadeReservas; i++)
            {
                PassagemAerea reserva = cliente.Reservas[i];
                if (reserva != null)
                {
                    Console.WriteLine($"Tipo: {reserva.GetType().Name}\nOrigem: {reserva.Origem}\nDestino: {reserva.Destino}\nData: {reserva.Data.ToShortDateString()}\nPreço: {reserva.CalcularPreco().ToString("C")}");
                }
            }
            double totalReservas = cliente.CalcularTotalReservas();
            Console.WriteLine($"Total de reservas: {totalReservas.ToString("C")}");
        }
    }
}
