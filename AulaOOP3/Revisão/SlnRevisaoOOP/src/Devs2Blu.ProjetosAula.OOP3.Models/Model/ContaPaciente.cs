using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class ContaPaciente : Paciente
    {
        public Double ValorTotal { get; set; }
        public String StatusConta { get; set; }
    }
}
