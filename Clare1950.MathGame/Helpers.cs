using System.Linq;

namespace Maths_Game
{
    internal class Helpers
    {
        static List<Game> games = new();

        internal static void CheckAnswer(bool answer)
        {
            if (answer)
            {
                Console.WriteLine("Correct Well Done!");
            }
            else
            {
                Console.WriteLine("Oops, that's wrong!");
            }
        }
        internal static void ListGames()
        {
            Console.WriteLine("\nGame List\n");
            foreach (var game in games)
            {
                Console.WriteLine($"{game.Date} -> {game.Num1} {game.Operation} {game.Num2} {game.Correct}!");
            }
        }

        internal static void AddToGamesList(int num1, int num2, string operation, string correct)
        {
            games.Add(new Game
            {
                Date = DateTime.Now,
                Num1 = num1,
                Num2 = num2,
                Operation = operation,
                Correct = correct
            });
        }
        internal static string? ValidateResult(string answer) {
            while (string.IsNullOrEmpty(answer) || !Int32.TryParse(answer, out _))
            {
                Console.WriteLine("Your answer needs to be a whole number try again");
                answer = Console.ReadLine();
            }
            return answer;
        }
};
};



