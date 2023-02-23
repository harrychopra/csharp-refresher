bool keepRunning = true;
var todos = new List<string>();

Console.WriteLine("Hello!");

do
{
    Console.WriteLine(
        "\nWhat do you want to do?\n" +
        "[S]ee all todos\n" +
        "[A]dd a todo\n" +
        "[R]emove a todo\n" +
        "[E]xit\n");

    var userInput = Console.ReadLine();

    switch (userInput)
    {
        case "e":
        case "E":
            Console.WriteLine("\nGoodbye!");
            keepRunning = false;
            break;
        case "s":
        case "S":
            ListAllTodos();
            break;
        case "a":
        case "A":
            AddTodo();
            break;
        case "r":
        case "R":
            DeleteTodo();
            break;
        default:
            PrintInvalidInputMessage(userInput);
            break;
    }
}
while (keepRunning);

void ListAllTodos()
{
    Console.WriteLine();
    if (todos.Count == 0)
    {
        PrintNoTodosMessage();
        return;
    }

    for (int i = 0; i < todos.Count; i++)
    {
        Console.WriteLine($"{i + 1}. {todos[i]}");
    }
}

void AddTodo()
{
    bool isValidDescription;

    Console.WriteLine("\nEnter the TODO description:");

    do
    {
        isValidDescription = TryParseDescription(Console.ReadLine(), out string description);

        if (isValidDescription) todos.Add(description);
    }
    while (!isValidDescription);
}

void DeleteTodo()
{
    if (todos.Count == 0)
    {
        PrintNoTodosMessage();
        return;
    }

    bool isValidTodoId;

    Console.WriteLine("\nEnter the Id number of the TODO to remove:");

    do
    {
        isValidTodoId = TryParseTodoId(Console.ReadLine(), out int todoId);

        if (isValidTodoId) todos.RemoveAt(todoId - 1);
    }
    while (!isValidTodoId);

    return;
}

bool TryParseTodoId(string userInput, out int todoId)
{
    todoId = 0;

    if (userInput.Equals(""))
    {
        PrintEmptyInputMessage();
        return false;
    }
    else if (!int.TryParse(userInput, out todoId))
    {
        PrintInvalidInputMessage(userInput);
        return false;
    }
    else if (todoId < 0 || todoId > todos.Count)
    {
        Console.WriteLine($"\nTODO with id: {todoId} does not exist. Try again!");
        return false;
    }
    else
    {
        return true;
    }
}

bool TryParseDescription(string userInput, out string description)
{
    description = "";

    if (userInput.Equals(""))
    {
        PrintEmptyInputMessage();
        return false;
    }
    else if (todos.Contains(userInput))
    {
        Console.WriteLine("\nThe description must be unique. Try again!");
        return false;
    }
    else
    {
        description = userInput;
        return true;
    }

}

void PrintInvalidInputMessage(string? userInput)
{
    Console.WriteLine($"\n\"{userInput}\" is not recognised input. Try again!");
}

void PrintEmptyInputMessage()
{
    Console.WriteLine($"Input cannot be empty. Try again!");
}

static void PrintNoTodosMessage()
{
    Console.WriteLine("No TODOs have been added yet.");
}