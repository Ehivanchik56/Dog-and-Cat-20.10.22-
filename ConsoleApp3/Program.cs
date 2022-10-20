using ConsoleApp3;
using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

internal class Program
{
     private static void Main(string[] args)
    {

        //Cars volvo = new Cars();

        //volvo.Year = 2028;

        //volvo.Motor = 3.5;

        //volvo.Model = "QX43";

        //volvo.Colors = new string[3];

        //volvo.Colors[0] = "Зеленый";
        //volvo.Colors[1] = "Синий";
        //volvo.Colors[2] = "Красный";

        //Cars Lada = new Cars();

        //Lada.Year = 1999;

        //Lada.Motor = 1.6;

        //Lada.Model = "2106";

        //Lada.Colors = new string[3];

        //Lada.Colors[0] = "Фиолетовый";
        //Lada.Colors[1] = "Боевая Классика";
        //Lada.Colors[2] = "Ржавчина с завода";


        //Console.WriteLine(volvo.GetInfo());

        //string fjf = volvo.GetInfo();
        //string[] words = fjf.Split('.');

        //foreach (var word in words)
        //{
        //  Console.WriteLine($"{word}");
        //}

        Console.WriteLine("Выберите питомца 1 - Собака, 2 - Кот");
        int v = Convert.ToInt32(Console.ReadLine());
        if (v == 1)
        {
            Dog Sobaka1 = new Dog();

            Sobaka1.Klichka = "Педик";
            Sobaka1.Age = 4;
            Sobaka1.Health = 100;
            int i = 0;
            Console.WriteLine(Sobaka1.talk());
            while (i < 5 && Sobaka1.Health > 0)
            {
                Console.WriteLine(Sobaka1.GetInfo());
                Console.WriteLine("Выберите: ударить или накормить \n \"1 - ударить, 2 - накормить\"");
                int z = Convert.ToInt32(Console.ReadLine());
                if (z == 1 && Sobaka1.Health > 0)
                {
                    Sobaka1.GetDamage(z);

                }
                else if (z == 2 && Sobaka1.Health > 0)
                {
                    Sobaka1.getHealth(z);
                }
                i++;
            }

            Console.WriteLine(Sobaka1.GetInfo());
        }
        else if (v== 2)
        {
            Cat cat1 = new Cat();
            cat1.Age = 4;
            cat1.Klichka = "Барсик";
            cat1.Health = 100;

            Console.WriteLine(cat1.talk());

            int k = 0;
            while (k < 5 && cat1.Health > 0)
            {
                Console.WriteLine(cat1.GetInfo());
                Console.WriteLine("Выберите: ударить или накормить \n \"1 - ударить, 2 - накормить\"");
                int z = Convert.ToInt32(Console.ReadLine());
                if (z == 1 && cat1.Health > 0)
                {
                    cat1.GetDamage(z);

                }
                else if (z == 2 && cat1.Health > 0)
                {
                    cat1.getHealth(z);
                }
                k++;
            }
            Console.WriteLine(cat1.GetInfo());
        }




        //Dog Sobaka1 = new Dog();

        //Sobaka1.Klichka = "Педик";
        //Sobaka1.Age = 4;
        //Sobaka1.Health = 100;
        //int i = 0;
        //Console.WriteLine(Sobaka1.talk());
        //while (i<5 && Sobaka1.Health > 0)
        //{
        //    Console.WriteLine(Sobaka1.GetInfo());
        //    Console.WriteLine("Выберите: ударить или накормить \n \"1 - ударить, 2 - накормить\"");
        //    int z = Convert.ToInt32(Console.ReadLine());
        //    if (z == 1 && Sobaka1.Health > 0)
        //    {
        //        Sobaka1.GetDamage(z);

        //    }
        //    else if (z == 2 && Sobaka1.Health > 0)
        //    {
        //        Sobaka1.getHealth(z);
        //    }
        //    i++;
        //}

        //Console.WriteLine(Sobaka1.GetInfo());

        //Cat cat1 = new Cat();
        //cat1.Age = 4;
        //cat1.Klichka = "Барсик";
        //cat1.Health = 100;

        //Console.WriteLine(cat1.talk());

        //int k = 0;
        //while (k < 5 && Sobaka1.Health > 0)
        //{
        //    Console.WriteLine(cat1.GetInfo());
        //    Console.WriteLine("Выберите: ударить или накормить \n \"1 - ударить, 2 - накормить\"");
        //    int z = Convert.ToInt32(Console.ReadLine());
        //    if (z == 1 && cat1.Health > 0)
        //    {
        //        cat1.GetDamage(z);

        //    }
        //    else if (z == 2 && cat1.Health > 0)
        //    {
        //        cat1.getHealth(z);
        //    }
        //    k++;
        //}
        //Console.WriteLine(cat1.GetInfo());


        //Console.WriteLine(Sobaka1.GetInfo());


        //Sobaka1.GetDamage(x);

        //Console.WriteLine(Sobaka1.GetInfo());






    }
}
