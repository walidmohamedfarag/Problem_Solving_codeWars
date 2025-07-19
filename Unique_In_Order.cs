
namespace ProblemSolving
{
    internal class Unique_In_Order
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> values)
        {
            /*
             * Implement the function unique_in_order which takes as argument a sequence
             * and returns a list of items without any elements with the same value next to each other and preserving the original order of elements.
             */

            List<T> itemToList = values.ToList();
            for (int index = values.Count() - 1; index > 0; index--)
            {
                if (itemToList[index].Equals([itemToList[index - 1]))
                {
                    itemToList.RemoveAt(index);
                }
            }
            return itemToList;

            /*
             * another solution:
             
            T previous = default(T);
            foreach(var item in values)
            {
                if(!item.Equals(previous))
                {
                    previous = item;
                    yield return previous;
                }
            }
            */
        }
    }
}
