using System;

namespace Lesson1
{
    class Program
    {
        static void Main(string[] args)
        {
         Console.Write("Введіть кількість елементів масиву: ");

            int elementsCount = int.Parse(Console.ReadLine());

            Console.Write("Введіть число для перевірки на кратність: ");

            int elementsCheck = int.Parse(Console.ReadLine());

            int[] array = new int[elementsCount];

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write("Введіть елемент масива під індексом: " + i + "\t - \t");

                array[i] = int.Parse(Console.ReadLine());

            }

            int x = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] % elementsCheck == 0)
                {
                    x += 1;
                }
                else
                    x += 0;
            }

            Console.Write("Кількість елементів, кратних числу " + elementsCheck + "= " + x);

        }

    }

}
