using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Pokedex;
using Pokemon.Tipos;

namespace Pokemon
{
    public class Jogador
    {
        public string NomePlayer { get; }
        public PokemonBase Pokemon { get; }

        public Jogador(string nome, PokemonBase pokemon)
        {
            NomePlayer = nome;
            Pokemon = pokemon;

        }

    }
}
