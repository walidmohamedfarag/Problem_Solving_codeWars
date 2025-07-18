
namespace ProblemSolving
{
    internal class Array_diff
    {
        /*
         * Implement a function that computes the difference between two lists.
         * The function should remove all occurrences of elements from the first list (a) that are present in the second list (b).
         * The order of elements in the first list should be preserved in the result.
         */
        public static int[] ArrayDiff(int[] one, int[] two)
        {
            List<int> listOne = one.ToList();
            List<int> listTwo = two.ToList();
            for ( int indexOne = listOne.Count - 1; indexOne >= 0; indexOne--)
            {
                if (listTwo.Contains(listOne[indexOne]))
                    listOne.RemoveAt(indexOne);            }
            return listOne.ToArray();
        }
    }
}
