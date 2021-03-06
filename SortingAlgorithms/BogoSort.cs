﻿using System;
using static System.Console;


namespace SortingAlgorithms
{
    /// <summary>
    /// Класс описывающий работу Случайной сортировки, один из самых неэффективных алгоритмов
    /// </summary>
    public static class BogoSort
    {
       /// <summary>
       /// Начать выполенение случайной сортировки
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


            WriteLine("Отсортированный массив методом случайной сортировки: {0}", string.Join(", ", ExecuteBogoSort(array)));


            WriteLine("На выполнение программы было затрачено {0} миллисекунд", sw.ElapsedMilliseconds);

            string info = "Операция № " + DataOfOps.ReturnNumOfOps() + "- произведена сортировка массива СЛУЧЫЙНЫМ МЕТОДОМ," +
                " состоящего из " + incomingArray.LongLength +" чисел "+
                " Затраченное время на проведение операции " + sw.ElapsedMilliseconds + " миллисекунд";

            DataOfOps.AddInfoToList(info);
            DataOfOps.UppendNumOfOps();

        }

        /// <summary>
        /// Метод проверяет упорядоченность массива
        /// </summary>
        /// <param name="sortedArray">Массив, который требуется проверить</param>
        /// <returns>истина/ложь</returns>
        private static bool IsSorted(int[] sortedArray)
        {
            for (int i = 0; i < sortedArray.Length - 1; i++)
            {
                if (sortedArray[i] > sortedArray[i+1])
                {
                    return false;
                }
            }
            return true;
        }
        

        /// <summary>
        /// Метод перемешивания элементов массива
        /// </summary>
        /// <param name="arrayToSort">Массив, котрый необходимо перемешать</param>
        /// <returns>Массив с перемешанными элементами</returns>
        private static int[] RandomPermutation(int[] arrayToSort)
        {
            Random random = new Random();
            var numOfArrayElems = arrayToSort.Length;
            while (numOfArrayElems > 1)
            {
                numOfArrayElems--;
                var iterratedArrayElem = random.Next(numOfArrayElems + 1);
                var tempArrayElem = arrayToSort[iterratedArrayElem];
                arrayToSort[iterratedArrayElem] = arrayToSort[numOfArrayElems];
                arrayToSort[numOfArrayElems] = tempArrayElem;
            }

            return arrayToSort;
        }


        /// <summary>
        /// Случайная сортировка
        /// </summary>
        /// <param name="arrayToSort"> Массив, который требуется отсортировать</param>
        /// <returns>Отсортированный массив методом случанйой сортровки</returns>
        private static int[] ExecuteBogoSort(int[] arrayToSort)
        {
            while (!IsSorted(arrayToSort))
            {
                arrayToSort = RandomPermutation(arrayToSort);
            }

            return arrayToSort;
        }



    }
}
