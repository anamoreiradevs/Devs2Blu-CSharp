using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using Devs2Blu.ProjetosAula.OOP3.Main.Conexao;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Net.Http.Headers;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using System.Security.AccessControl;
using System.Diagnostics.SymbolStore;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastro
{
    public class CadastroPaciente : IMenuCadastro
    {
        public CadastroPaciente()
        {

        }
        private void ListarPacientes()
        {
            Console.Clear();

            foreach (Paciente paciente in Program.Mock.ListaPaciente)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Paciente: {paciente.IDPaciente}");
                Console.WriteLine($"Nome: {paciente.Nome}");
                Console.WriteLine($"CPF: {paciente.CGCCPF}");
                Console.WriteLine($"Convenio: {paciente.Convenio}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void CadastrarPaciente(Paciente novoPaciente)
        {
            Program.Mock.ListaPaciente.Add(novoPaciente);
        }
        private void AlterarPaciente(Paciente paciente)
        {
            var pact = Program.Mock.ListaPaciente.Find(p => p.IDPaciente == paciente.IDPaciente);
            int index = Program.Mock.ListaPaciente.IndexOf(pact);
            Program.Mock.ListaPaciente[index] = paciente;
        }
        private void ExcluirPaciente(Paciente paciente)
        {
            Program.Mock.ListaPaciente.Remove(paciente);
        }
        private void ListarPacientesByIdAndName()
        {
            foreach (Paciente paciente in Program.Mock.ListaPaciente)
            {
                Console.Write($"| {paciente.IDPaciente} - {paciente.Nome} ");
            }
            Console.WriteLine("\n");
        }
        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.Clear();
            Console.WriteLine("----- Cadastro de Pacientes -----");
            Console.WriteLine("----- 1- Lista de Pacientes -----");
            Console.WriteLine("----- 2- Cadastro de Pacientes -----");
            Console.WriteLine("----- 3- Alterar Cadastro Pacientes -----");
            Console.WriteLine("----- 4- Deletar Cadastro Paciente -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }

        public void Listar()
        {
            ListarPacientes();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Paciente paciente = new Paciente();
            String convenio;
            Console.WriteLine("Informe o Nome do Paciente");
            paciente.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF do Paciente");
            paciente.CGCCPF = Console.ReadLine();
            Console.WriteLine("O Paciente Possui Convenio? S/N");
            convenio = Console.ReadLine().ToUpper();
            
            if (convenio == "S")
            {
                Console.WriteLine("Informe o Convênio do Paciente");
                paciente.Convenio = Console.ReadLine();

            }
            else
            {
                paciente.Convenio = "Paciente Sem Convenio";
            }

            Random rd = new Random();
            paciente.ID = rd.Next(1, 100) + DateTime.Now.Second;
            paciente.IDPaciente = Int32.Parse($"{paciente.ID}{rd.Next(100, 999)}");
            
            Console.WriteLine("Paciente Cadastrado Com Sucesso");
            Console.ReadLine();
            CadastrarPaciente(paciente);
        }

        public void Alterar()
        {
            Console.Clear();
            Paciente paciente;
            int idPaciente;

            Console.WriteLine("Informe o Paciente que Deseja Alterar:\n");
            ListarPacientesByIdAndName();

            Int32.TryParse(Console.ReadLine(), out idPaciente);

            paciente = Program.Mock.ListaPaciente.Find(p => p.IDPaciente == idPaciente);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"ID:{paciente.IDPaciente} | Nome: {paciente.Nome} | CPF: {paciente.CGCCPF} |" +
                    $" Convênio: {paciente.Convenio} \n");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Convênio | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Clear();
                        Console.WriteLine("Informe um novo nome:");
                        paciente.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Clear();
                        Console.WriteLine("Informe um novo CPF:");
                        paciente.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.Clear(); 
                        Console.WriteLine("Informe um novo Convênio:");
                        paciente.Convenio = Console.ReadLine();
                        break;
                    default:
                        alterar = false;
                        break;
                }
                if (alterar)
                {
                    Console.Clear();
                    Console.WriteLine("Dado Alterado com Sucesso!");
                    Console.ReadLine();
                }
            } while (alterar);
            AlterarPaciente(paciente);
        }
        public void Excluir()
        {
            Paciente paciente;
            Console.Clear();
            Int32 idPaciente;
            Console.WriteLine("Informe o ID do Medico Que Deseja Deletar:");
            ListarPacientesByIdAndName();
            Int32.TryParse(Console.ReadLine(), out idPaciente);
            paciente = Program.Mock.ListaPaciente.Find(p => p.IDPaciente == idPaciente);
            string opcaoExcluir;

            Console.WriteLine($"ID: {paciente.IDPaciente} | Nome: {paciente.Nome} |" +
                $" CPF: {paciente.CGCCPF} Convenio: {paciente.Convenio}");

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Pacinte?");
            Console.WriteLine("01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.Clear();
                    Console.WriteLine("Paciente Deletado Com Sucesso!");
                    ExcluirPaciente(paciente);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.Clear();
                    Console.WriteLine("Paciente Nao Deletado!"); 
                    Console.ReadLine();
                    break;
                default:
                    
                    break;
            }
            
        }
            
        #endregion
    }
}