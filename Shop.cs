using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HommeWork5
{
    public class Shop
    {
        public string Name { get; set; }
        public double Sguare { get; set; }
        public int CountOfEmployers { get; set; }

        public Shop() {}
        public Shop(string name, double sguare, int countOfEmployers)
        {
            Name = name;
            Sguare = sguare;
            CountOfEmployers = countOfEmployers;
        }
        public void Input()
        {
            Console.WriteLine("Enter name of shop: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter sguare of shop: ");
            Sguare = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter count of employers: ");
            CountOfEmployers = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Name: {Name}, Sguare: {Sguare}, Count of employers: {CountOfEmployers}";
        }
        public static Shop operator +(Shop shop, double sguare)
        {
            shop.Sguare += sguare;
            return shop;
        }
        public static Shop operator -(Shop shop, double sguare)
        {
            shop.Sguare -= sguare;
            return shop;
        }
        public static bool operator ==(Shop shop1, Shop shop2)
        {
            return shop1.Sguare == shop2.Sguare;
        }
        public static bool operator !=(Shop shop1, Shop shop2)
        {
            return shop1.Sguare != shop2.Sguare;
        }
        public static bool operator >(Shop shop1, Shop shop2)
        {
            return shop1.Sguare > shop2.Sguare;
        }
        public static bool operator <(Shop shop1, Shop shop2)
        {
            return shop1.Sguare < shop2.Sguare;
        }
        public override bool Equals(object obj)
        {
            return obj is Shop shop &&
                Name == shop.Name &&
                Sguare == shop.Sguare &&
                CountOfEmployers == shop.CountOfEmployers;
        }
    }
}
