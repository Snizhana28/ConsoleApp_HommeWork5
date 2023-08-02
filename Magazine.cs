using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp_HommeWork5
{
    public class Magazine
    {
        public string Name { get; set; }
        public int NumberOfEmployees { get; set; }

        public Magazine() {}
        Magazine(string name, int numberOfEmployees)
        {
            Name = name;
            NumberOfEmployees = numberOfEmployees;
        }
        public void Input()
        {
            Console.WriteLine("Enter name of magazine: ");
            Name = Console.ReadLine();
            Console.WriteLine("Enter number of employees of magazine: ");
            NumberOfEmployees = Convert.ToInt32(Console.ReadLine());
        }
        public override string ToString()
        {
            return $"Name: {Name}, Number of employees: {NumberOfEmployees}";
        }
        public static Magazine operator +(Magazine magazine, int numberOfEmployees)
        {
            magazine.NumberOfEmployees += numberOfEmployees;
            return magazine;
        }
        public static Magazine operator -(Magazine magazine, int numberOfEmployees)
        {
            magazine.NumberOfEmployees -= numberOfEmployees;
            return magazine;
        }
        public static bool operator ==(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberOfEmployees == magazine2.NumberOfEmployees;
        }
        public static bool operator !=(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberOfEmployees != magazine2.NumberOfEmployees;
        }
        public static bool operator >(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberOfEmployees > magazine2.NumberOfEmployees;
        }
        public static bool operator <(Magazine magazine1, Magazine magazine2)
        {
            return magazine1.NumberOfEmployees < magazine2.NumberOfEmployees;
        }
        public override bool Equals(object obj)
        {
            return obj is Magazine magazine &&
                   Name == magazine.Name &&
                   NumberOfEmployees == magazine.NumberOfEmployees;
        }
    }
}
