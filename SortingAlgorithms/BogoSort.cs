using System;
using static System.Console;


namespace SortingAlgorithms
{
    /// <summary>
    /// Класс описывающий работу Случайной сортировки
    /// </summary>
    public static class BogoSort
    {
        /// <summary>
        /// Начать выполнение случайной сортировки
        /// </summary>
        public static void RunSortMethod()
        {
            
            AutomaticArrayFormation automatic = new AutomaticArrayFormation();
            int[] array = automatic.ConstructArray();

        
            WriteLine("Отсортированный массив методом случайной сортировки: {0}", string.Join(", ", ExecuteBogoSort(array)));

            ReadLine();

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
