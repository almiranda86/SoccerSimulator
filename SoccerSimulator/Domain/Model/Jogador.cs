using SoccerSimulator.Domain.Behavior;

namespace SoccerSimulator.Domain.Model
{
    public class Jogador : IJogador
    {
        public string Nome { get; set; }

        public int RematesABaliza { get; set; }

        public void DefinirNomeJogador(string nome) => Nome = nome;

        public int Arrematar()
        {
            return ++RematesABaliza;
        }
    }
}
