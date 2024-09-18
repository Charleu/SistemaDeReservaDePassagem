using System;

namespace SistemaDeReservaDePassagem
{
    public class PrimeiraClasse : PassagemAerea
    {
        public PrimeiraClasse(string origem, string destino, DateTime data, int quantidade, double preco)
            : base(origem, destino, data, quantidade, preco) { }

        public override double CalcularPreco()
        {
            double precoFinal = base.CalcularPreco() * 1.5; 

            Console.WriteLine("\nServiço de bordo disponível.");
            Console.WriteLine("Assento preferencial.");

            return precoFinal;
        }
    }
}
