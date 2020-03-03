using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador2 : IJogador
    {

        public string Chutar()
        {
            return "Marando esta chutando";
        }

        public string Correr()
        {
            return "Marando esta correndo";
        }

        public string Passar()
        {
            return "Marando esta passando";
        }
    }
}