using SoccerSimulator.Domain.Behavior;

namespace SoccerSimulator.Observer
{
    public class Subject : ISubject
    {
        private readonly List<IObserver> observers = new List<IObserver>();

        public IJogador _jogador;

        public Subject(IJogador jogador)
        {
            _jogador = jogador;
        }

        public void NotifyObserversOfAttemptive()
        {
            Console.WriteLine($"{_jogador.Nome} a tentar pela {_jogador.RematesABaliza} vez");
        }

        public void NotifyObservers()
        {
            foreach (IObserver observer in observers)
            {
                observer.Update($"GOOOOOLO de {_jogador.Nome} na {_jogador.RematesABaliza} tentativa!");
            }
        }

        public void RegisterObserver(IObserver observer)
        {
            if (((Observer)observer)._treinador.Nome is not null)
            {
                Console.WriteLine($"Treinador a observar: {((Observer)observer)._treinador.Nome}");
                observers.Add(observer);
            }
        }

        public void RemoveObserver(IObserver observer)
        {
            observers.Remove(observer);
        }

        public void AddObservers(IObserver observer)
        {
            observers.Add(observer);
        }
    }
}
