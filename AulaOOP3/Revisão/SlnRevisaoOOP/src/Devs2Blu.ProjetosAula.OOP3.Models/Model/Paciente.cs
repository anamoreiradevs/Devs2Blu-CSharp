using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models
{
    public class Paciente : Pessoa
    {
        public Int32 IDPaciente { get; set; }
        public String Convenio { get; set; }

        public Paciente()
        {
            TipoPessoa = TipoPessoa.PF;
        }
        public Paciente(Int32 id, String nome, String cpf, String convenio)
        {
            ID= id;
            Nome = nome;
            CGCCPF = cpf;
            TipoPessoa = TipoPessoa.PF;
            Convenio = convenio;
            Random random = new Random();
            IDPaciente = Int32.Parse($"{id}{random.Next(100,999).ToString()}");
        }
    }
}
