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

            AutomaticArrayFormation auto = new AutomaticArrayFormation();
            int[] array = auto.ConstructArray();

            foreach (var i in array)
                Write("{0}, ", array[i]);

            int[] array2 = new int[array.Length];

            for(int i =0; i < array.Length; i++)
            {
                array2[i] = array[i];
            }

            //WriteLine("Отсортированный массив методом сортировки пузырьком: {0}", string.Join(", ", ExecuteBubbleSort(array)));
            ExecuteBubbleSort(array);
            Write("Отсортированный массив методом сортировки пузырьком: ");
            foreach (var i in array)
                Write("{0}, ", array[i]);
            Write("\n");

            Write("Резервный массив: ");
            foreach (var i in array2)
                Write("{0}, ", array2[i]);
            Write("\n");

            WriteLine("На выполнение программы было затрачено {0} миллисекунд", sw.ElapsedMilliseconds);

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
        private static void ExecuteBubbleSort( int[] array)
        {
            int arrayLength = array.Length;

            for(int i =0; i <arrayLength; i++)
            {
                for(int j =i+1; j <arrayLength; j++)
                {
                    if(array[i] > array[j])
                    {
                        SwapElems(ref array[i], ref array[j]);
                    }
                }
            }

        }


    }
}
