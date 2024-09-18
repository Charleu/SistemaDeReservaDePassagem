using System;

namespace SistemaDeReservaDePassagem
{
    public class Executiva : PassagemAerea
    {
        public Executiva(string origem, string destino, DateTime data, int quantidade, double preco)
            : base(origem, destino, data, quantidade, preco) { }

        public override double CalcularPreco()
        {
            return base.CalcularPreco() * 1.3;  
        }
    }
}
