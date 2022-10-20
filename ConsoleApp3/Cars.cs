using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Cars
    {

        public string Model;  /*Модель*/
        public int Year;     /* Год выпуска */
        public string[] Colors;  /*Цвет кузова */

        public double Motor;   /*Литраж мотора */



        public Cars()
        {
            Model = "Неизвестно";
            Year = 0 ;
            Motor = 0;

        }


        public string GetInfo()

        {
            string colors = "";
            foreach (var item in Colors)
            {
                colors = $"{colors} {item},";
            }


            return $"Модель - {Model}. \n Год выпуска - {Year}. \n Литраж мотора - {Motor}. \n Доступные цвета кузова - {colors}";


        }



    }
}
