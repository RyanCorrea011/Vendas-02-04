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
        public int IdP { get; set; }
        

        public Produto(decimal valor, string nome , int idP)
        {
            Valor = valor;
            Nome = nome;
            IdP = idP;
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

        public int GetIdP() {
            return IdP;
        }
        public void setIdP(int idP)
        {
            IdP = idP;
        }
    }
}


