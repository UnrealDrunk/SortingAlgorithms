using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public static class DataOfOps
    {
        private static int NumofOperations = 1;
        private static List<string> dataList = new List<string>();


        /// <summary>
        /// Вывести список данных на экран
        /// </summary>
        public static void PrintList()
        {
            foreach (string e in dataList)
                Console.WriteLine(e);
        }



        /// <summary>
        /// Добавление в список очередной записи
        /// </summary>
        /// <param name="info"></param>
        public static void AddInfoToList(string info)
        {
            dataList.Add(info);
        }


        /// <summary>
        /// Сообщить тукцщий порядковый номер записи данных
        /// </summary>
        /// <returns>Порядковый номер записи даных</returns>
        public static int ReturnNumOfOps()
        {
            return NumofOperations;
        }


        /// <summary>
        /// Перевод вверх счетчика номеров записей
        /// </summary>
        public static void UppendNumOfOps()
        {
            NumofOperations++;
        }




    }
}
