using System;

namespace _13_RollOfDice
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var die1 = new Dies();
            var die2 = new Dies();

            int[] stats = new int[13];
            int[,] rolls = new int[7, 7];

            Console.WriteLine("Please enter how many times you want to roll the dice: ");
            var n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                var die1Value = die1.DieRoll();
                var die2Value = die2.DieRoll();

                var sum = die1Value + die2Value;
                stats[sum] += 1;
            }

        }
    }
}
