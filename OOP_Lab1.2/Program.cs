namespace OOP_Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;

            Console.WriteLine("ТЕСТУВАННЯ КЛАСУ TETriangle");

            TETriangle t1 = new TETriangle(4.0);
            Console.WriteLine($"t1: {t1}");

            TETriangle t2 = new TETriangle();
            Console.WriteLine("\nВведіть параметри для t2:");
            t2.Input();
            Console.WriteLine($"t2: {t2}");

            TETriangle t3 = new TETriangle(t1);
            Console.WriteLine($"\nt3 (копія t1): {t3}");

            Console.WriteLine($"Периметр t1: {t1.GetPerimeter():F2}");
            Console.WriteLine($"Площа t1: {t1.GetArea():F2}");

            Console.WriteLine($"\nПорівняння t1 та t3 (t1 == t3): {t1 == t3}");
            Console.WriteLine($"Порівняння t1 та t2 (t1 == t2): {t1 == t2}");

            TETriangle t4 = t1 * 2.5;
            TETriangle t5 = 1.5 * t2;
            Console.WriteLine($"\nРезультат t1 * 2.5: {t4}");
            Console.WriteLine($"Результат 1.5 * t2: {t5}");

            Console.WriteLine("\nТЕСТУВАННЯ КЛАСУ TEPiramid");

            TEPiramid pyramid1 = new TEPiramid(6.0, 9.0);
            Console.WriteLine($"pyramid1: {pyramid1}");
            Console.WriteLine($"Об'єм pyramid1: {pyramid1.GetVolume():F2}");

            TEPiramid pyramid2 = new TEPiramid();
            Console.WriteLine("\nВведіть параметри для піраміди pyramid2:");
            pyramid2.Input();
            Console.WriteLine($"pyramid2: {pyramid2}");
        }
    }
}
