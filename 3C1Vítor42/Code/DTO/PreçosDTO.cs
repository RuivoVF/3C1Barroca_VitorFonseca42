using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Vítor42.Code.DTO
{
    class PreçosDTO
    {
        private int _id;
        private string _produtos;
        private string _precos;

        //Métodos de encapsulamento (CTRL+R,E)
        public int id { get => _id; set => _id = value; }
        public object ID { get; internal set; }
        public string Produtos { get => _produtos; set => _produtos = value; }
        public string Precos { get => _precos; set => _precos = value; }
        public object Preços { get; internal set; }

        internal void Inserir(PreçosDTO agrdto)
        {
            throw new NotImplementedException();
        }
    }
}
