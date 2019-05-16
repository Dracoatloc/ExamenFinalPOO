using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prob4ExamenFinal.Classes;

namespace Prob4ExamenFinal
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 3, 5, 1, 2, 4};

            
            SelectionSortG.selectionSort<int>(arr);

            for (int i = 0; i < arr.Length; i++)
                Console.WriteLine(arr[i]);
        }
    }
}
