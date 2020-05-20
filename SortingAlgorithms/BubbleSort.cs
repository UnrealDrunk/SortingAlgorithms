using System;
using static System.Console;

namespace SortingAlgorithms
{
    /// <summary>
    /// Класс описывающий алгоритм сортировки пузырьком
    /// </summary>
    public static class BubbleSort
    {
        /// <summary>
        /// Начать сортировку Пузырьковым методом
        /// </summary>
        /// <param name="incomeArray">Массив, который требуется отсортировать</param>
        public static void RunSortMethod(int[]incomeArray)
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); // для измерения времени, затраченного на выполение программы
            sw.Start();

            int[] array = incomeArray;


            WriteLine("Отсортированный массив методом сортировки пузырьком: {0}", string.Join(", ", ExecuteBubbleSort(array)));

            WriteLine("На выполнение программы было затрачено {0} миллисекунд", sw.ElapsedMilliseconds);

            ReadLine();
        }

        /// <summary>
        /// Метод обмена значениями между элементами
        /// </summary>
        /// <param name="e1">рссматриваемый эемент</param>
        /// <param name="e2">последуюий элемент</param>
        private static void SwapElems(ref int e1, ref int e2)
        {
            int temp = e1;
            e1 = e2;
            e2 = temp;
        }

        /// <summary>
        /// Сортировка пузыром
        /// </summary>
        /// <param name="array">Массв, который необходимо отсортировать</param>
        /// <returns></returns>
        private static int[] ExecuteBubbleSort( int[] array)
        {
            int arrayLength = array.Length;

            for(int i =0; i <arrayLength - 1; i++)
            {
                for(int j =0; j <arrayLength - i -1; j++)
                {
                    if(array[j] > array[j + 1])
                    {
                        SwapElems(ref array[j], ref array[j + 1]);
                    }
                }
            }

            return array;
        }


    }
}
