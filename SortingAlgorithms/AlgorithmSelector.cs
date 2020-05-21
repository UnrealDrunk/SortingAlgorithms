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

        private static bool IsContinued = false;

       public static void Start()
       {
            while (!IsContinued)
            {
                WriteInfo();
                CheckSelector();

            }
          
            
           
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
            
            while (!IsChosen)
            {
                bool IsNumber = false;
                int selector=0;
                while (!IsNumber)
                {
                    if(Int32.TryParse(ReadLine(), out selector))
                    {
                        IsNumber = true;
                    }
                    else
                    {
                        WriteLine("Некорректный ввод, предполагается только ввод чисел");
                        WriteInfo();
                    }
                }
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

        /// <summary>
        /// Метод контроля продолжения / завершения программы
        /// </summary>
        /// <returns>выбор - завершить / продолжить </returns>
        private static bool ContinueToExecute()
        {
            bool IsCorrectChosen = false;
            while (!IsCorrectChosen)
            {
                Write("Продолжить выполнение программы? \n" +
                    "ДА - нажмите 1 \n" +
                    "НЕТ - нажмите 2 \n");
                WriteLine("Ваш выбор?: ");

                int decision = Convert.ToInt32(ReadLine());
                switch (decision)
                {
                    case 1:
                        WriteLine("Программа продолжает работу");
                        IsContinued = true;
                        IsCorrectChosen = true;
                        break;
                    case 2:
                        WriteLine("Программа прекращает работу");
                        IsContinued = false;
                        IsCorrectChosen = true;
                        break;
                    default:
                        WriteLine("Некорректный выбор, используйте только клавиши 1 или 2");
                        break;
                    
                }
            }
            return IsContinued;
        }



       



      


    }
}
