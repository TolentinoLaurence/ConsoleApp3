namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 5 grades separately");
            double grade = Convert.ToDouble(Console.ReadLine());
            double grade1 = Convert.ToDouble(Console.ReadLine());
            double grade2 = Convert.ToDouble(Console.ReadLine());
            double grade3 = Convert.ToDouble(Console.ReadLine());
            double grade4 = Convert.ToDouble(Console.ReadLine());

            double total = (grade + grade1 + grade2 + grade3 + grade4) /5;
            double squareRoot = Math.Round(total);
            Console.WriteLine("The average is " + total + " and rounf of " + squareRoot);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}