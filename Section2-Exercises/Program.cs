﻿internal class Program
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
}