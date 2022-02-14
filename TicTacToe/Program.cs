using System;
using System.Threading;

namespace TicTacToe
{
     class Program
    {
        static char[] arr = { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9' };
        static int player = 1;
        static int choice;
        static int flag = 0;

        static void Main(string[] args)
        {
            {
                Console.Clear();
                Console.WriteLine("Plyer1:X and plyer2:0");
                Console.WriteLine("\n");
                if(player%2==0)
                {
                    Console.WriteLine("player 2 chance ");

                }
                else
                {
                    Console.WriteLine("player 1 chance");
                }
            }
            Console.WriteLine("player plying");
            
        }
    }
}
