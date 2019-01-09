using System;
namespace _13_RollOfDice
{
    public class Dies
    {

        public int DieRoll()
        {
            Random rand = new Random();
            return rand.Next(1, 7);
        }


    }
}
