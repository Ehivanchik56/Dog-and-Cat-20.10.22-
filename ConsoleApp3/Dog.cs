using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Dog
    {
        public string Klichka;
        public int Age;
        public int Health;

        public string talk()
        {
            return ("Гав!Гав!Гав");
        }
        public int getHealth(int x)
        {
            Console.WriteLine("Что бы пополнить здоровье питомца введите значение HP");
            x = Convert.ToInt32(Console.ReadLine());
            Health = Health + x;
            return Health;

        }
        public int GetDamage(int x) 
        {
            Console.WriteLine("Что бы отнять здоровье питомца введите значение HP");
            x = Convert.ToInt32(Console.ReadLine());
            Health = Health - x;
            return Health;

        }
        public string GetInfo()
        {
            if (Health > 0)
            {
                return $"Кличка питомца - {Klichka}, Возраст питомца - {Age}, Здоровье - {Health}, Питомец - жив";
            }
            else
            {
                return $"Питомец {Klichka} - мертв";
            }
        }
    }   
}
