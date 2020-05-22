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
        public static void RunSortMethod()
        {
            System.Diagnostics.Stopwatch sw = new System.Diagnostics.Stopwatch(); // для измерения времени, затраченного на выполение программы
            sw.Start();


            int[] incomingArray = AlgorithmSelector.Array;

            int[] array = new int[incomingArray.Length];

            for (int i = 0; i < incomingArray.Length; i++)
            {
                array[i] = incomingArray[i];
            }


      
            ExecuteBubbleSort(array);
            Write("Отсортированный массив методом СОРТИРОВКИ ПУЗЫРЬКОМ: ");
            for (int i = 0; i < array.Length; i++)
            {
                if(i == array.Length - 1)
                {
                    Write("{0} \n", array[i]);
                }
                else
                {
                    Write("{0}, ", array[i]);
                }
            }
            

            WriteLine("На выполнение программы было затрачено {0} миллисекунд", sw.ElapsedMilliseconds);

         

        }


        /// <summary>
        /// Сортировка пузыром
        /// </summary>
        /// <param name="array">Массв, который необходимо отсортировать</param>
        /// <returns></returns>
        private static int[] ExecuteBubbleSort(int[] array)
        {
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        temp = array[i];
                        array[i] = array[j];
                        array[j] = temp;
                    }
                }
            }
            return array;
        }
    }
}
