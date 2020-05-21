using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingAlgorithms
{
    public static class AlgorithmSelector
    {

       public static void Start()
       {

            WriteInfo();
            CheckSelector();
            
           
       }

        /// <summary>
        /// Метод описания для пользователя возможного выбора действий в программе
        /// </summary>
        private static void WriteInfo()
        {
            Write("Выберите один из следующих алгоритмов сортировки:\n" +
               "нажимте 1 для Быстрой сортировки \n" +
               "нажмите 2 для Сортировки Пузырьком \n");

        }

        /// <summary>
        /// Метод выбора и запуска алгоритма сортировки
        /// </summary>
        private static void CheckSelector()
        {
            bool IsChosen = false;
            int selector;

            while (!IsChosen)
            {
                selector = Convert.ToInt32(ReadLine());
                switch (selector)
                {
                    case 1:
                        WriteLine("Выбран алгоритм случайной сортировки");
                        BogoSort.RunSortMethod();
                        IsChosen = true;
                        break;
                    case 2:
                        WriteLine("Выбран алгоритм Сортировки Пузырьком");
                        BubbleSort.RunSortMethod();
                        IsChosen = true;
                        break;
                    default:
                        WriteLine("Некорректный ввод данных попробуйте снова");
                        WriteInfo();
                        break;

                }
                
            }

        }



       



      


    }
}
