using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace View
{
    class Program
    {
        static void Main(string[] args)
        {
            var cat = new Cat();
            Console.WriteLine("Введите возраст питомца");
            cat.Age = Console.Read();


            for (;;)
            {
                Console.Clear();
                Console.WriteLine("1. Задать имя");
                Console.WriteLine("2. Изменить цвет");
                Console.WriteLine("3. Ударить");
                Console.WriteLine("4. Покормить");
                Console.WriteLine("5. Покинуть приложение");

                string menu = Console.ReadLine();
                switch (menu)
                {
                    case "1":
                        Console.Clear();
                        Console.WriteLine("Введите имя питомца");
                        cat.Name = Console.ReadLine();
                        //Console.WriteLine("Вы дали имя "+ cat.Name);


                        Console.ReadKey();
                        continue; 

                    case "2":
                        Console.Clear();
                        Console.WriteLine("Сейчас животное имеет "+ cat.CatColor);
                        cat.CatColor = Console.ReadLine();
                        Console.Clear();
                        Console.WriteLine("Вы изменили цвет на "+ cat.CatColor);
                        Console.ReadKey();
                        continue;
                    case "3":
                        Console.Clear();
                        Console.WriteLine("Вы пнули питомца");
                        cat.Punish();
                        Console.ReadKey();
                        continue;
                    case "4":
                        Console.Clear();
                        Console.WriteLine("Вы покормили питомца");
                        cat.Feed();
                        Console.ReadKey();
                        continue;
                    case "5":
                        Console.WriteLine("Возращатесь скорее");
                        Console.ReadKey();
                        break;

                    default:
                        Console.WriteLine("Вы ввели не верные данные.");
                        continue;





                } 
                break;
            }
            
        }

    }

}
