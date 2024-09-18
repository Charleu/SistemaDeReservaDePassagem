using System;

namespace SistemaDeReservaDePassagem
{
    public class Cliente
    {
        public string Nome { get; set; }
        public PassagemAerea[] Reservas { get; set; } = new PassagemAerea[10];
        public int QuantidadeReservas { get; set; }

        public void ReservarPassagem(PassagemAerea passagem)
        {
            if (QuantidadeReservas < Reservas.Length)
            {
                Reservas[QuantidadeReservas] = passagem;
                QuantidadeReservas++;
            }
            else
            {
                Console.WriteLine("Quantidade de passagem máxima atingida.");
            }
        }

        public double CalcularTotalReservas()
        {
            double total = 0;
            for (int i = 0; i < QuantidadeReservas; i++)
            {
                total += Reservas[i].CalcularPreco();
            }
            return total;
        }
    }
}
