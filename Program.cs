using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab1
{

    public class Triangle
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo btn;
            do
            {
                Console.WriteLine("Side a1");
                double a1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Side а2");
                double a2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Side b1");
                double b1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Side b2");
                double b2 = double.Parse(Console.ReadLine());

                Console.WriteLine("Side с1");
                double c1 = double.Parse(Console.ReadLine());
                Console.WriteLine("Side с2");
                double c2 = double.Parse(Console.ReadLine());

                double a = Math.Sqrt(Math.Pow(a2 - a1, 2) + Math.Pow(b1 - b2, 2));
                double b = Math.Sqrt(Math.Pow(b2 - b1, 2) + Math.Pow(c1 - c2, 2));
                double c = Math.Sqrt(Math.Pow(c2 - c1, 2) + Math.Pow(a1 - a2, 2));

                double alpha = 0;
                double betta = 0;
                double gamma = 0;
                Console.WriteLine("_______________________________________________________");

                double AB = Math.Sqrt(Math.Pow(b1 - a1, 2) + Math.Pow(b2 - a2, 2));
                Console.WriteLine($"AB: {AB} cm ");

                double BC = Math.Sqrt(Math.Pow(c1 - b1, 2) + Math.Pow(c2 - b2, 2));
                Console.WriteLine($"BC: {BC} cm ");

                double AC = Math.Sqrt(Math.Pow(c1 - a1, 2) + Math.Pow(c2 - a2, 2));
                Console.WriteLine($"AC: {AC} cm ");

                double P = AB + BC + AC;
                Console.WriteLine($"P(ABC): {P} cm");


                Console.WriteLine("_______________________________________________________");

                double S = 0.5 * (Math.Abs((b1 - a1) * (c2 - a2) - (c1 - a1) * (b2 - a2)));
                Console.WriteLine($"S(ABC): {S} square cm");


                Console.WriteLine("_______________________________________________________");

                alpha = (((Math.Acos((b * b + c * c - a * a) / (2 * b * c)) * 180)) / Math.PI);
                Console.WriteLine("alpha = {0}", alpha);
                betta = (((Math.Acos((a * a + c * c - b * b) / (2 * a * c)) * 180)) / Math.PI);
                Console.WriteLine("betta = {0}", betta);
                gamma = (((Math.Acos((a * a + b * b - c * c) / (2 * a * b)) * 180)) / Math.PI);
                Console.WriteLine("gamma = {0}", gamma);
                Console.WriteLine("_______________________________________________________");
                if ((a < b + c) & (b < c + a) & (c < b + a))
                {
                    if ((alpha == 90) || (betta == 90) || (gamma == 90)) Console.WriteLine("The triangle is rectangular");
                    else
                        if ((alpha > 90) || (betta > 90) || (gamma > 90)) Console.WriteLine("Obtuse triangle");
                    else
                        Console.WriteLine("Triangle acute angle");
                }
                else
                    Console.WriteLine("Triangle does not exist");

                Console.WriteLine("_______________________________________________________");
                Console.WriteLine("To exit, click Esc / To continue fny other key");
                btn = Console.ReadKey();

            } while (btn.Key != ConsoleKey.Escape);
        }
    }
}