using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.ProjetosAula.Aula6.Jogo21
{
    public class Player
    {
        public int Numero { get; set; }
        public int Pontos { get; set; }

        public Player()
        {

        }
        public Player(int numero, int pontos)
        {
            Numero = numero;
            Pontos = pontos;
        }
        public int CalcularPontos(int numero, int numeroAleatorio)
        {
            numero += numeroAleatorio;
            int pontos = 0;

            switch (numero)
            {
                case 7:
                    pontos += 10;
                    break;
                case int n when (n > 7 && n <15):
                    pontos += 5;
                    break;
                case 21:
                    pontos = 30;
                    break;
                case int i when (i < 7):
                    pontos = 1;
                    break;
                case int i when (i > 7 && i < 14):
                    pontos = 5;
                    break;
                case int i when (i >= 15 && i < 21):
                    pontos = 6;
                    break;
            }
            return pontos;

        }
    }
}
