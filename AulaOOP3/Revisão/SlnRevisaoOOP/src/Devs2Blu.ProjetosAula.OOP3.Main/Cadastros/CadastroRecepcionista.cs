using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroRecepcionista : IMenuCadastro
    {
        public CadastroRecepcionista()
        {

        }

        public void ListarRecepcionista()
        {
            Console.Clear();

            foreach (var recepcionista in Program.Mock.ListaRecepcionista)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Recepcionista: {recepcionista.IDRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }

        private void ListarRecepcionistasByIdAndName()
        {
            foreach (Recepcionista recepcionista in Program.Mock.ListaRecepcionista)
            {
                Console.Write($"| {recepcionista.IDRecepcionista} - {recepcionista.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void CadastrarRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionista.Add(recepcionista);
        }

        public void AlterarRecepcionista(Recepcionista recepcionista)
        {
            var recep = Program.Mock.ListaRecepcionista.Find(r => r.IDRecepcionista == recepcionista.IDRecepcionista);
            int index = Program.Mock.ListaRecepcionista.IndexOf(recep);
            Program.Mock.ListaRecepcionista[index] = recepcionista;
        }

        public void ExcluirRecepcionista(Recepcionista recepcionista)
        {
            Program.Mock.ListaRecepcionista.Remove(recepcionista);
        }
        #region FACADE
        public Int32 MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
            Console.WriteLine("-------- Cadastro Recepcionista -------");
            Console.WriteLine("-------- 1 - Lista de Recepcionista-------");
            Console.WriteLine("-------- 2 - Cadastro de Recepcionista -------");
            Console.WriteLine("-------- 3 - Alterar Cadastro Recepcionista -------");
            Console.WriteLine("-------- 4 - Deletar Cadastro de Recepcionista -------");
            Console.WriteLine("---------------");
            Console.WriteLine("---- 0 - Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarRecepcionista();
        }

        public void Cadastrar()
        {
            Console.Clear();
            Recepcionista recepcionista = new Recepcionista();
            String setor;
            Console.WriteLine("Informe o Nome da(o) Recepcionista");
            recepcionista.Nome = Console.ReadLine();
            Console.WriteLine("Informe o CPF da(o) Recepcionista");
            recepcionista.CGCCPF = Console.ReadLine();
            Console.WriteLine("Informe O Setor da(o) Recepcionista ");
            recepcionista.Setor = Console.ReadLine();
            Random rd = new Random();
            recepcionista.ID = rd.Next(1, 100) + DateTime.Now.Second;
            recepcionista.IDRecepcionista = Int32.Parse($"{recepcionista.ID}{rd.Next(100, 999)}");

            Console.WriteLine("Recepcionista Cadastrado Com Sucesso");
            Console.ReadLine();
            CadastrarRecepcionista(recepcionista);
        }

        public void Alterar()
        {
            Console.Clear();
            Recepcionista recepcionista;
            int idRecepcionista;

            Console.WriteLine("Informe o Recepcionista que Deseja Alterar:\n");
            ListarRecepcionistasByIdAndName();

            Int32.TryParse(Console.ReadLine(), out idRecepcionista);

            recepcionista = Program.Mock.ListaRecepcionista.Find(m => m.IDRecepcionista == idRecepcionista);


            string opcaoAlterar;
            bool alterar = true;

            do
            {
                Console.Clear();
                Console.WriteLine($"ID: {recepcionista.ID} | Nome: {recepcionista.Nome} | " +
                    $"CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");
                Console.WriteLine("Qual campo deseja alterar?");
                Console.WriteLine("01 - Nome | 02 - CPF | 03 Setor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Clear();
                        Console.WriteLine("Informe um novo nome:");
                        recepcionista.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Clear();
                        Console.WriteLine("Informe um novo CPF:");
                        recepcionista.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.Clear();
                        Console.WriteLine("Informe um novo Convênio:");
                        recepcionista.Setor = Console.ReadLine();
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
            AlterarRecepcionista(recepcionista);
        }

        public void Excluir()
        {
            Recepcionista recepcionista;
            Console.Clear();
            Int32 idRecepcionista;
            Console.WriteLine("Informe o ID da(o) Recepcionista Que Deseja Deletar:");
            ListarRecepcionistasByIdAndName();
            Int32.TryParse(Console.ReadLine(), out idRecepcionista);
            recepcionista = Program.Mock.ListaRecepcionista.Find(r => r.IDRecepcionista == idRecepcionista);
            string opcaoExcluir;
            Console.Clear();
            Console.WriteLine($"ID: {recepcionista.IDRecepcionista} | Nome: {recepcionista.Nome} |" +
                $" CPF: {recepcionista.CGCCPF} | Setor: {recepcionista.Setor}");

            Console.WriteLine("Tem Certeza Que Deseja Deletar esse Recepcionista?\n01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.WriteLine("Recepcionista Deletado Com Sucesso!");
                    ExcluirRecepcionista(recepcionista);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.WriteLine("Recepcionista Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
