using GameTOP.Interfaces;

namespace GameTOP.Lib
{
    public class Jogador1 : IJogador
    {
        public readonly string Nome;

        public Jogador1()
        {
            
        }
        public Jogador1(string nome)
        {
            Nome = nome;
        }
        public string Chutar()
        {
            return $"{Nome} está chutando!";
        }

        public string Correr()
        {
            return $"{Nome} está correndo!";
        }

        public string Passar()
        {
            return $"{Nome} está passando!";
        }
    }
}