using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Devs2BluProjetosAula.Classes
{
    public class Recepcionista : Pessoa
    {

        public Recepcionista()
        {
            Nome = "Novo Nome";
            Sobrenome = "Sobrenome";
            CodigoCracha = 3333;

        }
        public Recepcionista(string nome, string sobrenome)
        {
            this.Nome = nome;
            this.Sobrenome = sobrenome;
        }

        public Recepcionista(int codigoCracha, string endereco)

        {
            CodigoCracha = codigoCracha;
            Endereco = endereco;
        }
        public int CodigoCracha { get; set; }

        public string AgendarConsulta()
        {
            return "Consulta Agendada!";
        }
    }
}
