using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.OOP3.Main.Conexao
{
    public class Conexao
    {
        public static SqlConnection conexao;
        public Conexao()
        {
            conexao.ConnectionString = @"Data Source=DESKTOP-6RB9P10;Initial Catalog=hospital;Integrated Security=True";
        }

        public SqlConnection ConectarBancoDeDados()
        {
            if (conexao.State == System.Data.ConnectionState.Closed)
            {
                conexao.Open();
            }
            return conexao;
        }
        public void DesconectarBancoDeDados()
        {
            if (conexao.State == System.Data.ConnectionState.Open)
            {
                conexao.Close();
            }
        }
    }
}
