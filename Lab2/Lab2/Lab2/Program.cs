using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int nn = 0;
            int nk = 0;
            double result = 0;
            bool isNNOk = false;
            bool isNKOk = false;

            do
            {
                Console.Write("Введіть значення nn: ");
                string strNN = Console.ReadLine();
                isNNOk = int.TryParse(strNN, out nn);
                if (isNNOk && nn >= 0) break;
                    Console.WriteLine("Помилка введення");
            } while (!isNNOk);

            do
            {
                Console.Write("Введіть значення nk: ");
                string strNK = Console.ReadLine();
                isNKOk = int.TryParse(strNK, out nk);
                if (isNKOk) isNKOk = nk >= nn;
                if (isNKOk) break;
                Console.WriteLine("Помилка введення");
            } while(!isNKOk);

            for (int k = nn; k < nk; k++)
            {
                result += (Math.Pow(k, 2) - 3) / (Math.Pow(k, 2) - Math.Pow(-1, k) * k + 3); 
            }

           
            Console.Write("Результат=");
            Console.WriteLine(result);
        }
    }
}
