Console.WriteLine("Welcome to Mastermind Console App Game!");
Console.WriteLine("");
Console.WriteLine("Press any key to start the game.");
Console.ReadKey(true);
Console.Clear();

Console.WriteLine("Rules.");

var chars = "123456";
var answer = new char[4];
var random = new Random();

for (int i = 0; i < answer.Length; i++)
{
    answer[i] = chars[random.Next(chars.Length)];
}

Console.WriteLine("Answer combination has been generated.");
Console.WriteLine(answer);
Console.WriteLine("The combination consists of 4 digits. Each digit is a number between 1 through 6. (ex. 1111 or 6666)");
Console.WriteLine("You have 10 tries to guess the correct combination.");
Console.WriteLine("");
Console.WriteLine("");

Console.WriteLine("Attempt #1 - Please give a 4 digit combination (ex. 1111 or 1234)");
var input = Console.ReadLine();
var inputArray = input.ToCharArray();

for (var i = 0; i < answer.Length; ++i)
{
    if (!inputArray.Contains(answer[i]))
    {
        continue;
    }
    else if (inputArray[i] == answer[i])
    {
        Console.Write("(+)");
    }
    else
    {
        Console.Write("(-)");
    }
}

if (Enumerable.SequenceEqual(inputArray, answer))
{
    Console.WriteLine("You win!");
}







