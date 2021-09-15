using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_LadderProb
{
    class UC5
    {
        public int nextposition(int a, int b)   // implemenation of nextposition function.
        {
            switch (a + b)
            {               // creting ladders at 8 15 42 66 2
                case 8:
                    Console.WriteLine("Woww!! You Got Ladder at position 8 and goes up to 31");
                    return 31;
                case 15:
                    Console.WriteLine("Woww!! You Got Ladder at position at 15 goes up to 97");
                    return 97;
                case 42:
                    Console.WriteLine("Woww!! You Got Ladder at position at 42 goes up to 81");
                    return 81;
                case 66:
                    Console.WriteLine("Woww!! You Got Ladder at position at 66 goes up to 87 ");
                    return 87;
                // creating snakes
                case 24:
                    Console.WriteLine("oh! noo :( You Got Snake at position 24 goes down to position 1");
                    return 1;
                case 55:
                    Console.WriteLine("oh! noo :( You Got Snake at position 55 goes down to position 13");
                    return 13;
                case 71:
                    Console.WriteLine("oh! noo :( You Got Snake at position 71 goes down to position 29");
                    return 29;
                case 88:
                    Console.WriteLine("oh! noo :( You Got Snake at position 88  goes down to position 54");
                    return 54;
                case 99:
                    Console.WriteLine("oh! noo :( You Got Snake at position 99  goes down to position 6");
                    return 6;
                default:
                    return (a + b);
            }


        }
    }
}
