// --- Lists ----
var words = new List<string> { "one", "two" };

Console.WriteLine("The length of words is: " + words.Count);

foreach (var word in words)
{
    Console.WriteLine(word);
}

words.Add("three");
Console.WriteLine(words.Count);

words.Remove("two");
Console.WriteLine(words.Count);

words.RemoveAt(0);
Console.WriteLine(words[0]);

words.AddRange(new string[] { "four", "five" });
Console.WriteLine(words[^1]);

var hasWordFour = words.Contains("four");
Console.WriteLine(hasWordFour);

words.Clear();
Console.WriteLine(words.Count);

// --- out Keyword ----

var numbers = new[] { 10, -8, 2, 12, -17 };

var positiveNumbers = GetOnlyPositive(numbers, out int negativeNumberCount);

foreach(var number in positiveNumbers)
{
    Console.WriteLine(number);
}

Console.WriteLine("The count of negative numbers: "+negativeNumberCount);

List<int> GetOnlyPositive(int[] numbers, out int nonPositiveCount)
{
    var positiveNumbers = new List<int>();

    foreach(var number in numbers)
    {
        if (number > 0) positiveNumbers.Add(number);
    }

    nonPositiveCount = numbers.Length - positiveNumbers.Count;

    return positiveNumbers;
}

// --- Try Parse ---

bool isValidInteger;

do
{
    Console.WriteLine("Enter a number:");
    var userInput = Console.ReadLine();

    isValidInteger = int.TryParse(userInput, out int number);

    if (isValidInteger)
    {
        Console.WriteLine($"{number} is a valid integer");
    }
    else
    {
        Console.WriteLine($"{userInput} is not a valid integer. Try again!");
    }
}
while (!isValidInteger);