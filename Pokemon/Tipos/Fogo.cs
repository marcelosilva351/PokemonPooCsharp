using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Tipos
{
   public class Fogo : PokemonBase
    {
        
        public Fogo(string nome) : base(nome, "fogo")
        {

        }


        public override void Fraqueza(PokemonBase pokemon)
        {
            if(pokemon.Tipo == "agua")
            {
                this.Ataque -= 5;
                this.Defesa -= 3;
            }
            
        }
        public override void Vantagem(PokemonBase pokemon)
        {
            if(pokemon.Tipo == "planta")
            {
                this.Ataque += 5;
                this.Defesa += 2;
            }
        }




    }
}
