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

        if (IsEqualCaseInsensitive('A', userChoice))
        {
            var sum = numA + numB;
            PrintEquation(numA, numB, "+", sum);
        }
        else if (IsEqualCaseInsensitive('S', userChoice))
        {
            var difference = numA - numB;
            PrintEquation(numA, numB, "-", difference);
        }
        else if (IsEqualCaseInsensitive('M', userChoice))
        {
            var product = numA * numB;
            PrintEquation(numA, numB, "*", product);
        }
        else
        {
            Console.WriteLine("Invalid choice!");
        }
    }

    private static bool IsEqualCaseInsensitive(char a, char b)
    {
        return char.Equals(a, char.ToUpper(b));
    }

    private static void PrintEquation(int numA, int numB, string @operator, int result)
    {
        Console.WriteLine($"{numA} {@operator} {numB} = {result}");
    }
}