namespace ConsoleApp_HommeWork5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Shop shop1 = new Shop();
            shop1.Input();
            Console.WriteLine(shop1.ToString());
            //operator +
            Console.WriteLine("Enter sguare for operator +: ");
            double sguare = Convert.ToDouble(Console.ReadLine());
            shop1 += sguare;
            Console.WriteLine(shop1.ToString());
            //operator -
            Console.WriteLine("Enter sguare for operator -: ");
            sguare = Convert.ToDouble(Console.ReadLine());
            shop1 -= sguare;
            Console.WriteLine(shop1.ToString());
            //operator ==
            Shop shop2 = new Shop();
            shop2.Input();
            Console.WriteLine(shop2.ToString());
            Console.WriteLine($"Operator == : {shop1 == shop2}");
            //operator !=
            Console.WriteLine($"Operator != : {shop1 != shop2}");
            //operator >
            Console.WriteLine($"Operator > : {shop1 > shop2}");
            //operator <
            Console.WriteLine($"Operator < : {shop1 < shop2}");
            //Equals
            Console.WriteLine($"Equals : {shop1.Equals(shop2)}");
        }
    }
}