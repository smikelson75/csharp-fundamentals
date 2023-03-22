string word = "Duck";

// if then ... else
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-if-statement
if (word == "Duck") {
    Console.WriteLine("Quack");
}

// if then ... else
if (word == "Duck") {
    Console.WriteLine("Quack!");
} else if (word == "Dog") {
    Console.WriteLine("Bark!");
} else {
    Console.WriteLine("All quiet out here.");
}

// Switch statement
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#the-switch-statement
word = "Goose";
switch (word) {
    case "Goose":
    case "Duck":
        Console.WriteLine("Quack!");
        break;
    case "Dog":
        Console.WriteLine("Bark");
        break;
    default:
        Console.WriteLine("All quiet out here.");
        break;
}

int percentage = 53;
switch (percentage) {
    case >= 90:
        Console.WriteLine("Your grade is A.");
        break;
    case >= 80:
        Console.WriteLine("Your grade is B");
        break;
    case >= 70:
        Console.WriteLine("Your grade is C.");
        break;
    default:
        Console.WriteLine("You will need to take the class over.");
        break;
}

// Case Guard
// https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/statements/selection-statements#case-guards
int a = -1, b = 2;
switch ((a, b))
{
    case (> 0, > 0) when a == b:
        Console.WriteLine($"Both measurements are valid and equal to {a}.");
        break;

    case (> 0, > 0):
        Console.WriteLine($"First measurement is {a}, second measurement is {b}.");
        break;

    default:
        Console.WriteLine("One or both measurements are not valid.");
        break;
}

