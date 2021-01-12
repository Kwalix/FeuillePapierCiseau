using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace FeuillePapierCiseau
{
    class Game
    {
        // Create Global Vars
        string[] rockPaperScissor = new string[] { "Rock", "Paper", "Scissor" }; // Creating Dict
        ushort uChoice;
        ushort comChoice;
        string tmp;

        // Method For Creating a new Game
        private void NewGame(string userName)
        {
            ushort userLives = 3;
            ushort comLives = 3;
            Console.WriteLine($"Bonjour {userName}");
            Console.WriteLine($"Vous commencer avec {userLives}");
        }

        private void Choice()
        {
            // Bot Choice
            Random randChoice = new Random();
            comChoice = (ushort)randChoice.Next(0, rockPaperScissor.Length - 1);
            // End Bot Choice
            Console.WriteLine("\nFeuille Papier ou Ciseau");
            Console.WriteLine("\n1: Feuille\n2: Papier\n3: Ciseau");
            Console.WriteLine("\nVotre Choix >> ");
            tmp = Console.ReadLine();
            try
            {
                uChoice = Byte.Parse(tmp);
            } catch (Exception ex)
            {
                Console.WriteLine($"\nErreur l\'entrer de l\'utilisateur et incorrecte !\n Erreur : {ex.Message}");
                Choice(); // Recalling 'Choice' method if exception raised 
            }
        }
        private void RockPaperScissor()
        {
            if (rockPaperScissor[uChoice] == rockPaperScissor[comChoice])
            {
                // TODO
            }
        }
    }
}
