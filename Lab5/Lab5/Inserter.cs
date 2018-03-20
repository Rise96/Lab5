using System.Collections.Generic;
using System.Linq;

namespace Lab5
{
    class Inserter
    {
        public List<int> Insert(List<int> array)
        {
            int difference = DifferenceBetweenMaxAndMin(array);
            for (int i = 0; i < array.Count; i++)
            {
                if (array[i] < 0 && array[i] % 2 == 0)
                {
                    i++;
                    array.Insert(i, difference);
                }
            }
            return array;
        }

        public int DifferenceBetweenMaxAndMin(List<int> array)
        {
            int difference = array.Min() - array.Max();
            return difference;
        }
    }
}
