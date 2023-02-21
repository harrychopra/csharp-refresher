internal class Program
{
    private static void Main(string[] args)
    {
    }

    // Variables and Operators
    public static int VariablesAndOperators()
    {
        var a = 5;
        var b = 10;
        var c = 3;

        int result = (a + b) / c;

        return result;
    }

    // Boolean types and operators
    public static bool BooleanTypesAndOperators()
    {
        int a = 5;
        int b = 12;

        bool isSumLargerOrEqualTo17 = a + b >= 17;

        return isSumLargerOrEqualTo17;
    }

    // If/Else conditional statement
    public static string IsElseConditionalStatement()
    {
        int number = 0;

        string result;

        if (number < 0)
        {
            result = "negative";
        }
        else if (number > 0)
        {
            result = "positive";
        }
        else
        {
            result = "zero";
        }

        return result;
    }

    // Methods
    public static int AbsoluteOfSum(int numA, int numB)
    {
        var sum = numA + numB;

        if (sum < 0)
        {
            sum *= -1;
        }

        return sum;
    }

    // String interpolation - Format date
    public static string FormatDate(int year, int month, int day)
    {
        return $"{year}/{month}/{day}";
    }

    // Switch statement 
    public static string DescribeDay(int dayNumber)
    {
        string message;

        switch (dayNumber)
        {
            case 1:
            case 2:
            case 3:
            case 4:
            case 5:
                message = "Working day";
                break;
            case 6:
            case 7:
                message = "Weekend";
                break;
            default:
                message = "Invalid day number";
                break;
        }
        return message;
    }

    // While loop
    public static int CalculateSumOfNumbersBetween(int firstNumber, int lastNumber)
    {
        int sum = 0;
        int currentNumber = firstNumber;

        while (currentNumber <= lastNumber)
        {
            sum += currentNumber;
            currentNumber++;
        }

        return sum;
    }


    // Do while loop
    public static string RepeatCharacter(char character, int targetLength)
    {
        string result = "";

        do
        {
            result += character;
        }
        while (result.Length < targetLength);

        return result;
    }

    // Arrays
    public static string BuildHelloString()
    {
        var letters = new[] { 'H', 'e', 'l', 'l', 'o' };

        var result = "";

        foreach (char letter in letters)
        {
            result += letter;
        }

        return result;
    }

    // More Arrays
    public static bool isWordPresentInCollection(string[] words, string wordToBeChecked)
    {
        foreach (string word in words)
        {
            if (wordToBeChecked.Equals(word)) return true;
        }

        return false;
    }

}