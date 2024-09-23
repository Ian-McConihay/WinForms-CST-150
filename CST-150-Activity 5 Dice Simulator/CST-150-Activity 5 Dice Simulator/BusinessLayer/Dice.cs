/*
 * Ian McConihay
 * CST-150
 * Activity 5 Dice
 * Sep 22 2024
 * 
 */

namespace CST_150_Activity_5_Dice_Simulator.BusinessLayer
{
    public class Dice
    {
        private Random random;

        public Dice()
        {
            random = new Random();
        }

        /// <summary>
        /// Used to set to ints to random 1-6
        /// </summary>
        /// <returns></returns>A
        public (int die1, int die2) RollDice()
        {
            int die1 = random.Next(1, 7);
            int die2 = random.Next(1, 7);
            return (die1, die2);
        }
    }
}
