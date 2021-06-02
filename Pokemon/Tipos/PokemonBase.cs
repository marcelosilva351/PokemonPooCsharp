using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon.Tipos
{
    public abstract class PokemonBase
    {
        public string Nome { get; }
        public int Ataque { get; protected set; }
        public int Defesa { get; protected set; }
        public int Vida { get; set; }
        public string Tipo { get; protected set; }
        public bool Defender { get; set; }
        public PokemonBase(string nome, string tipo)
        {
            Nome = nome;
            Ataque = 20;
            Defesa = 5;
            Vida = 100;
            Tipo = tipo;
        }

        public abstract void Vantagem(PokemonBase pokemon);
        public abstract void Fraqueza(PokemonBase pokemon);
    }
}
