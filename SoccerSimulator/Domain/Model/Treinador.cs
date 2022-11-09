using SoccerSimulator.Domain.Behavior;
using SoccerSimulator.Domain.Model.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoccerSimulator.Domain.Model
{
    public class Treinador : ITreinador
    {
        public string Nome { get; set; }

        public void DefinirNomeTreinador(string nomeTreinador) => Nome = nomeTreinador;

    }
}
