var words = new List<string> { "one", "two"};

Console.WriteLine("The length of words is: "+words.Count);

foreach(var word in words)
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