using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class Prontuario
    {
        public Int32 IDProntuario { get; set; }
        public String SinaisVitais { get; set; }
        public DateTime DataEntradaPaciente { get; set; }
        public DateTime DataAltaPaciente { get; set; }
        public String StatusPaciente { get; set; }
    }
}
