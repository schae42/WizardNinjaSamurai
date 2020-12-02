﻿using System;

namespace WizardNinjaSamurai
{
    class Program
    {
        static void Main(string[] args)
        {
            var player1 = new Wizard("Eevee", new DeathBlow());
            var player2 = new Samurai("Cloud", new Fireball());
            Console.WriteLine(player1);
            Console.WriteLine(player2);
            player2.UseWeapon(player1);
            player1.UseWeapon(player2);
            Samurai.HowMany();
        }
    }
}