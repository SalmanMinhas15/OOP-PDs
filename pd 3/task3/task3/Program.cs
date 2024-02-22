using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using task3.BL;

namespace task3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shiritori game = new Shiritori();
            while (true)
            {
                startPage();
                game.play();
                if(game.gameOver)
                {
                    gameOverDisplay(game.words);
                    restartGame();
                    game.gameOver = false;
                }
            }
        }
        static void startPage()
        {
            Console.WriteLine("\nWelcome to shiritori game");
            Console.WriteLine("press any key to start game");
            Console.ReadKey();
        }
        static string word()
        {
            Console.WriteLine("\n\nThe initial word is salman\n");
            Console.Write("Enter a next word: ");
            string word = Console.ReadLine();
            return word;
        }
        static void gameOverDisplay(string[] words)
        {
            Console.Clear();
            Console.WriteLine("Game is Over\n\n");
            Console.WriteLine("The list of words is \n");
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
        }
        static void restartGame()
        {
            
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Press any key to start new game");
            Console.ReadKey();
             
        }
    }
}
