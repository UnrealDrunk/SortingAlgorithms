using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingAlgorithms
{
    public static class TestClass
    {
        public static void ExecuteMethod()
        {
            WriteLine("Сколько чисел будем сортировать?");
            int N = Convert.ToInt32(ReadLine());
            WriteLine("Введите числа для сортировки:");
            int[] array = new int[N];
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = Convert.ToInt32(ReadLine());
            }


            //int[] array = new int[] { 5, 4, 3, 2, 1 };
            Write("Заявленный массив: ");
            for (int i = 0; i < array.Length; i++)
            {
                Write("{0}, ", array[i]);

            }
            Write("\n");

            BubbleSort(array);
            WriteLine("Массив после сортировки:");

            for (int i = 0; i < array.Length; i++)
            {
                Write("{0}, ", array[i]);

            }

            ReadLine();
        }

        private static int[] BubbleSort( int[] array)
        {
            int temp;
            for (int i = 0; i <array.Length; i++)
            {
                for(int j = i +1; j <array.Length; j++)
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
