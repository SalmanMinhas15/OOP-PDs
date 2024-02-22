using EZInput;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Game
{
    internal class Program
    {
      static  Game game=new Game(); 
        static void Main(string[] args)
        {

            Console.Clear();
            game.Maze();
            game.printPlayer();
            while (true)
            {
                if (Keyboard.IsKeyPressed(Key.LeftArrow))
                {
                    game.MovePlayerLeft();
                }

                if (Keyboard.IsKeyPressed(Key.RightArrow))
                {
                    game.MovePlayerRight();
                }
                if (Keyboard.IsKeyPressed(Key.UpArrow))
                {
                    game.MovePlayerUp();
                }
                if (Keyboard.IsKeyPressed(Key.DownArrow))
                {
                    game.MovePlayerDown();
                }
                game.MoveEnemy();
                Thread.Sleep(300);
            } 
            
                
               
               

            
        }
       

    }
}
