using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Models.Model
{
    public class AgendaPaciente
    {
        public String StatusAgendamento { get; set; }
        public DateTime HoraAgenda { get; set; }
        public DateTime HoraInicioAtendimento { get; set; }
        public DateTime HoraFinalAtendimento { get; set; }

    }
}
