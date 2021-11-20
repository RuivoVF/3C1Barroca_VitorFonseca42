using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3C1Vítor42.Code.DTO
{
    class RiHappyLoginDTO
    {
        private int _id;
        private string _email;
        private string _senha;


        public int ID { get => _id; set => _id = value; }

        public string Email { get => _email; set => _email = value; }

        public string Senha { get => _senha; set => _senha = value; }
    }
}
