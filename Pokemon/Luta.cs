using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon
{
    public class Luta
    {
        public Jogador Jogador1 { get; }
        public Jogador Jogador2 { get; }

        public bool Defender { get; private set; }
        public Luta(Jogador jogador1, Jogador jogador2)
        {
            Jogador1 = jogador1;
            Jogador2 = jogador2;
        }


        public void Lutar()
        {
            while (true)
            {
                Console.WriteLine("Vez do: " + Jogador1.NomePlayer);
                Console.WriteLine("Pokemon " + Jogador1.NomePlayer + ": " + Jogador1.Pokemon.Nome);
                Console.WriteLine("[1] atacar");
                Console.WriteLine("[2] defender");
                int escolhaJogador1 = Convert.ToInt32(Console.ReadLine());
                if (escolhaJogador1 == 1)
                {
                    Console.WriteLine(Jogador1.Pokemon.Nome + " atacando " + Jogador2.Pokemon.Nome);
                    if (Jogador2.Pokemon.Defender)
                    {
                        Jogador2.Pokemon.Vida = (Jogador2.Pokemon.Vida - Jogador1.Pokemon.Ataque) + Jogador2.Pokemon.Defesa + 10;
                    }
                    else
                    {
                        Jogador2.Pokemon.Vida = (Jogador2.Pokemon.Vida - Jogador1.Pokemon.Ataque) + Jogador2.Pokemon.Defesa;
                    }

                    Console.WriteLine($"Vida do {Jogador1.NomePlayer}: {Jogador1.Pokemon.Vida}");
                    Console.WriteLine($"Vida do {Jogador2.NomePlayer}: {Jogador2.Pokemon.Vida}");
                    Jogador2.Pokemon.Defender = false;
                    if (Jogador1.Pokemon.Vida <= 0)
                    {
                        Console.WriteLine($"{Jogador2.NomePlayer} venceu!");
                        break;
                    }
                    else if (Jogador2.Pokemon.Vida <= 0)
                    {
                        Console.WriteLine($"{Jogador1.NomePlayer} venceu!");
                        break;
                    }
                }
                else if (escolhaJogador1 == 2)
                {
                    Jogador1.Pokemon.Defender = true;
                    Console.WriteLine("Defendendo");
                }
                else
                {
                    Console.WriteLine("Você não escolheu uma opção valida");
                    continue;
                }



                Console.WriteLine("Vez do: " + Jogador2.NomePlayer);
                Console.WriteLine("Pokemon " + Jogador2.NomePlayer + ": " + Jogador2.Pokemon.Nome);
                Console.WriteLine("[1] atacar");
                Console.WriteLine("[2] defender");
                int escolhaJogador2 = Convert.ToInt32(Console.ReadLine());
                if (escolhaJogador2 == 1)
                {
                    Console.WriteLine(Jogador2.Pokemon.Nome + " atacando " + Jogador1.Pokemon.Nome);
                    if (Jogador1.Pokemon.Defender)
                    {
                        Jogador1.Pokemon.Vida = (Jogador1.Pokemon.Vida - Jogador2.Pokemon.Ataque) + Jogador1.Pokemon.Defesa + 10;
                    }
                    else
                    {
                        Jogador1.Pokemon.Vida = (Jogador1.Pokemon.Vida - Jogador2.Pokemon.Ataque) + Jogador1.Pokemon.Defesa;
                    }

                    Console.WriteLine($"Vida do {Jogador1.NomePlayer}: {Jogador1.Pokemon.Vida}");
                    Console.WriteLine($"Vida do {Jogador2.NomePlayer}: {Jogador2.Pokemon.Vida}");
                    Jogador1.Pokemon.Defender = false;
                    if (Jogador1.Pokemon.Vida <= 0)
                    {
                        Console.WriteLine($"{Jogador2.NomePlayer} venceu!");
                        break;
                    }
                    else if (Jogador2.Pokemon.Vida <= 0)
                    {
                        Console.WriteLine($"{Jogador1.NomePlayer} venceu!");
                        break;
                    }
                }
                else if (escolhaJogador2 == 2)
                {
                    Jogador2.Pokemon.Defender = true;
                    Console.WriteLine("Defendendo");
                }
                else
                {
                    Console.WriteLine("Você não escolheu uma opção valida");
                    continue;
                    
                }

            }

        }
          
            

          


    }
        
  
}
