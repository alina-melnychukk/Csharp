
//Перевірити істинність вислову: "Дані числа x, у є координатами точки, що лежить у другому квадранті ".

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.Write("Введіть значення x:");
            int x = int.Parse(Console.ReadLine());
            Console.Write("Введіть значення y: ");
            int y = int.Parse(Console.ReadLine());

            if (x < 0 && y > 0)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
            
        }
    }
}
