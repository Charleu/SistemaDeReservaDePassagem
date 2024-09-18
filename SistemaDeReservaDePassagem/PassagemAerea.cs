using System;

namespace SistemaDeReservaDePassagem
{
    public class PassagemAerea
    {
        public string Origem { get; set; }
        public string Destino { get; set; }
        public DateTime Data { get; set; }  
        public int Quantidades { get; set; }
        public double Preco { get; set; }

        public PassagemAerea(string origem, string destino, DateTime data, int quantidade, double preco)
        {
            Origem = origem;
            Destino = destino;
            Data = data;
            Quantidades = quantidade;
            Preco = preco;
        }

        public virtual double CalcularPreco() => Preco * Quantidades;
    }
}
