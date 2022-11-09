using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSimulator.Domain.Behavior
{
    public interface IGeradorDeGolos
    {
        public bool RemateBemSucedido(int numeroTentativa);
    }
}
