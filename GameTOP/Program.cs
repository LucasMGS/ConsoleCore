using System;
using GameTOP.Lib;

namespace GameTOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var Jogo = new JogoFODA(
                new Jogador1("Lucas"), 
                new Jogador2());
            Jogo.IniciarJogo();
        }
    }
}
