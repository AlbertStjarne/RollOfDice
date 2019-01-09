using System;
namespace _13_RollOfDice
{
    public class Dies
    {
        static Random rand = new Random();

        public int DieRoll()
        {

            return rand.Next(1, 7);
        }


    }
}
