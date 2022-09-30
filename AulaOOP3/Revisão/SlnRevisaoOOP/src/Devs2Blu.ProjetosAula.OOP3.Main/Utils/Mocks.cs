using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Utils
{
    public class Mocks
    {
        public  List<Paciente> ListaPaciente { get; set; }
        public  List<Medico> ListaMedico { get; set; }
        public  List<Recepcionista> ListaRecepcionista { get; set; }
        public  List<Fornecedor> ListaFornecedor { get; set; }
        public Mocks()
        {
            ListaPaciente = new List<Paciente>();
            ListaMedico = new List<Medico>();
            ListaRecepcionista = new List<Recepcionista>();
            ListaFornecedor = new List<Fornecedor>();
            

            CargaMock();
        }
        public  void CargaMock()
        {
            CargaPaciente();
            CargaMedico();
            CargaRecepcionista();
            CargaFornecedor();
        }
        public  void CargaPaciente()
        {
            for (int i = 0; i < 5; i++)
            {
                Paciente paciente = new Paciente(i, $"Paciente {i}", $"{i}23{i}56{i}8-91", "Unimed");
                ListaPaciente.Add(paciente);
            }
        }
        public void CargaMedico()
        {
            Random random = new Random();
            string[] especialidade = {"Cardiologista", "Neurologista", "Pediatra", "Anestesista", "Medico Geral"};
            for (int i = 0; i < 10; i++)
            { 
                Medico medico = new Medico(i, $"Medico {i}", $"{i}",random.Next(1,999), especialidade[random.Next(especialidade.Length)]);
                ListaMedico.Add(medico);
            }
        }

        public void CargaRecepcionista()
        {
            Random random = new Random();
            String[] nome = {"Maria", "Jose", "Thiago", "Julia" };
            string[] setor = {"Pediatria","Recepção", "Cardiologia", "Neurologia", "Anestesia"};
            for (int i = 0; i < 5; i++)
            {
                Recepcionista recepcionista = new Recepcionista(i, nome[random.Next(nome.Length)], $"{i}78{i}90{i}620", setor[random.Next(setor.Length)]);
                ListaRecepcionista.Add(recepcionista);
            }
        }

        public void CargaFornecedor()
        {
            Random random = new Random();
            String[] nomeFornecedor = { "Medicarlrl", "Drager", "Bionexo" };
            String[] TipoFornecedor = { "Equipamento Cirurgico", "Uniforme Hospitalar", "Medicamentos" };
           
            for (int i = 0; i < nomeFornecedor.Length; i++)
            {
                Fornecedor fornecedor = new Fornecedor(i, nomeFornecedor[random.Next(nomeFornecedor.Length)], $"{i}89{i}90{i}70", TipoFornecedor[random.Next(TipoFornecedor.Length)]);
                ListaFornecedor.Add(fornecedor);
            }
        }
    }
}
