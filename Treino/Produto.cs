using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TreinoLinq.Treino
{
    public class Produto
    {
        public string Nome { get; set; }
        public decimal Preco { get; set; }

        public Produto(string nome, decimal preco)
        {
            Nome = nome;
            Preco = preco;
        }
    }
}

/* Code: 

List<Produto> produtos = new List<Produto>
{
    new Produto ("Laptop", 1200 ),
    new Produto ( "Smartphone", 800),
    new Produto ("Tablet", 500 ),
    new Produto("Câmera", 300 )
};

var precoMedio = produtos.Average(p => p.Preco);
System.Console.WriteLine($"Preco médio dos produtos: {precoMedio}");

*/