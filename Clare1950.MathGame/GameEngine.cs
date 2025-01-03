namespace Maths_Game

{
    internal class GameEngine
    {
       internal bool AdditionSum()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 101);
            int num2 = rnd.Next(1, 101);
            Console.WriteLine($"{num1} + {num2}");
            string sum = (num1 + num2).ToString();
            string? answer = Console.ReadLine();
            answer = Helpers.ValidateResult(answer);
            if (answer == sum)
            {
                Helpers.AddToGamesList(num1, num2, "+", "correct");
                return true;

            }
            else
            {
                Helpers.AddToGamesList(num1, num2, "+", "incorrect"); 
                return false;
            }

        }

       internal bool MultiplySum()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 13);
            int num2 = rnd.Next(1, 13);
            Console.WriteLine($"{num1} x {num2}");
            string sum = (num1 * num2).ToString();
            string? answer = Console.ReadLine();
            answer = Helpers.ValidateResult(answer);
            if (answer == sum)
            {
                Helpers.AddToGamesList(num1, num2, "x", "correct");
                return true;
            }
            else
            {
                Helpers.AddToGamesList(num1, num2, "x", "incorrect");
                return false;
            }
        }

       internal bool SubtractSum()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 20);
            int num2 = rnd.Next(1, 20);

            while (num1 < num2)
            {
                num1 = rnd.Next(1, 20);
                num2 = rnd.Next(1, 20);
            }

            Console.WriteLine($"{num1} - {num2}");
            string sum = (num1 - num2).ToString();
            string? answer = Console.ReadLine();
            answer = Helpers.ValidateResult(answer);
            if (answer == sum)
            {
                Helpers.AddToGamesList(num1, num2, "-", "correct");
                return true;
            }
            else
            {
                Helpers.AddToGamesList(num1, num2, "-", "incorrect");
                return false;
            }
        }

        internal bool DivideSum()
        {
            Random rnd = new Random();
            int num1 = rnd.Next(1, 20);
            int num2 = rnd.Next(1, 20);

            while (num1 % num2 > 0)
            {
                num1 = rnd.Next(1, 100);
                num2 = rnd.Next(1, 100);
            }

            Console.WriteLine($"{num1} / {num2}");
            string sum = (num1 / num2).ToString();
            string? answer = Console.ReadLine();
            answer = Helpers.ValidateResult(answer);
            if (answer == sum)
            {
                Helpers.AddToGamesList(num1, num2, "/", "correct"); ;
                return true;
            }
            else
            {
                Helpers.AddToGamesList(num1, num2, "/", "incorrect");
                return false;
            }
        }
    }
}
