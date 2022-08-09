

namespace Mastermind.Console.App.Commands
{
    public class Commands
    {
        public static char[] CreateRandomAnswer()
        {
            var chars = "123456";
            var answer = new char[4];
            var random = new Random();

            for (int i = 0; i < answer.Length; i++)
            {
                answer[i] = chars[random.Next(chars.Length)];
            }
            return answer;
        }

        public static bool CheckAnswer(char[] inputArray, char[] answer) =>
            Enumerable.SequenceEqual(inputArray, answer);
    }
}
