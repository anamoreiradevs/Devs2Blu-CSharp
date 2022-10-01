using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Cadastros
{
    public class CadastroFornecedor : IMenuCadastro
    {
        public CadastroFornecedor()
        {

        }
        public void ListarFornecedor()
        {
            Console.Clear();

            foreach (var fornecedor in Program.Mock.ListaFornecedor)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Fornecedor: {fornecedor.IDFornecedor}");
                Console.WriteLine($"Nome: {fornecedor.Nome}");
                Console.WriteLine($"Setor: {fornecedor.TipoFornecedor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
        }
        private void ListarFornecedorByIDAndName()
        {
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedor)
            {
                Console.Write($"| {fornecedor.IDFornecedor} - {fornecedor.Nome} ");
            }
            Console.WriteLine("\n");
        }
        public void CadastrarFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedor.Add(fornecedor);
        }
        public void AlterarFornecedor(Fornecedor fornecedor)
        {
            var forne = Program.Mock.ListaFornecedor.Find(f => f.IDFornecedor == fornecedor.IDFornecedor);
            int index = Program.Mock.ListaFornecedor.IndexOf(forne);
            Program.Mock.ListaFornecedor[index] = fornecedor;
        }
        public void ExcluirFornecedor(Fornecedor fornecedor)
        {
            Program.Mock.ListaFornecedor.Remove(fornecedor);
        }
        #region FACADE
        public Int32 MenuCadastro()
        {
            Console.Clear();
            Int32 opcao;
            Console.WriteLine("-------- Cadastro Fornecedor -------");
            Console.WriteLine("-------- 1 - Lista de Fornecedor-------");
            Console.WriteLine("-------- 2 - Cadastro de Fornecedor -------");
            Console.WriteLine("-------- 3 - Alterar Cadastro de Fornecedor -------");
            Console.WriteLine("-------- 4 - Deletar Cadastro de Fornecedor -------");
            Console.WriteLine("---------------");
            Console.WriteLine("---- 0 - Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            ListarFornecedor();
        }
        public void Cadastrar()
        {
            Console.Clear();
            Fornecedor fornecedor = new Fornecedor();
            Console.WriteLine("Informe o Nome do Fornecedor");
            fornecedor.Nome = Console.ReadLine();

            Console.WriteLine("Informe o CNPJ do Fornecedor");
            fornecedor.CGCCPF = Console.ReadLine();

            Console.WriteLine("Informe o Tipo do Fornecedor");
            fornecedor.TipoFornecedor = Console.ReadLine();

            Random rd = new Random();
            fornecedor.ID = rd.Next(1, 100) + DateTime.Now.Second;
            fornecedor.IDFornecedor = Int32.Parse($"{fornecedor.ID}{rd.Next(100, 999)}");
            Console.WriteLine("Fornecedor Cadastrado Com Sucesso!");
            Console.ReadLine();
            CadastrarFornecedor(fornecedor);
        }
        public void Alterar()
        {
            Console.Clear();
            Fornecedor fornecedor;
            int idFornecedor;
            Console.WriteLine("Informe o Fornecedor que Deseja Alterar:\n");
            ListarFornecedorByIDAndName(); ;
            Int32.TryParse(Console.ReadLine(), out idFornecedor);
            fornecedor = Program.Mock.ListaFornecedor.Find(f => f.IDFornecedor == idFornecedor);
            string opcaoAlterar;
            bool alterar = true;
            do
            {
                Console.Clear();
                Console.WriteLine($"ID:{fornecedor.IDFornecedor} | Nome: {fornecedor.Nome} | CNPJ: {fornecedor.CGCCPF} " +
                    $"| Tipo do Fornecedor: {fornecedor.TipoFornecedor}\n");
                Console.Clear();
                Console.WriteLine("Qual campo deseja alterar?\n");
                Console.WriteLine("01 - Nome | 02 - CPNJ | 03 - Tipo Fornecedor | 00 - SAIR");
                opcaoAlterar = Console.ReadLine();

                switch (opcaoAlterar)
                {
                    case "01":
                        Console.Clear();
                        Console.WriteLine("Informe um novo nome:");
                        fornecedor.Nome = Console.ReadLine();
                        break;
                    case "02":
                        Console.Clear();
                        Console.WriteLine("Informe um novo CNPJ:");
                        fornecedor.CGCCPF = Console.ReadLine();
                        break;
                    case "03":
                        Console.Clear();
                        Console.WriteLine("Informe Tipo de Fornecedor:");
                        fornecedor.TipoFornecedor = Console.ReadLine();
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
            AlterarFornecedor(fornecedor);
        }
        public void Excluir()
        {
            Fornecedor fornecedor;
            Console.Clear();
            Int32 idFornecedor;
            Console.WriteLine("Informe o ID do Fornecedor Que Deseja Deletar:");
            ListarFornecedorByIDAndName();
            Int32.TryParse(Console.ReadLine(), out idFornecedor);
            fornecedor = Program.Mock.ListaFornecedor.Find(f=> f.IDFornecedor == idFornecedor);
            string opcaoExcluir;
            Console.Clear();
            Console.WriteLine($"ID: {fornecedor.IDFornecedor} | Nome: {fornecedor.Nome} |" +
                $" CNPJ: {fornecedor.CGCCPF} | Tipo Fornecedor: {fornecedor.TipoFornecedor}\n"); 

            Console.WriteLine("Tem Certeza Que Deseja Deletar o Fornecedor?\n01 - Sim | 02 - Nao");
            opcaoExcluir = Console.ReadLine();

            switch (opcaoExcluir)
            {
                case "01":
                    Console.Clear();
                    Console.WriteLine("Fornecedor Deletado Com Sucesso!");
                    ExcluirFornecedor(fornecedor);
                    Console.ReadLine();
                    break;
                case "02":
                    Console.Clear();
                    Console.WriteLine("Fornecedor Nao Deletado!");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
        #endregion
    }
}
