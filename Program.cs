namespace ConsoleApp_HommeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Magazine magazine = new Magazine();
            magazine.Input();
            Console.WriteLine(magazine.ToString());
            //operator +
            Console.WriteLine("Enter number of employees to add: ");
            int numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            magazine += numberOfEmployees;
            Console.WriteLine(magazine.ToString());
            //operator -
            Console.WriteLine("Enter number of employees to remove: ");
            numberOfEmployees = Convert.ToInt32(Console.ReadLine());
            magazine -= numberOfEmployees;
            Console.WriteLine(magazine.ToString());

            Magazine magazine1 = new Magazine();
            magazine1.Input();
            Console.WriteLine(magazine1.ToString());
            //operator ==
            Console.WriteLine($"Operator == : {magazine == magazine1}");
            //operator !=
            Console.WriteLine($"Operator != : {magazine != magazine1}");
            //operator <
            Console.WriteLine($"Operator < : {magazine < magazine1}");
            //operator >
            Console.WriteLine($"Operator > : {magazine > magazine1}");
            //operator Equals
            Console.WriteLine($"Operator Equals : {magazine.Equals(magazine1)}");

        }
    }
}