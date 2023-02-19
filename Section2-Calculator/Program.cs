// Calculator
internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Hello!");
        Console.WriteLine("Input the first number:");
        int numA = int.Parse(Console.ReadLine());

        Console.WriteLine("Input the second number:");
        int numB = int.Parse(Console.ReadLine());

        Console.WriteLine("What do you want to do?");
        Console.WriteLine(
            "[A]dd numbers\n" +
            "[S]ubtract numbers\n" +
            "[M]ultiply numbers");
        char userChoice = char.Parse(Console.ReadLine());

        switch (userChoice)
        {
            case 'a':
            case 'A':
                var sum = numA + numB;
                PrintEquation(numA, numB, "+",sum);
                break;
            case 's':
            case 'S':
                var difference = numA - numB;
                PrintEquation(numA, numB, "-", difference);
                break;
            case 'm':
            case 'M':
                var product = numA * numB;
                PrintEquation(numA, numB, "*", product);
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }

    private static void PrintEquation(int numA, int numB, string @operator, int result)
    {
        Console.WriteLine($"{numA} {@operator} {numB} = {result}");
    }
}