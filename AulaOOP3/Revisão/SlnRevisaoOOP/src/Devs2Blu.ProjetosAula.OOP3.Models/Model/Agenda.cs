using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models
{
    public class Agenda
    {
        public String ID { get; set; }
        public DateTime DiaAtendimento { get; set; }
        public DateTime HoraInicioAtendimento { get; set; }
        public DateTime HoraFinalAtendimento { get; set; }
        public String StatusAgenda { get; set; }
        
        
    }
}
