using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1._2
{
    internal class TEPiramid : TETriangle
    {
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Висота піраміди має бути більшою за нуль.");
                height = value;
            }
        }
        public TEPiramid() : base()
        {
            height = 1.0;
        }
        public TEPiramid(double side, double height) : base(side)
        {
            Height = height;
        }
        public TEPiramid(TEPiramid other) : base(other)
        {
            height = other.height;
        }
        public double GetVolume()
        {
            return (1.0 / 3.0) * GetArea() * height;
        }

        public override void Input()
        {
            base.Input();
            Console.Write("Введіть висоту піраміди: ");
            if (double.TryParse(Console.ReadLine(), out double value))
            {
                Height = value;
            }
            else
            {
                Console.WriteLine("Невірне введення висоти. Встановлено значення за замовчуванням: 1.0");
                height = 1.0;
            }
        }
        public override string ToString()
        {
            return $"Правильна трикутна піраміда [Сторона основи: {Side:F2}, Висота: {Height:F2}, Площа основи: {GetArea():F2}, Об'єм: {GetVolume():F2}]";
        }
    }
}
