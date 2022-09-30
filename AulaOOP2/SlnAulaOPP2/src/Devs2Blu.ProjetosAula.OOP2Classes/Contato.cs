using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP2Classes
{
    public  class Contato
    {
        public String Nome { get; set; }
        public String Telefone { get; set; }
        public String Email { get; set; }
        public String Rua { get; set; }
        public String Bairro { get; set; }
        public String Cidade { get; set; }
        public String Estado { get; set; }
        public String CEP { get; set; }
        public Int32 Numero { get; set; }

        public Contato(String nome, String email, String telefone)
        {
            Nome = nome;
            Telefone = telefone;
            Email = email;
            
        }
    }


}
