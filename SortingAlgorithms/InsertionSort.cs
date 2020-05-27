using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace SortingAlgorithms
{
    /// <summary>
    /// Класс описывающий работу алгоритма вставками
    /// </summary>
    public class InsertionSort
    {


        /// <summary>
        /// Начать сортировку Методом Вставок
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



            ExecuteInsertionSort(array);
            Write("Отсортированный массив методом СОРТИРОВКИ ВСТАВКАМИ: ");
            for (int i = 0; i < array.Length; i++)
            {
                if (i == array.Length - 1)
                {
                    Write("{0} \n", array[i]);
                }
                else
                {
                    Write("{0}, ", array[i]);
                }
            }


            WriteLine("На выполнение программы было затрачено {0} миллисекунд", sw.ElapsedMilliseconds);

            string info = "Операция № " + DataOfOps.ReturnNumOfOps() + "- произведена сортировка массива МЕТОДОМ ВСТАВОК," +
                 " состоящего из " + incomingArray.LongLength + " чисел " +
                 " Затраченное время на проведение операции " + sw.ElapsedMilliseconds + " миллисекунд";

            DataOfOps.AddInfoToList(info);
            DataOfOps.UppendNumOfOps();


        }




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

        /// <summary>
        /// Метод реализации алгоритма вставками / InsertionSort
        /// </summary>
        /// <param name="array">Массив, который требуется отсортировать</param>
        /// <returns>Остортированный массив</returns>
        private static int[] ExecuteInsertionSort(int[] array)
        {
            for (int i = 1; i < array.Length; i++)
            {
                int key = array[i];
                int j = i;
                while ((j > 1) && (array[j -1]) >key)
                {
                    Swap(ref array[j - 1], ref array[j]);
                    j--;
                }
                array[j] = key;
            }


            return array;
        }



    }
}
