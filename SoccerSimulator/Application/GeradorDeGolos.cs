using SoccerSimulator.Domain.Behavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSimulator.Application
{
    public class GeradorDeGolos : IGeradorDeGolos
    {
        public bool RemateBemSucedido(int numeroTentativa)
        {
            if (numeroTentativa % 4 == 0)
                return true;

            return false;
        }
    }
}
