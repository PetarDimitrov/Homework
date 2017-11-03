using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GeometryCalculator
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu();
            Console.ReadKey(true);
        }

        public static void Square()
        {
            Console.WriteLine("Enter side:");
            float side = float.Parse(Console.ReadLine());
            Console.WriteLine("The Area of the Square is:{0:f2}", side * side);
            Menu();
        }
        public static void Triangle()
        {
            Console.WriteLine("Enter side: ");
            float SideOfTriangle = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height: ");
            float height = float.Parse(Console.ReadLine());
            Console.WriteLine("The Area of the Triangle is:{0:f2}", (SideOfTriangle * height) / 2);
            Menu();
        }
        public static void Radians()
        {
            string radians = Console.ReadLine();
            Console.WriteLine("Enter the degrees you want to transform in radians:");
            float degrees = float.Parse(Console.ReadLine());
            double Radians = degrees * Math.PI / 180;
            Console.WriteLine("Your degrees in radians are = {0}", Radians);
            Menu();
        }
        public static void Menu()
        {
            Console.WriteLine("Choose figure(square,triangle or radians):");
            string figures = Console.ReadLine();
            switch (figures)
            {
                case "square":
                    Square();
                    break;
                case "triangle":
                    Triangle();
                    break;
                case "radians":
                    Radians();
                    break;
                default:
                    break;
            }
        }
    }
}