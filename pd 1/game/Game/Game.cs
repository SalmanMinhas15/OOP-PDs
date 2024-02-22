using System;

namespace Game
{
    internal class Game
    {
        public int PlayerX;
        public int PlayerY;
        public int EnemyX1;
        public int EnemyY1;

        public Game()
        {
            PlayerX = 40;
            PlayerY = 20;
            EnemyX1 = 3;
            EnemyY1 = 5;
        }

        public void Maze()
        {
            Console.WriteLine("\n\n");
            Console.WriteLine("######################################################################");

            for (int row = 1; row < 19; row++)
            {
                Console.Write("#                                                                    #");
                Console.WriteLine();
            }

            Console.WriteLine("######################################################################");
        }
        

        public void MovePlayerLeft()
        {
            ErasePlayer();
            PlayerX = PlayerX - 1;
            printPlayer();
        }

        public void MovePlayerRight()
        {
            ErasePlayer();
            PlayerX = PlayerX + 1;
            printPlayer();
        }

        public void MovePlayerUp()
        {
            ErasePlayer();
            PlayerY = PlayerY - 1;
            printPlayer();
        }

        public void MovePlayerDown()
        {
            ErasePlayer();
            PlayerY = PlayerY + 1;
            printPlayer();
        }

        public void MoveEnemy()
        {
            EraseEnemy();
            EnemyX1 = EnemyX1 + 1;
            
            if (EnemyX1 == 50)
            {
                EnemyX1 = 2;
            }
            PrintEnemy();
        }

        public void printPlayer()
        {
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.WriteLine("P");
        }

        public void PrintEnemy()
        {
            Console.SetCursorPosition(EnemyX1, EnemyY1);
            Console.WriteLine("E");
        }

        public void EraseEnemy()
        {
            Console.SetCursorPosition(EnemyX1, EnemyY1);
            Console.WriteLine(" ");
        }

        public void ErasePlayer()
        {
            Console.SetCursorPosition(PlayerX, PlayerY);
            Console.WriteLine(" ");
        }
    }
}
