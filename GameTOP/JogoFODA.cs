using System;
using GameTOP.Lib;

namespace GameTOP
{
    public class JogoFODA
    {
        private readonly Jogador1 jogador1;
        private readonly Jogador2 jogador2;

        public JogoFODA(Jogador1 jogador1, Jogador2 jogador2)
        {
            this.jogador1 = jogador1;
            this.jogador2 = jogador2;
        }

        public void IniciarJogo()
        {
            Console.WriteLine(jogador1.Chutar());
            Console.WriteLine(jogador1.Correr());
            Console.WriteLine(jogador1.Passar());

            Console.WriteLine(jogador2.Chutar());
            Console.WriteLine(jogador2.Correr());
            Console.WriteLine(jogador2.Passar());
        }
    }
}