using System;
using jogo_rpg.src.Entities;

namespace jogo_rpg
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");
            
            
            Console.WriteLine($"{wizard.Attack(10)}");
            Console.WriteLine($"{wizard.Attack(1)}");
        }
    }
}
