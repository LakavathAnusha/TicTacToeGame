using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicTacToeGame
{
    class Program
    {
        int player = 2;
        int input = 0;
        bool inputCorrect = true;
        static char[,] playField = { { '1', '2', '3' }, { '4', '5', '6' }, { '7', '8', '9' } };
        static void Main(string[] args)
        {
            int player = 2;
            int input = 0;
            bool inputCorrect = true;
            DrawBoard();
            EnterXorO();
           
            Console.ReadLine();
                
        }

        private static void EnterXorO()
        {
            do
            {
                if (player == 2)
                {
                    player = 1;
                }
                else if (player == 1)
                {
                    player = 2;
                }
                switch (player)
                {
                    case 1:
                        switch (input)
                        {
                            case 1: playerField[0, 0] = x; break;
                            case 2: playerField[0, 1] = x; break;
                            case 3: playerField[0, 2] = x; break;
                            case 4: playerField[1, 0] = x; break;
                            case 5: playerField[1, 1] = x; break;
                            case 6: playerField[1, 2] = x; break;
                            case 7: playerField[2, 0] = x; break;
                            case 8: playerField[2, 1] = x; break;
                            case 9: playerField[2, 2] = x; break;
                        }
                        break;
                    case 2:
                        switch (input)
                        {
                            case 1: playerField[0, 0] = 'o'; break;
                            case 2: playerField[0, 1] = 'o'; break;
                            case 3: playerField[0, 2] = 'o'; break;
                            case 4: playerField[1, 0] = 'o'; break;
                            case 5: playerField[1, 1] = 'o'; break;
                            case 6: playerField[1, 2] = 'o'; break;
                            case 7: playerField[2, 0] = 'o'; break;
                            case 8: playerField[2, 1] = 'o'; break;
                            case 9: playerField[2, 2] = 'o'; break;
                        }
                        break;
                }
            } while (true);
        }

        private static void DrawBoard()
        {
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} |  {1}| {2} ",1,2,3);
            Console.WriteLine("___|___|__");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} |  {1}| {2} ",4,5,6);
            Console.WriteLine("___|___|__");
            Console.WriteLine("   |   |   ");
            Console.WriteLine(" {0} |  {1}| {2} ",7,8,9);
            Console.WriteLine("   |   |   ");

        }
    }
}
