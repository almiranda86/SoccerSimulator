using SoccerSimulator.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSimulator.Domain.Behavior
{
    public interface IJogador : IPessoa
    {
        public int RematesABaliza { get; set; }

        public int Arrematar();

        public void DefinirNomeJogador(string nomeJogador);
    }
}
