using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    /// <summary>
    /// Класс, описывающий Сортировку Перемешиванием / Шейкерную (коктейльную сортировку) сортировку
    /// </summary>
    class Shakersort
    {






        /// <summary>
        /// Метод обмена значений между элементами
        /// </summary>
        /// <param name="e1">первый элемент</param>
        /// <param name="e2">второй элемент</param>
        private static void Swap(ref int e1, ref int e2)
        {
            var temp = e1;
            e1 = e2;
            e2 = temp;
        }


        private static int [] ShakerSort(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                bool IsFlagSwapped = false;
                for (int j = 0; j < array.Length - i -1; j++)
                {
                    if (array[j-1] >array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        IsFlagSwapped = true;
                    }
                }

                for(int j = array.Length -2 -i; j >i; j--)
                {
                    if (array[j-1] > array[j])
                    {
                        Swap(ref array[j - 1], ref array[j]);
                        IsFlagSwapped = true;

                    }
                }

                if (!IsFlagSwapped)
                {
                    break;
                }

            }

            return array;
        }






    }
}
