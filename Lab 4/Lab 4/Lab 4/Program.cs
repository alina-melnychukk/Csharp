
//Даний масив розміру N. Перетворити його, вставивши після кожного від'ємного елементу нульовий елемент. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4
{
    class Program
    {
        static void insert(ref int[] arr, int val, int index)
        {
            int[] resultArray = new int[arr.Length + 1];
            resultArray[index] = val;

            for (int i = 0; i < index; i++)
            {
                resultArray[i] = arr[i];
            }

            for (int i = index; i < arr.Length; i++)
            {
                resultArray[i + 1] = arr[i];
            }
            arr = resultArray;
        }

        public static void Main(string[] args)
        {
            Console.Write("Введіть кількість елементів масиву, N: ");

            int n = int.Parse(Console.ReadLine());

            int firstElem = 0;
            int[] arr = new int[n];


            Random rand = new Random();
            for (int i = 0; i < n; i++)
            {
                arr[i] = rand.Next(-5, 10);
                Console.Write(arr[i] + "\t");
            }

            firstElem = arr[0];

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] <= 0)
                {
                    insert(ref arr, firstElem, i + 1);
                    i++;
                }
            }
            Console.WriteLine("");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + "\t");
            }
        }
      
    }
}
