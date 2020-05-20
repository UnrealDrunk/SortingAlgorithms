using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithms
{
    public class MethodAccessor
    {
        // секция приватных переменных

        private int[] SavedArray{ get; set; }

        /// <summary>
        /// Метод сохранения сгененрированного массива
        /// </summary>
        public void SaveArray()
        {
            AutomaticArrayFormation automatic = new AutomaticArrayFormation();
            SavedArray = automatic.ConstructArray();
            
        }


        /// <summary>
        /// Метод передачи сгенерированного массива
        /// </summary>
        /// <returns></returns>
        public int[] ShowArray()
        {
            
            return SavedArray;
        }



      


    }
}
