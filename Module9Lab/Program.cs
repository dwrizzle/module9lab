﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;

class Pokemon
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Type { get; set; }
    public int Level { get; set; }
}



class PokemonLINQLab
{
    static void Main()
    {
        //Sample data: list of Pokemon
        var pokemons = new List<Pokemon>
        {
            new Pokemon { ID = 1, Name = "Bulbasaur", Type = "Grass", Level = 15 },
            new Pokemon { ID = 2, Name = "Charmander", Type = "Fire", Level = 36 },
            new Pokemon { ID = 3, Name = "Squirtle", Type = "Water", Level = 10 },
            new Pokemon { ID = 4, Name = "Pikachu", Type = "Electric", Level = 22 },
            new Pokemon { ID = 5, Name = "Eevee", Type = "Normal", Level = 25 }
        };

        //LInQ Query to find Pokemon ready to eveolve (assuming level 16 for first evolution)
        var readyToEvolveQuery = from p in pokemons
                                 where p.Level >= 16
                                 orderby p.Level
                                 select p;

        //Execute the query and display the results
        Console.WriteLine("Pokemon Ready to Evolve:");
        foreach (var pokemon in readyToEvolveQuery)
        {
            Console.WriteLine($"Name: {pokemon.Name}, Type: {pokemon.Type}, Level: {pokemon.Level}");

        }
    }
}