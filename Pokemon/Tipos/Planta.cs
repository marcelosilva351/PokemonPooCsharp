using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Tipos
{
    public class Planta : PokemonBase
    {
        public Planta(string nome) : base(nome,"planta")
        {

        }


        public override void Fraqueza(PokemonBase pokemon)
        {
           if(pokemon.Tipo == "fogo")
            {
                this.Ataque -= 5;
                this.Defesa -= 3;
            }
        }

        public override void Vantagem(PokemonBase pokemon)
        {
            if(pokemon.Tipo == "agua")
            {
                this.Ataque += 5;
                this.Defesa += 2;
            }
        }
    }
}
