using Devs2Blu.ProjetosAula.OOP2Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace Devs2Blu.ProjetosAula.AulaOOP2
{
    public partial class Form1 : Form
    {
        public Contato ContatoForm { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            /*ContatoForm = new Contato(txtNome,txtTelefone,txtEmail);*/
        }

        #region Eventos
        private void btnEnviarDados_Click(object sender, EventArgs e)
        {
            if (!ValidaForm())
            {
                MessageBox.Show(this, "Preencha todos os campos", " @ERRO - Formulario de Contato", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BindClass();
            
            String mensagemParaUsuario = $"{txtNome.Text}, Texto enviado com sucesso";
            MessageBox.Show(this, mensagemParaUsuario);
        }
        private void txtCEP_TextChanged(object sender, EventArgs e)
        {
            if (txtCEP.Text.Length == 8)
            {
                txtRua.Text = "7 de Setembro";
                txtBairro.Text = "Centro";
                txtCidade.Text = "Blumenau";
                txtEstado.Text = "SC";
            }
            else
            {
                txtRua.Clear();
                txtBairro.Clear();
                txtCidade.Clear();
                txtEstado.Clear();
            }
        }
        private void btnLimparDados_Click(object sender, EventArgs e)
        {
            LimparDados();
        }
        #endregion
        #region Metodos

        public void BindClass()
        {
            txtNome.Text = ContatoForm.Nome;
            txtTelefone.Text = ContatoForm.Telefone;
            txtCEP.Text = ContatoForm.CEP;
            txtRua.Text = ContatoForm.Rua;
            txtBairro.Text = ContatoForm.Bairro;
            txtCidade.Text = ContatoForm.Cidade;
            txtEstado.Text = ContatoForm.Estado;
            txtNumero.Text = ContatoForm.Numero.ToString();
        }
        private bool ValidaForm()
        {

            if (txtNome.Text.Equals("")) return false;
            if (txtTelefone.Text.Equals("")) return false;
            if (txtCEP.Text.Equals("")) return false;
            if (txtRua.Text.Equals("")) return false;
            if (txtBairro.Text.Equals("")) return false;
            if (txtCidade.Text.Equals("")) return false;
            if (txtEstado.Text.Equals("")) return false;
            if (txtNumero.Text.Equals("")) return false;


            return true;
        }
        public void LimparDados()
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTelefone.Clear();
            txtCEP.Clear();
            txtRua.Clear();
            txtBairro.Clear();
            txtCidade.Clear();
            txtEstado.Clear();
            txtNumero.Clear();

        }
        #endregion
        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }
        private void txtTelefone_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {

        }



        private void txtrRua_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBairro_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCidade_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEstado_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNumero_TextChanged(object sender, EventArgs e)
        {

        }





    }
}