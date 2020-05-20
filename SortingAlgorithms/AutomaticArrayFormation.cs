using System;
using static System.Console;

namespace SortingAlgorithms
{
    public class AutomaticArrayFormation
    {

        //приватные переменные

        private bool IsNumber = false; // Для проверки корректности ввода числа
        private int arrayLength = 0; // Для хранения длинны массива
        private Random random = new Random();// переменная генерации случайных чисел
    
 
        //

        /// <summary>
        /// Метод автоматического формирования массива
        /// </summary>
        public int [] ConstructArray()
        {
           

            Write("Определите размер массива, введите число: ");
            
            while (IsNumber == false)
            {
                if(Int32.TryParse(ReadLine(),out arrayLength))
                {
                    WriteLine("Размер массива определен в количестве {0} чисел", Math.Abs(arrayLength));
                    IsNumber = true;
                }
                else
                {
                    WriteLine("Введенная строка не является числом, попробуйте ещё раз");
                    Write("Определите размер массива, введите число: ");

                }
            }

            int[] array = new int[arrayLength];

            for (int number = 0; number < array.Length; number++)
            {
               
                array[number] = random.Next(1, arrayLength);
            }

            Write("Сгенерирован новый массив: ");
            foreach (int num in array)
                Write("{0}, ", array[num]);

            Write("\n");

            return array;

        }

      



    }
}
