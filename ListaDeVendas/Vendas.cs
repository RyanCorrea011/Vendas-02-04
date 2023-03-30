using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVendas
{
    public class Venda
    {
        public int Id { get; set; }
        public DateTime Data { get; set; }
        public List<Produto> Produtos { get; set; }

        public Venda(int id, DateTime data, List<Produto> produtos)
        {
            Id = id;
            Data = data;
            Produtos = produtos;
        }

        public void ImprimirVenda()
        {
            Console.WriteLine("Id da venda: " + Id);
            Console.WriteLine("Data da venda: " + Data);
            Console.WriteLine("Produtos comprados:");
            foreach (Produto produto in Produtos)
            {
                Console.WriteLine("- " +"Id do Produto  "+  produto.IdP +  "\n" + produto.Nome + " R$" + produto.Valor );
            }
        }
    }
}
