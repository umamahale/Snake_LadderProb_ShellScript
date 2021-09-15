using System;
using System.Collections.Generic;
using System.Text;

namespace Snake_LadderProb
{
    class UC2
    {
        private Random myDie = new Random();
        public int RollStandardDie()
        {
            return myDie.Next(1, 6 + 1);
        }
        private void MyButton_Click(object sender, EventArgs ew)
        {
            int[] dice = new int[3];
            for (int i = 0; i < dice.Length; i++)
            {
                dice[i] = RollStandardDie();
            }
            Array.Sort(dice);
        }
    }
}

