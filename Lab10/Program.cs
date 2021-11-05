using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Угол задан с помощью целочисленных значений gradus - градусов, 
 * min - угловых минут, sec - угловых секунд. 
 * Реализовать класс, в котором указанные значения 
 * представлены в виде свойств. 
 * Для свойств предусмотреть проверку корректности данных. 
 * Класс должен содержать конструктор для установки начальных значений, 
 * а также метод ToRadians для перевода угла в радианы. 
 * Создать объект на основе разработанного класса. Осуществить использование объекта в программе.*/
namespace Lab10
{
    class Corner
    {
        private int gradus;
        private int min;
        private int sec;
        public Corner(int gradus=0, int min=0, int sec=0)
        {
            Gradus = gradus;
            Min = min;
            Sec = sec;
        }
        public int Gradus
        {
            set
            {

                if (value>=0 && value <= 360)
                {
                    gradus = value;
                }
                else
                {
                    throw new Exception("Ошибка ввода градусов.");
                }
            }
            get
            {
                return gradus;
            }
        }
        public int Min
        {
            set
            {

                if (value >= 0 && value < 60)
                {
                    min = value;
                }
                else
                {
                    throw new Exception("Ошибка ввода минут.");
                }
            }
            get
            {
                return min;
            }
        }
        public int Sec
        {
            set
            {

                if (value >= 0 && value < 60)
                {
                    sec = value;
                }
                else
                {
                    throw new Exception("Ошибка ввода секунд.");
                }
            }
            get
            {
                return sec;
            }
        }
        public double ToRadians()
        {
            return (gradus + (min / 60) + (sec / 3600)) * Math.PI / 180;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            bool f = false;
            Corner c = new Corner();
            while (!f)
            {
                try
                {
                    Console.WriteLine("Введите градусы, минуты и секунды угла:");
                    c = new Corner(Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()), Int32.Parse(Console.ReadLine()));
                    f = true;
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                    f = false;
                }
            }
            Console.WriteLine($"Ваш угол составляет {c.Gradus} градусов {c.Min} минут {c.Sec} секунд.");
            Console.WriteLine($"В радианах это будет = {c.ToRadians():f4}");
            PressToExit();
        }
        static void PressToExit()
        {
            Console.WriteLine("\nНажмите любую клавишу для выхода.");
            Console.ReadKey();
        }
    }
}
