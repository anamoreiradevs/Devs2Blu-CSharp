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
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.WriteLine("-------- Cadastro Fornecedor -------");
            Console.WriteLine("-------- 1 - Lista de Fornecedor-------");
            Console.WriteLine("-------- 2 - Cadastro de Fornecedor -------");
            Console.WriteLine("---------------");
            Console.WriteLine("---- 0 - Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            Console.Clear();
            foreach (Fornecedor fornecedor in Program.Mock.ListaFornecedor)
            {
                Console.WriteLine("--------");
                Console.WriteLine($"ID Fornecedor : {fornecedor.IDFornecedor}");
                Console.WriteLine($"Nome Fantasia: {fornecedor.Nome}");
                Console.WriteLine($"CNPJ: {fornecedor.CGCCPF}");
                Console.WriteLine($"Tipo: {fornecedor.TipoFornecedor}");
            }
        }

        public void Cadastrar()
        {
            throw new NotImplementedException();
        }

        public void Alterar()
        {
            throw new NotImplementedException();
        }

        public void Excluir()
        {
            throw new NotImplementedException();
        }
    }
}
