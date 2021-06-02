using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pokemon.Tipos;
using Pokemon.Pokedex;
namespace Pokemon
{
    class Program
    {
        static void Main(string[] args)
        {
            //intro
            Arte arte = new Arte();
            arte.artPokemonIntro();
            Console.WriteLine("Pressione enter para continuar");
            Console.ReadLine();

            //jogador1
            Charmander charmander = new Charmander();
            Console.WriteLine("Digite o nome do Jogador 1: ");
            string nomeJogador1 = Console.ReadLine();
            Jogador marcelo = new Jogador(nomeJogador1, charmander);
       
            arte.Charmander();
            Console.WriteLine("Pokemon " + marcelo.NomePlayer + " CHARMANDER");

            //jogador2
            Bulbassauro bulbassaur = new Bulbassauro();
            Console.WriteLine("Digite o nome do jogador 2");
            string nomeJogador2 = Console.ReadLine();
            Jogador patricia = new Jogador(nomeJogador2, bulbassaur);
            arte.Bulbassauro();
            Console.WriteLine("Pokemon" + patricia.NomePlayer +" BULBASSAURO");

            Console.WriteLine("Iniciando Luta");

            Luta luta = new Luta(marcelo,patricia);
            luta.Lutar();
            Console.ReadLine();

        }
    }
}
