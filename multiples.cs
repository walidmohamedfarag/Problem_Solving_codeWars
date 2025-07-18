
namespace multiplesOfNumbers
{
    internal class multiples
    {
        /*
          If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. The sum of these multiples is 23.

          Finish the solution so that it returns the sum of all the multiples of 3 or 5 below the number passed in.

          Additionally, if the number is negative, return 0.

          Note: If the number is a multiple of both 3 and 5, only count it once.
         */
        public static int Multiples(int numbers)
        {
            int calcMultiples = 0;
            if (numbers < 0)
                return 0;
            for (int index = 3; index < numbers; index++)
            {
                if (index % 3 == 0)
                    calcMultiples += index;
                if(index % 5 == 0 && index % 3 !=0)
                    calcMultiples += index;
            }
            return calcMultiples;

        }
    }
}
