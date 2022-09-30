using Devs2Blu.ProjetosAula.OOP3.Models.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models
{
    public class Fornecedor : Pessoa
    {
        public Int32 IDFornecedor { get; set; }
        public String TipoFornecedor { get; set; }

        public Fornecedor()
        {
            TipoPessoa = TipoPessoa.PJ;
        }

        public Fornecedor(Int32 id, String nome, String cnpj, String tipoFornecedor)
        {         
            ID = id;
            Nome = nome;
            CGCCPF = cnpj;
            TipoPessoa = TipoPessoa.PJ; ;
            TipoFornecedor = tipoFornecedor;
            Random random = new Random();
            IDFornecedor = Int32.Parse($"{id}{random.Next(100, 999)}");
            
        }
    }
}
