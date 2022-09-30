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
        public Int32 MenuCadastro()
        {
            Int32 opcao;
            Console.WriteLine("-------- Cadastro Recepcionista -------");
            Console.WriteLine("-------- 1 - Lista de Recepcionista-------");
            Console.WriteLine("-------- 2 - Cadastro de Recepcionista -------");
            Console.WriteLine("---------------");
            Console.WriteLine("---- 0 - Sair ---");
            Int32.TryParse(Console.ReadLine(), out opcao);
            return opcao;
        }
        public void Listar()
        {
            Console.Clear();

            foreach (var recepcionista in Program.Mock.ListaRecepcionista)
            {
                Console.WriteLine("-----------------------------------------");
                Console.WriteLine($"Medico: {recepcionista.IDRecepcionista}");
                Console.WriteLine($"Nome: {recepcionista.Nome}");
                Console.WriteLine($"Setor: {recepcionista.Setor}");
                Console.WriteLine("-----------------------------------------\n");
            }
            Console.ReadLine();
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
