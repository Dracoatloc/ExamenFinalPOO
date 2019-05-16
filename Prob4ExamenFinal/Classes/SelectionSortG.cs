using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prob4ExamenFinal.Classes
{
    class SelectionSortG
    {
        public static void selectionSort<T>(T[] array) where T: IComparable
        {
            T min;

            for (int i = 0; i < array.Length; i++)
            {
                min = array[i];
                int minId = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i].CompareTo(array[j]) < minId)
                    {
                        min = array[j];
                        minId = j;
                    }
                }
                // swapping
                T temp = array[i];
                array[i] = min;
                array[minId] = temp;
            }
        }
    }
}
