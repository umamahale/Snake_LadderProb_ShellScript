using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_LadderProb
{
    class UC6
    {
        
static int findM(string s, int x)
        {

            // Initialize cnt as 0
            int cnt = 0;

            // Iterate in the string
            for (int i = 0; i < s.Length; i++)
            {

                // Check for numbers other than x
                if (s[i] - '0' != x)
                    cnt++;
            }
            return cnt;
        }

        // Driver code
        public static void Main()
        {
            String s = "3662123";
            int x = 6;
            Console.Write(findM(s, x));
        }
    }

}

