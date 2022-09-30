using System;
using System.Diagnostics.Metrics;
using System.Runtime.CompilerServices;
using System.Windows.Media.TextFormatting;
using System.Xml;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Timer = System.Windows.Forms.Timer;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public partial class Form1 : Form
    {
        Player primeiroPlayer = new Player();
        Player segundoPlayer = new Player();

        private int numeroAleatorio { get; set; }

        private int numeroPrimeiroPlayer;
        private int numeroSegundoPlayer;
        private int ContarRodada { get; set; }
        private int pontuacaoTotalPrimeiroPlayer = 0;
        private int pontuacaoTotalSegundoPlayer = 0;
        private int quantidadeDeVitoriasPrimeiroPlayer { get; set; }
        private int quantidadeDeVitoriasSegundoPlayer { get; set; }

        public string MensagemGanhadorPrimeiroPlayer = "Player 1";
        public string MensagemGanhadorSegundoPlayer = "Player 2";
        public string MensagemEmpate = "Empate";




        public Form1()
        {
            InitializeComponent();

        }

        private void iconButtonMenuJogoDo21_Click(object sender, EventArgs e)
        {

        }

        private void labelNomeDoJogo_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void iconButtonFirstPlayer_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonSecondPlayer_Click_1(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void txtNumeroUsuario_TextChanged(object sender, EventArgs e)
        {

        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelPontuaçaoPrimeiroPlayer_Click(object sender, EventArgs e)
        {

        }

        private void iconButtonTop_Click(object sender, EventArgs e)
        {

        }

        private void btnSalvarNumPrimeiroPlayer_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            Int32.TryParse(txtNumeroPrimeiroPlayer.Text, out numeroPrimeiroPlayer);

            if (numeroPrimeiroPlayer >= 1 && numeroPrimeiroPlayer <= 21)
            {
                numeroSegundoPlayer = random.Next(1, 21);

                primeiroPlayer.Numero = numeroPrimeiroPlayer;
                segundoPlayer.Numero = numeroSegundoPlayer;
                Thread.Sleep(1000);
                txtNumeroSegundoPlayer.Text = numeroSegundoPlayer.ToString();
            }
            else
            {
                txtInformacoesJogo.Text = "Digite um número dentro do intervalo 1 até 21";
            }

        }

        private void btnSalvarNumSegundoPlayer_Click(object sender, EventArgs e)
        {
            txtNumeroSegundoPlayer.Enabled = true;


        }

        private void btnResultadoJogo_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            numeroAleatorio = random.Next(1, 21);


            primeiroPlayer.Pontos = primeiroPlayer.CalcularPontos(primeiroPlayer.Numero, numeroAleatorio);
            segundoPlayer.Pontos = segundoPlayer.CalcularPontos(segundoPlayer.Numero, numeroAleatorio);
            pontuacaoTotalPrimeiroPlayer += primeiroPlayer.Pontos;
            pontuacaoTotalSegundoPlayer += segundoPlayer.Pontos;
            iconBtnPrimeiroPlayer.Text += $"{primeiroPlayer.Pontos}";
            iconBtnSegundoPlayer.Text += $"{segundoPlayer.Pontos}";

            VerificarRodada();
            MensagemResultado();

            if (ContarRodada == 4)
            {
                ZerarOJogo();
            }

        }

        #region Metodos
        private void VerificarRodada()
        {
            if (primeiroPlayer.Pontos > segundoPlayer.Pontos)
            {

                quantidadeDeVitoriasPrimeiroPlayer++;
            }
            else if (segundoPlayer.Pontos > primeiroPlayer.Pontos)
            {

                quantidadeDeVitoriasSegundoPlayer++;
            }

            iconBtnPrimeiroPlayer.Text = $"{pontuacaoTotalPrimeiroPlayer}";
            txtQuantidadeVitorias1Player.Text = $"{quantidadeDeVitoriasPrimeiroPlayer}";
            iconBtnSegundoPlayer.Text = $"{pontuacaoTotalSegundoPlayer}";
            txtQuantidadeVitorias2Player.Text = $"{quantidadeDeVitoriasSegundoPlayer}";

            ContarRodada++;
        }
        private void MensagemResultado()
        {
            if (pontuacaoTotalPrimeiroPlayer > pontuacaoTotalSegundoPlayer)
            {
                iconBtnVencedor.Text = $"{MensagemGanhadorPrimeiroPlayer}";
            }
            else if (pontuacaoTotalSegundoPlayer > pontuacaoTotalPrimeiroPlayer)
            {
                iconBtnVencedor.Text = $"{MensagemGanhadorSegundoPlayer}";
            }
            else
            {
                iconBtnVencedor.Text = $"{MensagemEmpate}";
            }
        }
        private void ZerarOJogo()
        {
            pontuacaoTotalPrimeiroPlayer = 0;
            quantidadeDeVitoriasSegundoPlayer = 0;
            ContarRodada = 0;
            txtQuantidadeVitorias1Player.Text = string.Empty;
            txtQuantidadeVitorias2Player.Text = string.Empty;
            iconBtnVencedor.Text = string.Empty;
            iconBtnPrimeiroPlayer.Text = string.Empty;
            iconBtnSegundoPlayer.Text = string.Empty;
            txtNumeroPrimeiroPlayer.Text = string.Empty;
            txtNumeroSegundoPlayer.Text = string.Empty;

        }

        #endregion
    }

}