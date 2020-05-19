using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {

            //BogoSort.RunSortMethod();
            //AutomaticArrayFormation.ConstructArray();
            AutomaticArrayFormation auto = new AutomaticArrayFormation();

            int[] array = auto.ConstructArray();

            foreach (int num in array)
                Console.Write("{0}, ", array[num]);




        }
    }
}
