using SoccerSimulator.Domain.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSimulator.Observer
{
    public class Observer : IObserver
    {
        public readonly ITreinador _treinador;

        public Observer(ITreinador treinador, ISubject subject)
        {
            _treinador = treinador;
            subject.RegisterObserver(this);
        }

        public void Update(string someText)
        {
            Console.WriteLine(someText);
        }
    }
}
