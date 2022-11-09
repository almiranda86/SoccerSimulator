using SoccerSimulator.Comum;
using SoccerSimulator.Domain.Behavior;
using SoccerSimulator.Domain.Model;
using SoccerSimulator.Observer;

namespace SoccerSimulator.Application
{
    public class PartidaDeFutebol : IPartida
    {
        private IJogador _jogador;
        private ISubject _subject;
        private readonly IGeradorDeGolos _geradorDeGolos;
        public PartidaDeFutebol(IJogador jogador,
                                ISubject subject,
                                IGeradorDeGolos geradorDeGolos)
        {
            _jogador = jogador;
            _subject = subject;
            _geradorDeGolos = geradorDeGolos;
        }

        public void IniciarPartida()
        {
            _jogador = new Jogador();
            _jogador.DefinirNomeJogador(Constants.NomeJogador);

            _subject = new Subject(_jogador);

            ITreinador treinador = new Treinador();
            treinador.DefinirNomeTreinador(Constants.NomeTreinador);
            _ = new Observer.Observer(treinador, _subject);

            int tentativas = TentativasDeRemate();

            for (int i = 0; i < tentativas; i++)
            {
                int numeroTentativa = _jogador.Arrematar();
                _subject.NotifyObserversOfAttemptive();
                

                if (_geradorDeGolos.RemateBemSucedido(numeroTentativa))
                    _subject.NotifyObservers();
            }
        }

        private static int TentativasDeRemate()
        {
            Random rnd = new Random();
            return 12;
        }
    }
}
