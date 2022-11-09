using SoccerSimulator.Domain.Model.Base;

namespace SoccerSimulator.Domain.Behavior
{
    public interface ITreinador : IPessoa
    {
        public void DefinirNomeTreinador(string nomeTreinador);
    }
}
