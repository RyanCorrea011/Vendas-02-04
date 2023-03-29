using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaDeVendas
{
    public class Vendas
    {
        public int Id { get; set; }
        public string Data { get; set; }


        public Vendas(int id, string data)
        {
            Id = id;
            Data = data;
        }

        public int GetId()
        {
            return Id;
        }

        public void SetId(int id)
        {
            Id = id;
        }

        public string GetData()
        {
            return Data;
        }

        public void SetData(string data)
        {
            Data = data;
        }
    }
}
