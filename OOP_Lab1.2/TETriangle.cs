using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Lab1._2
{
    internal class TETriangle
    {
        private double side;

        public double Side
        {
            get
            {
                return side;
            }
            set
            {
                side = value;
            }
        }
        public TETriangle()
        {
            side = 1;
        }
        public TETriangle(double a)
        {
            side = a;
        }
        public TETriangle(TETriangle other)
        {
            side = other.side;
        }
        public virtual void Input()
        {
            Console.Write("Введіть довжину сторони рівностороннього трикутника: ");
            side = double.Parse(Console.ReadLine());
            if (side <= 0)
                throw new ArgumentException("Довжина сторони трикутника має бути більшою за нуль");
        }
        public virtual double GetPerimeter()
        {
            return 3 * side;
        }
        public virtual double GetArea()
        {
            return side * side * Math.Sqrt(3) / 4;
        }

        public override string ToString()
        {
            return $"Рівносторонній трикутник [Сторона: {Side:F2}, Периметр: {GetPerimeter():F2}, Площа: {GetArea():F2}]";
        }
        public static bool operator ==(TETriangle t1, TETriangle t2)
        {
            if (t1.GetType() != t2.GetType()) return false;
            return Math.Abs(t1.side - t2.side) < 1e-7;
        }
        public static bool operator !=(TETriangle t1, TETriangle t2)
        {
            return !(t1 == t2);
        }
        public static TETriangle operator *(TETriangle t1, double a)
        {
            if (a <= 0)
                throw new ArgumentException("Число на яке множаться сторони трикутника має бути більше 0");
            return new TETriangle(t1.side * a);
        }
        public static TETriangle operator *(double a, TETriangle triangle)
        {
            return triangle * a;
        }
    }
}
