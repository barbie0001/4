using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practos44444
{
    internal partial class Program
    {
        static Date[] date = new Date[3];
        static int index = 0;
        static int pos = 1;
        static void Main(string[] args)
        {
            Planner();
            Menu();

        }
        static void Comennt()
        {
            Console.Clear();
            Console.WriteLine(date[index].plans[pos - 1]);
            Console.WriteLine("-------------------------------");
            Console.WriteLine(date[index].comennt[pos - 1]);
            Console.WriteLine(date[index].date);
            Console.ReadKey();

            Menu();
        }
        static void Menu()
        {
            Console.Clear();
            PrintDate(date[index]);
            Console.SetCursorPosition(0, pos);
            Console.WriteLine("->");
            while (Console.ReadKey().Key != ConsoleKey.Enter)
            {

                ConsoleKeyInfo key = Console.ReadKey();
                if (key.Key == ConsoleKey.RightArrow)
                {
                    index++;
                    if (index > date.Length - 1)
                    {
                        index = 0;
                    }
                }
                else if (key.Key == ConsoleKey.LeftArrow)
                {
                    index--;
                    if (index < 0)
                    {
                        index = date.Length - 1;
                    }
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    pos++;
                    if (pos > date[index].plans.Count)
                    {
                        pos = 1;
                    }

                }
                else if (key.Key == ConsoleKey.DownArrow)
                {
                    pos--;
                    if (pos < 1)
                    {
                        pos = date[index].plans.Count;
                    }

                }

                Console.Clear();
                PrintDate(date[index]);
                Console.SetCursorPosition(0, pos);
                Console.WriteLine("->");

            }
            Comennt();
        }
        static void Planner()
        {

            date[0] = new Date();
            date[0].date = DateTime.Parse("10.11.2023");
            date[0].plans.Add("  1. Идти на пары");
            date[0].plans.Add("  2. Кушать");
            date[0].comennt.Add("Описание: стоят в вагоне метро");
            date[0].comennt.Add("Описание: кушать вкусную лазанью");


            date[1] = new Date();
            date[1].date = DateTime.Parse("24.12.2023");
            date[1].plans.Add("  1. Идти домой");
            date[1].plans.Add("  2. Спать");
            date[1].comennt.Add("Описание: строчить практосы до ночи");
            date[1].comennt.Add("Описание: сладко спать в уютной постели");

            date[2] = new Date();
            date[2].date = DateTime.Parse("31.10.2023");
            date[2].plans.Add("  1. Праздновать хеллуоин ");
            date[2].plans.Add("  2. Пугать людей");
            date[2].comennt.Add("Описание: украсить дом к хеллоуину и нарядиться");
            date[2].comennt.Add("Описание: стучать в окна и просить конфеты");


        }

        static void PrintDate(Date cd)
        {

            Console.WriteLine($"Выбрана дата {cd.date:d}");
            for (int i = 0; i < cd.plans.Count; i++)
            {
                Console.WriteLine(cd.plans[i]);
            }


        }

    }
}
