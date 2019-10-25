using System;

namespace FlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            do
            {
                Console.WriteLine("Welcome to the Main menu");
                Console.WriteLine("Please use numbers to navigate");
                Console.WriteLine("Quit with 0");
                int answer = int.Parse(Console.ReadLine());

                switch (answer)
                {
                    case 0:
                        condition = false;
                        break;

                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            } while (condition);
        }
    }

}
