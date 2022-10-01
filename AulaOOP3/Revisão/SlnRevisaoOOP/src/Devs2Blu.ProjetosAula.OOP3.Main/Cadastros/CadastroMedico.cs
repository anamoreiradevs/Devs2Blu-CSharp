using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroMedico : IMenuCadastro
    {
        public CadastroMedico()
        {

        }

        public void ListarMedico()
        {
            Console.Clear();

            foreach (var medico in Program.Mock.ListaMedico)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Medico: {medico.IDMedico}");
                Console.WriteLine($"Nome: {medico.Nome}");
                Console.WriteLine($"Especialidade: {medico.Especialidade}");
                Console.WriteLine($"CRM: {medico.CRM}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void ListarMedicoByIDAndName()
        {
            foreach (Medico medico in Program.Mock.ListaMedico)
            {
                Console.Write($"| {medico.IDMedico} - {medico.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void CadastrarMedico(Medico novoMedico)
        {
            Program.Mock.ListaMedico.Add(novoMedico);
        }
        public void AlterarMedico(Medico medico)
        {
            var med = Program.Mock.ListaMedico.Find(m => m.IDMedico == medico.IDMedico);
            int index = Program.Mock.ListaMedico.IndexOf(med);
            Program.Mock.ListaMedico[index] = medico;
        }
        public void ExcluirMedico(Medico medico)
        {
            Program.Mock.ListaMedico.Remove(medico);
        }
        #region FACADE
        public Int32 MenuCadastro()
        {
            Int32 opcao;

            Console.Clear();
            Console.WriteLine("----- Cadastro de Medicos -----");
            Console.WriteLine("----- 1- Lista de Medicos -----");
            Console.WriteLine("----- 2- Cadastro de Medicos -----");
            Console.WriteLine("----- 3- Alterar Cadastro Medicos -----");
            Console.WriteLine("----- 4- Deletar Cadastro Medico -----");
            Console.WriteLine("---------------------");
            Console.WriteLine("----- 0- Sair -----");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;

        }
        public void Listar()
        {
            ListarMedico();
        }
        public void Cadastrar()
        {
            Console.Clear();
            Medico medico = new Medico();
            Console.WriteLine("Informe o Nome do Medico");
            medico.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CPF do Medico");
            medico.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe a Especialidade do Medico");
            medico.Especialidade = Console.ReadLine();

            Random rd = new Random();
            Random randomCRM = new Random();
            medico.CRM = randomCRM.Next(1500, 5000);
            medico.ID = rd.Next(1, 100) + DateTime.Now.Second;
            medico.IDMedico = Int32.Parse($"{medico.ID}{rd.Next(100, 999)}");
            Console.WriteLine("Medico Cadastrado Com Sucesso!");
            Console.ReadLine();
            CadastrarMedico(medico);
        }
        public void Alterar()
        {
            Console.Clear();
            Medico medico;
            int idMedico;

            Console.WriteLine("Informe o Medico que Deseja Alterar:\n");
            ListarMedicoByIDAndName();

            Int32.TryParse(Console.ReadLine(), out idMedico);

            medico = Program.Mock.ListaMedico.Find(m => m.IDMedico == idMedico);

            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"ID:{medico.IDMedico} | Nome: {medico.Nome} | CPF: {medico.CGCCPF} " +
                    $"| Especialidae: {medico.Especialidade} | CRM: {medico.CRM} \n");
                Console.Clear();
                Console.WriteLine("Qual campo deseja alterar?\n");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Especialidade | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Clear();
                        Console.WriteLine("Informe um novo nome:");
                        medico.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Clear();
                        Console.WriteLine("Informe um novo CPF:");
                        medico.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.Clear();
                        Console.WriteLine("Informe nova Especialidade:");
                        medico.Especialidade = Console.ReadLine();
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
            AlterarMedico(medico);
        }
        public void Excluir()
        {

            Medico medico;
            Console.Clear();
            Int32 idMedico;
            Console.WriteLine("Informe o ID do Medico Que Deseja Deletar:");
            ListarMedicoByIDAndName();
            Int32.TryParse(Console.ReadLine(), out idMedico);
            medico = Program.Mock.ListaMedico.Find(m => m.IDMedico == idMedico);
            string opcaoExcluir;
            Console.Clear();
            Console.WriteLine($"ID: {medico.IDMedico} | Nome: {medico.Nome} |" +
                $" CPF: {medico.CGCCPF} | Especialidade: {medico.Especialidade} | CRM: {medico.CRM}\n");

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Medico?\n01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.WriteLine("Medico Deletado Com Sucesso!");
                    ExcluirMedico(medico);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.WriteLine("Medico Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
        #endregion

    }
}



