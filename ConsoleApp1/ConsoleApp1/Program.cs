using System;

//Створити клас Cars, в якому міститься набір з 5 машин італійського виробництва, для кожної з машин визначені 4характеристики:
//колекція кольорів в якому вона представлена, рік випуску і ціна. Четверту характеристику оберіть самі. Реалізувати можливість
//для покупця обрати машину з набору за її параметрами. Повідомити якщо не існує машини з потрібними параметрами, якщо існує –
//вивести на екран повний опис машини.
namespace exam
{
    class Program
    {
        static int Choice()
        {
            int res;
            bool check = int.TryParse(Console.ReadLine(), out res);
            if (check)
                return res;
            return 0;
        }

        static void Main(string[] args)
        {
            Cars[] cars = {new Cars("Ferrari", 22670000, 2021, Cars.Colors.Black),
                           new Cars("Lamborghini", 507353, 2019, Cars.Colors.White),
                           new Cars("Maserati", 85600, 2021, Cars.Colors.Red),
                           new Cars("Fiat", 143000, 2022, Cars.Colors.White),
                           new Cars("Alfa Romeo", 75000, 2018, Cars.Colors.Green)};

            bool x1 = true, x2 = true;
            int choice, price, year;
            Cars.Colors color;
            string stop;
           

            do
            {
                int choice3 = 0;
                price = 0;
                year = 0;
                color = Cars.Colors.Null;

                Console.WriteLine("PRICE:\nBigger than 500 000(1)\nLess than 500 000(2)");
                choice = Choice();
                switch (choice)
                {
                    case 1:
                        {
                            Console.Write("Write minimum price: ");
                            price = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    case 2:
                        {
                            Console.Write("Write maximum price: ");
                            price = Convert.ToInt32(Console.ReadLine());
                            break;
                        }
                    default:
                        {
                            choice = 0;
                            break;
                        }
                }

                Console.WriteLine("YEAR OF MANUFACTURING:\n2021\n2018\n2022\n2019");
                Console.Write("Choose year: ");
                switch (Choice())
                {
                    case 1:
                    case 2021:
                        {
                            year = 2021;
                            break;
                        }
                    case 2:
                    case 2018:
                        {
                            year = 2018;
                            break;
                        }
                    case 3:
                    case 2022:
                        {
                            year = 2022;
                            break;
                        }
                    case 4:
                    case 2019:
                        {
                            year = 2019;
                            break;
                        }
                    default:
                        {
                            break; 
                        }
                }

                Console.WriteLine("COLOR:\nRed(1)\nBlack(2)\nWhite(3)\nGreen(4)");
                Console.Write("Choose color(write the number of color): ");
                choice3 = Convert.ToInt32(Console.ReadLine());
                switch (choice3)
                {
                    case 1:
                        {
                            color = Cars.Colors.Red;
                            break;
                        }
                    case 2:
                        {
                            color = Cars.Colors.Black;
                            break;
                        }
                    case 3:
                        {
                            color = Cars.Colors.White;
                            break;
                        }
                    case 4:
                        {
                            color = Cars.Colors.Green;
                            break;
                        }
                    default: 
                        {
                            break; 
                        }
                }

                if (price == 0 && year == 0 && color == Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                        x2 = false;
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && year == 0 && color == Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && year != 0 && color == Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Year == year)
                        {
                            Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                            x2 = false;
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && year == 0 && color != Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Color == color)
                        {
                            Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                            x2 = false;
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && year != 0 && color == Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].Year == year)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].Year == year)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price != 0 && year == 0 && color != Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else if (price == 0 && year != 0 && color != Cars.Colors.Null)
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (cars[i].Year == year && cars[i].Color == color)
                        {
                            Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                            x2 = false;
                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                else
                {
                    Console.WriteLine(new string('-', 50));
                    for (int i = 0; i < cars.Length; i++)
                    {
                        if (choice == 1)
                        {
                            if (cars[i].Price > price && cars[i].Year == year && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }
                        }
                        else if (choice == 2)
                        {
                            if (cars[i].Price < price && cars[i].Year == year && cars[i].Color == color)
                            {
                                Console.WriteLine(cars[i].Model + "\t\t" + cars[i].Price + "\t" + cars[i].Year + "\t" + cars[i].Color);
                                x2 = false;
                            }

                        }
                    }
                    if (x2) Console.WriteLine("Sorry, we don`t have that car!");
                    Console.WriteLine(new string('-', 50));
                }

                Console.WriteLine("Should we stop the program(yes/no): ");
                stop = Console.ReadLine();
                if (stop == "yes" || stop == "Yes" || stop == "YES") x1 = false;

            }
            while (x1);
        }
    }
}