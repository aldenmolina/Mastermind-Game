using Mastermind.Console.App.Commands;
using Mastermind.Console.App.Constants;
using Mastermind.Console.App.User;

UserInterface.WelcomeBanner();
UserInterface.GameRules();

var answer = Commands.CreateRandomAnswer();

var inputArray = new char[Constants.ArrayLength];
for (var i = 1; i <= Constants.TotalAttempts; i++)
{
    UserInterface.AttemptBanner(i);

    var userInput = string.Empty;
    var isValidInput = false;

    do
    {
        userInput = UserInterface.ReadUserInput();
        isValidInput = int.TryParse(userInput, out int number);
    }
    while (userInput == string.Empty || userInput.Length != Constants.ArrayLength || !isValidInput);


    inputArray = userInput.ToCharArray();

    var copyAnswer = new char[Constants.ArrayLength];
    var copyInput = new char[Constants.ArrayLength];

    for (var j = 0; j < Constants.ArrayLength; j++)
    {
        if (inputArray[j] == answer[j])
        {
            UserInterface.AddPlus();
            copyAnswer[j] = default(char);
            copyInput[j] = default(char);
        }
        else
        {
            copyAnswer[j] = answer[j];
            copyInput[j] = inputArray[j];
        }
    }

    for (var j = 0; j < Constants.ArrayLength; j++)
    {
        if (copyInput[j] == default(char))
        {
            continue;
        }
        else if (copyAnswer.Contains(copyInput[j]))
        {
            UserInterface.AddMinus();
        }
    }

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








