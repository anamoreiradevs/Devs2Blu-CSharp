using Devs2Blu.ProjetosAula.OOP3.Main.Cadastro;
using Devs2Blu.ProjetosAula.OOP3.Main.Cadastros;
using Devs2Blu.ProjetosAula.OOP3.Main.Interfaces;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils;
using Devs2Blu.ProjetosAula.OOP3.Main.Utils.Enums;
using Devs2Blu.ProjetosAula.OOP3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main
{
    public class Program
    {

        public static Mocks Mock { get; set; }
        static void Main(string[] args)
        {
            Int32 opcao = (int)MenuEnum.SAIR, opcaoMenuCadastro = (int)MenuEnum.SAIR;
            Mock = new Mocks();
            IMenuCadastro menuCadastro;
            do
            {
                if (opcaoMenuCadastro.Equals((int)MenuEnum.SAIR))
                {
                    Console.WriteLine("-------- 10 -Cadastro Paciente -------");
                    Console.WriteLine("-------- 20 - Cadastro de Medicos -------");
                    Console.WriteLine("-------- 30 - Cadastro de Recepcionistas -------");
                    Console.WriteLine("-------- 40 - Cadastro de Fornecedores -------");
                    Console.WriteLine("-------- 50- Agenda -------");
                    Console.WriteLine("-------- 60- Prontuario -------");
                    Console.WriteLine("-------- 70- Financeiro -------");
                    Console.WriteLine("---------------");
                    Console.WriteLine("---- 0 - Sair ---");
                    Int32.TryParse(Console.ReadLine(), out opcao);
                }

                switch (opcao)
                {
                    case (int)MenuEnum.CAD_PAC:
                        menuCadastro = new CadastroPaciente();
                        opcaoMenuCadastro = menuCadastro.MenuCadastro();
                        break;
                    case (int)MenuEnum.CAD_MED:
                        menuCadastro = new CadastroMedico();
                        opcaoMenuCadastro = menuCadastro.MenuCadastro();
                        break;
                    case (int)MenuEnum.CAD_REC:
                        menuCadastro = new CadastroRecepcionista();
                        opcaoMenuCadastro = menuCadastro.MenuCadastro();
                        break;
                    case (int)MenuEnum.CAD_FOR:
                        menuCadastro = new CadastroFornecedor();
                        opcaoMenuCadastro = menuCadastro.MenuCadastro();
                        break;
                    default:
                        menuCadastro = new CadastroPadrao();
                        opcaoMenuCadastro = (int)MenuEnum.SAIR;
                        break;
                }

                switch (opcaoMenuCadastro)
                {
                    case (int)MenuEnum.LISTAR:
                        menuCadastro.Listar();
                        break;
                    case (int)MenuEnum.CADASTRAR:
                        menuCadastro.Cadastrar();
                        break;
                    case (int)MenuEnum.ALTERAR:
                        menuCadastro.Alterar();
                        break;
                    case (int)MenuEnum.EXCLUIR:
                        menuCadastro.Excluir();
                        break;
                    default:
                        opcaoMenuCadastro = (int)MenuEnum.SAIR;
                        break;
                }
            }
            while (!opcao.Equals((int)MenuEnum.SAIR));
        }
    }
}






