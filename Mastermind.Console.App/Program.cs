using Mastermind.Console.App.Commands;
using Mastermind.Console.App.Constants;
using Mastermind.Console.App.User;

UserInterface.WelcomeBanner();
UserInterface.GameRules();

var answer = Commands.CreateRandomAnswer();
var inputArray = new char[Constants.ArrayLength];

for (var i = 1; i <= Constants.TotalAttempts; i++)
{
    UserInterface.AttemptBanner(attemptNumber: i);

    var userInput = string.Empty;
    var isValidInput = false;

    // Validate user input
    do
    {
        userInput = UserInterface.ReadUserInput();
        isValidInput = int.TryParse(userInput, out int number);
    }
    while (userInput == string.Empty || userInput?.Length != Constants.ArrayLength || !isValidInput);


    inputArray = userInput.ToCharArray();

    var copyAnswer = new List<char>();
    var copyInput = new List<char>();

    // Check for all correct digit in correct position
    for (var j = 0; j < Constants.ArrayLength; j++)
    {
        if (inputArray[j] == answer[j])
        {
            UserInterface.AddPlus();
        }
        else
        {
            copyAnswer.Add(answer[j]);
            copyInput.Add(inputArray[j]);
        }
    }

    // Check for all correct digit in wrong position
    foreach (var input in copyInput)
    {
        if (copyAnswer.Contains(input))
        {
            UserInterface.AddMinus();
        }
    }

    // Check if player has won at end of each attempt
    if (Commands.CheckAnswer(inputArray, answer))
    {
        UserInterface.Winner();
        break;
    }
    else if (i == Constants.TotalAttempts)
    {
        UserInterface.Loser();
    }
}








