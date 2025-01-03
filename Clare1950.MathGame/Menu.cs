namespace Maths_Game
{
    internal class Menu
    {
        GameEngine engine = new();
        internal void ShowMenu()
        {
            bool playGame = true;
            
            while (playGame)
            {
                Console.WriteLine("\n..........................................................................");
                Console.WriteLine("To play an ADD game press +");
                Console.WriteLine("To play a SUBTRACT game press -");
                Console.WriteLine("To play a MULTIPLY game press x");
                Console.WriteLine("To play a DIVIDE game press /");
                Console.WriteLine("Press g to see a list of previous games");
                Console.WriteLine("Or press q to quit");
                Console.WriteLine("..........................................................................\n");

                string? operationChoice = Console.ReadLine();
                if (operationChoice == "q")
                {
                    playGame = false;
                }
                else if (operationChoice == "g")
                {
                    Helpers.ListGames();
                }
                else if (operationChoice == "+")
                {
                    Helpers.CheckAnswer(engine.AdditionSum());
                }
                else if (operationChoice == "x")
                {
                    Helpers.CheckAnswer(engine.MultiplySum());
                }

                else if (operationChoice == "-")
                {

                    Helpers.CheckAnswer(engine.SubtractSum());
                }

                else if (operationChoice == "/")
                {

                    Helpers.CheckAnswer(engine.DivideSum());
                }
                else
                {
                    {
                        Console.WriteLine("Please enter one of the following options.");
                    }
                }
            }
        }
    }
}
