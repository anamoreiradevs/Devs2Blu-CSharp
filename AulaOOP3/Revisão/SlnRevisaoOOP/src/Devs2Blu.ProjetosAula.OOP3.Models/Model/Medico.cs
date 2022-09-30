using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models
{
    public class Medico : Pessoa
    {
        public Int32 IDMedico { get; set; }
        public Int32 CRM { get; set; }
        public String Especialidade { get; set; }
        public Medico()
        {
            TipoPessoa = TipoPessoa.PF;
        }
        public Medico(Int32 id, String nome, String cpf, Int32 crm, String  especialidade)
        {
            ID = id;
            Nome = nome;
            CGCCPF = cpf;
            CRM = crm;
            TipoPessoa = TipoPessoa.PF;
            Especialidade = especialidade;
            Random random = new Random();
            IDMedico = Int32.Parse($"{id}{random.Next(100, 999).ToString()}");
        }
    }
}
