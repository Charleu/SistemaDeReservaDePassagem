using System;

namespace SistemaDeReservaDePassagem
{
    public class Economica : PassagemAerea
    {
        public bool ClienteFrequente { get; set; }

        public Economica(string origem, string destino, DateTime data, int quantidade, double preco)
            : base(origem, destino, data, quantidade, preco) { }

        public override double CalcularPreco()
        {
            double precoFinal = base.CalcularPreco();

            if (ClienteFrequente)
            {
                precoFinal *= 0.9;  
            }

            return precoFinal;
        }
    }
}
