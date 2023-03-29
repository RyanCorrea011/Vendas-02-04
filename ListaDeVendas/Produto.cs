using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVendas
{
    public class Produto
    {
        public decimal Valor { get; set; }
        public string Nome { get; set; }

        public Produto(decimal valor, string nome)
        {
            Valor = valor;
            Nome = nome;
        }

        public decimal GetValor()
        {
            return Valor;
        }

        public void SetValor(decimal valor)
        {
            Valor = valor;
        }

        public string GetNome()
        {
            return Nome;
        }

        public void SetNome(string nome)
        {
            Nome = nome;
        }
    }
}


