using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Cat : CatColor
    {
        private string _name { get; set; }

        public string Name
        {
            get { return _name; }
            set
            {


                if (_name == null)
                {
                    _name = value;
                    Console.WriteLine("Вы дали имя "+ Name);


                }
                else
                {
                    Console.WriteLine("Имя можно задать, только один раз!!!");
                }
            }
        }


        public int Age { private get; set; }



        public string CatColor
        {
            get
            {
                if (_heath < 5)
                {
                    return HeathyColor;
                }
                else
                {
                    return SickColor;
                }
            }
            set
            {
                if (_heath < 5)
                {
                    HeathyColor = value;
                }
                else
                {
                    SickColor = value;
                }
            }
        }

        private int _heath { get; set; } = 5;

        public void Feed()
        {
            ++_heath;
            Console.WriteLine("Здоровье питомца: " + _heath);
            if (_heath < 5)
            {
                Console.WriteLine("Питомец болен! Покормите его!");

                Console.WriteLine("Цвет питомца: " + CurrentColor);
            }
            else
            {
                Console.WriteLine("Питомец здоров!");

                Console.WriteLine("Цвет питомца: " + CurrentColor);
            }
        }

        public void Punish()
        {
            --_heath;
            Console.WriteLine("Здоровье питомца: " + _heath);
            if (_heath < 5)
            {
                Console.WriteLine("Питомец болен! Покормите его!");
            
                Console.WriteLine("Цвет питомца: " + CurrentColor);
             }
            else
            {
                Console.WriteLine("Питомец здоров!");

                Console.WriteLine("Цвет питомца: " + CurrentColor);
            }
        }



        public string CurrentColor
        {
            get { return CatColor; }
            set
            {
                if (_heath < 5)
                {
                    CatColor = HeathyColor;
                    Console.WriteLine(_heath);
                }

                else
                {
                    CatColor = SickColor;
                    Console.WriteLine(_heath);

                }
            }
        }









    }
}
