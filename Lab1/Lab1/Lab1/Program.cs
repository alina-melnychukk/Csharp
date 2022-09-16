using System;
// Обчислення об'єму та площі поверхні кулі заданого радіуса
namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введіть радіус кулі в сантиметрах: ");

            float Radius = float.Parse(Console.ReadLine());

            if (Radius < 0)
            {
                Console.WriteLine("Радіус не може бути від'ємним");
            }

            float V, S;

            if(Radius > 0)
            {
                V = (float)((4 * Math.PI * (Radius * Radius * Radius) / 3));
                S = (float)(4 * Math.PI * (Radius * Radius));

                Console.WriteLine("Об'єм кулі= " + V + "см^3");
                Console.WriteLine("Площа поверхні кулі= " + S + "см^2");

                return;
            } 


        }

    }

}