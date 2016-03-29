using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace c_testing_dots
{
    class Class1
    {
        static void Main()
        {
           
            Game newboard = new Game(4,4);
            Console.WriteLine("Drawing board");
            newboard.DrawBoard();

        }
    }


    public class Game
    {
        private int x, y;
        //private int[] table;
        private List<int[]> player1moves = new List<int[]>();
        private List<int[]> player2moves = new List<int[]>();
        private List<string> board = new List<string>();


        public Game()
        {
            x = 4;
            y = 4;
            CreateBoard();
        }

        public Game(int input_x, int input_y)
        {
            x = input_x;
            y = input_y;
            CreateBoard();
        }

        private void CreateBoard()
        {
            int board_nums = 0;
            string str = "";
            string empty_line = new String( ' ', x * 6); 
            for (int i = 0; i < y; i++)
            {
                for (int j = 0; j < x; j++)
                {
                    str += board_nums.ToString().PadLeft(6, ' ');
                    board_nums++;
                }
                board.Add(str);
                board.Add(empty_line);
                str = "";
            }
        }

        public void DrawBoard()
        {
            
            foreach (var str in board)
            {
                Console.WriteLine(str);
            }
            //foreach (var ary in player1moves)
           // {

           // }

        }
    }

}
