using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class MyFirstClass
    {


        public MyFirstClass()
        {
            Console.WriteLine("Вызван экземпляр класса");
        }

        public void Write()
        {
            Console.WriteLine(DateTime.Now);
        }




    }
}
