using Devs2BluProjetosAula.Classes;

namespace Dev2Blu.ProjetosAula.AulaOOP1Int
{
    public partial class Form1 : Form
    {
        public List<Recepcionista> RecepcionistasList { get; set; }
        public List<Diretor> DiretorsList { get; set; }

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        #region Metodos
        private void SalvarRecepcionista(Recepcionista recepcionista)
        {
            RecepcionistasList.Add(recepcionista);
        }
        private void SalvarDiretor(Diretor diretor)
        {
            DiretorsList.Add(diretor);
        }

        #endregion

        private void btnCadastroFuncionario_Click(object sender, EventArgs e)
        {
            
        }
    }

}