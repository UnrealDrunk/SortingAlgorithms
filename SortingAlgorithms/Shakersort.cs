using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingAlgorithms
{
    /// <summary>
    /// Класс, описывающий Сортировку Перемешиванием / Шейкерную (коктейльную сортировку) сортировку
    /// </summary>
    public class Shakersort
    {


        /// <summary>
        /// Начать сортировку Методом Перемешивания / Шейкерным методом
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



            ExecuteShakerSort(array);
            Write("Отсортированный массив методом СОРТИРОВКИ ПЕРЕМЕШИВАНИЕМ: ");
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

            string info = "Операция № " + DataOfOps.ReturnNumOfOps() + "- произведена сортировка массива МЕТОДОМ ПЕРЕМЕШИВАНИЯ," +
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
        /// Сортировка перемешиванием / шейкерная сортировка
        /// </summary>
        /// <param name="array">Массив, который требуется отсортировать</param>
        /// <returns>Отсортированный массив</returns>
        private static int [] ExecuteShakerSort(int[] array)
        {
            for (int i = 0; i < array.Length/2; i++)
            {
                bool IsFlagSwapped = false;
                for (int j = 0; j < array.Length - i -1; j++)
                {
                    if (array[j] >array[j+1])
                    {
                        Swap(ref array[j], ref array[j+1]);
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
