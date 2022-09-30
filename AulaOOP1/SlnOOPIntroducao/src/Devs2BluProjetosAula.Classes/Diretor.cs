using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;

namespace Devs2BluProjetosAula.Classes
{
    public class Diretor : Pessoa
    {
        public double ProLabore { get; set; }
        public Diretor()
        {

        }
        public Diretor(string nome, string sobreNome, double proLabore)
        {
            Nome = nome;
            Sobrenome = sobreNome;
            ProLabore = proLabore;
        }
        public string VerificaStatus()
        {
            return "Hospital Ok";
        }
    }
}
