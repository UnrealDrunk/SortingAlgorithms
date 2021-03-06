﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace SortingAlgorithms
{
    public static  class AlgorithmSelector
    {

        private static bool IsContinued = true;
        public static int[] Array { get; set; }

       public static void Start()
       {

            AutomaticArrayFormation auto = new AutomaticArrayFormation();
            Array = auto.ConstructArray();

            while (IsContinued)
            {
                WriteInfo();
                CheckSelector();
                ContinueToExecute();

            }

            WriteLine("\nСтатистика операций:");
            DataOfOps.PrintList();
            ReadLine();
           
       }

        /// <summary>
        /// Метод описания для пользователя возможного выбора действий в программе
        /// </summary>
        private static void WriteInfo()
        {
            Write("Выберите один из следующих алгоритмов сортировки:\n" +
               "нажимте 1 для СЛУЧАЙНОЙ СОРТИРОВКИ \n" +
               "нажмите 2 для СОРТИРОВКИ ПУЗЫРЬКОМ \n" +
               "нажмите 3 для СОРТИРОВКИ ПЕРЕМЕШИВАНИЕМ \n" +
               "нажмите 4 для СОРТИРОВКИ ВСТАВКАМИ \n"+
               "Ваш выбор?: ");

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
                        WriteLine("Выбран алгоритм СЛУЧАЙНОЙ СОРТИРОВКИ");
                        BogoSort.RunSortMethod();
                        IsChosen = true;
                        break;
                    case 2:
                        WriteLine("Выбран алгоритм СОРТИРОВКИ ПУЗЫРЬКОМ");
                        BubbleSort.RunSortMethod();
                        IsChosen = true;
                        break;
                    case 3:
                        WriteLine("Выбран алгоритм СОРИРОВКИ ПЕРЕМЕШИВАНИЕМ");
                        Shakersort.RunSortMethod();
                        IsChosen = true;
                        break;
                    case 4:
                        WriteLine("Выбран алгоритм СОРИРОВКИ ВСТАВКАМИ");
                        InsertionSort.RunSortMethod();
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
                bool IsNumber = false;
                int decision = 0;

             
                while (!IsNumber)
                {
                    Write("Продолжить выполнение программы? \n" +
                 "ДА - нажмите 1 \n" +
                 "НЕТ - нажмите 2 \n" +
                 "Ваш выбор?: ");

                    if (Int32.TryParse(ReadLine(), out decision))
                    {
                        IsNumber = true;
                    }
                    else
                    {
                        WriteLine("Некорректный ввод данных, необходимо ввести  1 или 2 ");
                    }
                }

          
                switch (decision)
                {
                    case 1:
                        WriteLine("Программа продолжает работу");
                        IsContinued = true;
                        IsCorrectChosen = true;
                        ConstructNewArray();
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


        /// <summary>
        /// Метод определяет, продолжить ли работу с текущим массивом или сгенерировать новый
        /// </summary>
        private static void ConstructNewArray()
        {
            bool IsCorrectChosen = false;

            while (!IsCorrectChosen)
            {
                bool IsNumber = false;
                int decision = 0;

                while (!IsNumber)
                {
                    Write("Создать новый массив или использовать уже созданный далее?\n" +
                         "Нажмите 1 для создания нового массива\n" +
                         "Нажмите 2 для продолжения использования текущего массива\n" +
                         "Ваш выбор?: ");

                    if (Int32.TryParse(ReadLine(), out decision))
                    {
                        IsNumber = true;
                    }
                    else
                    {
                        WriteLine("Некорректный ввод данных, необходимо ввести  1 или 2 ");
                    }
                }


                switch (decision)
                {
                    case 1:
                        WriteLine("Инициируется создание нового массива");
                        AutomaticArrayFormation auto = new AutomaticArrayFormation();
                        Array = auto.ConstructArray();
                        IsCorrectChosen = true;
                        break;
                    case 2:
                        WriteLine("Продолжатся работа с текущим массивом");
                        IsCorrectChosen = true;
                        break;
                    default:
                        WriteLine("Некорректный выбор, используйте только клавиши 1 или 2");
                        break;

                }
            }

           

        }
       



      


    }
}
