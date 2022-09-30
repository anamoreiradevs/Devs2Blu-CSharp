using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models
{
    public class Recepcionista : Pessoa
    {
        public Int32 IDRecepcionista { get; set; }
        public String Setor { get; set; }
        

        public Recepcionista()
        {
            TipoPessoa = TipoPessoa.PF;

        }

        public Recepcionista(Int32 id, String nome, String cpf, String setor)
        {
            ID = id;
            Nome = nome;
            TipoPessoa = TipoPessoa.PF;
            Setor = setor;
            CGCCPF = cpf;

            Random random = new Random();
            IDRecepcionista = Int32.Parse($"{id}{random.Next(100, 999).ToString()}");
        }
    }
}
