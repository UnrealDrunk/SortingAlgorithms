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
            //BubbleSort.RunSortMethod();

            MethodAccessor method = new MethodAccessor();
            method.SaveArray();
            int[] array = method.ShowArray();
            int[] array2 = method.ShowArray();

            BubbleSort.RunSortMethod(array2);
            BogoSort.RunSortMethod(array);






        }
    }
}
