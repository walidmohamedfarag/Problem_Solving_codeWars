
namespace multiplesOfNumbers
{
    internal class Find_the_smallest
    {
        public static long[] Smallest(long digit)
        {
            char[] digitChar = digit.ToString().ToCharArray();
            long smallestDigit = digit; 
            int fromIndex = 0;
            int toIndex = 0;

            for (int forindex = 0; forindex < digitChar.Length; forindex++)
            {
                for (int toindex = 0; toindex < digitChar.Length; toindex++)
                {
                    if (forindex == toindex) continue;

                    List<char> chars = digitChar.ToList();
                    char tempValue = chars[forindex];
                    chars.RemoveAt(forindex);
                    chars.Insert(toindex, tempValue);

                    long currentDigit = long.Parse(new string(chars.ToArray()));

                    if (currentDigit < smallestDigit ||
                        (currentDigit == smallestDigit &&
                         (forindex < fromIndex || (forindex == fromIndex && toindex < toIndex))))
                    {
                        smallestDigit = currentDigit;
                        fromIndex = forindex;
                        toIndex = toindex;
                    }
                }
            }

            return new long[] { smallestDigit, fromIndex, toIndex };
        }
    }
}
