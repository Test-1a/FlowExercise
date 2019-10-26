using System;

namespace FlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            bool condition = true;
            do
            //while (condition)
            {
                Console.WriteLine("Welcome to the Main menu");
                Console.WriteLine("Please use numbers to navigate");
                Console.WriteLine("Quit with 0");
                Console.WriteLine("1: Youth or Pensioner");
                Console.WriteLine("2: Groups");
                int answer = int.Parse( Console.ReadLine() );

                switch (answer)
                {
                    case 0:
                        condition = false;
                        break;

                    case 1:
                        Console.WriteLine("What is your age?");
                        int answer2 = int.Parse( Console.ReadLine() );
                        if (answer2 < 20)
                        {
                            Console.WriteLine("Youth-price: 80 kr");
                        }
                        else if(answer2 > 64)
                        {
                            Console.WriteLine("Pensioner-price: 90 kr");
                        }
                        else
                        {
                            Console.WriteLine("Standard-price: 120 kr");
                        }
                        Console.WriteLine();
                        break;

                    case 2:
                        Console.WriteLine("How many persons are you?");
                        int NumberOfPersons = int.Parse( Console.ReadLine() );
                        int Totalprice = 0;
                        for(int index = 0; index < NumberOfPersons; index += 1)
                        {
                            Console.WriteLine("Please state the age of each person one age at a time");
                            int age = int.Parse( Console.ReadLine() );
                            Totalprice += GetPrice(age);
                        }
                        Console.WriteLine($"You are {NumberOfPersons} persons.");
                        Console.WriteLine($"You will totally pay {Totalprice} kr.");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            } while (condition);

            int GetPrice(int age)
            {
                if (age < 20) return 80;
                else if (age > 64) return 90;
                else return 120;
            }
        }
    }

}
