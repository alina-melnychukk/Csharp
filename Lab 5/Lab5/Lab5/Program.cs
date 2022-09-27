
//Дана матриця розміру m *  n. Поміняти місцями стовпчик з номером 1 та 1) перший; 2) останній із стовпчиків, що містять тільки додатні елементи. 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab5
{
    class Program
    {
        static void ifFirstcolPos(int [,]arr, int m = 5,int n = 10,int positiveCounter = 0, int colF= 0, int col1=1)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (arr[i, j] >= 0)
                    {
                        positiveCounter++;
                    }
                }
                if (positiveCounter == m)
                {
                    colF = j;
                    break;
                }
                positiveCounter = 0;
            }
            for (int k = 0; k < m; k++)
            {
                int temp = arr[k, col1];
                arr[k, col1] = arr[k, colF];
                arr[k, colF] = temp;
            }

            Console.WriteLine("Зміна стовпчика №1 та першого із стовпчиків, що містять тільки додатні елементи");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        static void ifLastcolPos(int[,] arr, int m = 5, int n = 10, int positiveCounter = 0, int colL = 0, int col1=1)
        {
            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (arr[i, j] >= 0)
                    {
                        positiveCounter++;
                    }
                }
                if (positiveCounter == m)
                {
                    colL = j;
                }
                positiveCounter = 0;
            }
            for (int k = 0; k < m; k++)
            {
                int temp = arr[k, col1];
                arr[k, col1] = arr[k, colL];
                arr[k, colL] = temp;
            }
            Console.WriteLine("Зміна стовпчика №1 та останнього із стовпчиків, що містять тільки додатні елементи");
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {

                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void Main(string[] args)
        {
            int m = 5, n = 10, positiveCounter = 0;
            int[,] arr = new int[m, n];


            Random rand = new Random();
            for (int i = 0; i < m; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    arr[i, j] = rand.Next(-2, 10);
                    Console.Write(arr[i, j] + "\t");
                }
                Console.WriteLine();
            }

            for (int j = 0; j < n; j++)
            {
                for (int i = 0; i < m; i++)
                {
                    if (arr[i, j] >= 0)
                    {
                        positiveCounter++;
                    }
                }
                if (positiveCounter == m)
                {
                    Console.WriteLine((j) + " column is positive");
                }
                positiveCounter = 0;
            }

            ifFirstcolPos(arr, 5, 10, 0, 0,1);
            ifLastcolPos(arr,5,10,0,0,1);

        }
    }
}
