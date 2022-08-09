namespace Mastermind.Console.App.User
{
    public class UserInterface
    {
        public static void WelcomeBanner()
        {
            System.Console.WriteLine("Welcome to Mastermind Console App Game!");
            System.Console.WriteLine("");
            System.Console.WriteLine("Press any key to start the game.");
            System.Console.ReadKey(true);
            System.Console.Clear();
        }

        public static void GameRules()
        {
            System.Console.WriteLine("Rules.");
            System.Console.WriteLine("Answer combination has been generated.");
            System.Console.WriteLine("The combination consists of 4 digits. Each digit is a number between 1 through 6. (ex. 1111 or 6666)");
            System.Console.WriteLine("A plus (+) sign is printed for every digit that is correct and in the right position.");
            System.Console.WriteLine("A minus (-) sign is printed for every digit that is correct, but in the wrong position.");
            System.Console.WriteLine("You have 10 tries to guess the correct combination.");
        }

        public static void AttemptBanner(int attemptNumber)
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine($"Attempt #{attemptNumber} - Please give a 4 digit combination (ex. 1111 or 1234)");
        }

        public static string? ReadUserInput() => System.Console.ReadLine();

        public static void AddPlus() => System.Console.Write("(+)");
        public static void AddMinus() => System.Console.Write("(-)");
        public static void Winner()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("You win!");
        }
        public static void Loser()
        {
            System.Console.WriteLine("");
            System.Console.WriteLine("");
            System.Console.WriteLine("You lose!");
        }

    }
}
