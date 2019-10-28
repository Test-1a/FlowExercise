using System;
using System.Text.RegularExpressions;

namespace FlowExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //keeps the loop going until we want to quit
            bool condition = true;

            //I use do-while so "break" will not quit the loop
            do
            {
                //Console.WriteLine("Welcome to the Main menu");
                //Console.WriteLine("Please use numbers to navigate");
                //Console.WriteLine("Quit with 0");
                //Console.WriteLine("1: Youth or Pensioner");
                //Console.WriteLine("2: Groups");
                //Console.WriteLine("3: Print arbitrary text 10 times");
                //Console.WriteLine("4: The 3rd word");
                ReadMenu();
                //int answer = int.Parse(Console.ReadLine());
                int answer = IntRead();
                

                switch (answer)
                {
                    //Quitting the program
                    case 0:
                        //only here do we want to quit the loop
                        condition = false;
                        break;

                    //Are you Youth or Pensioner
                    case 1:
                        Console.WriteLine("What is your age?");
                        //int answer2 = int.Parse(Console.ReadLine());
                        int answer2 = IntRead();
                        if (answer2 < 5)
                        {
                            Console.WriteLine("Child price: 0 kr");
                        }
                        else if (answer2 < 20)
                        {
                            Console.WriteLine("Youthprice: 80 kr");
                        }
                        else if (answer2 > 64 && answer2 <= 100)
                        {
                            Console.WriteLine("Pensioner price: 90 kr");
                        }
                        else if (answer2 > 100)
                        {
                            Console.WriteLine("Pensioner-over-100 price: 0 kr");
                        }
                        else
                        {
                            Console.WriteLine("Standard-price: 120 kr");
                        }
                        Console.WriteLine();
                        break;


                    //Groups
                    case 2:
                        Console.WriteLine("How many persons are you?");
                        //int NumberOfPersons = int.Parse(Console.ReadLine());
                        int NumberOfPersons = IntRead();
                        int Totalprice = 0;
                        for (int index = 0; index < NumberOfPersons; index += 1)
                        {
                            Console.WriteLine("Please state the age of each person one age at a time");
                            int age = IntRead();   //int.Parse(Console.ReadLine());

                            //GetPrice returns the price for each person in the group
                            Totalprice += GetPrice(age);
                        }
                        Console.WriteLine($"You are {NumberOfPersons} persons.");
                        Console.WriteLine($"You will totally pay {Totalprice} kr.");
                        Console.WriteLine();
                        break;

                    //arbritary text 10 times
                    case 3:
                        Console.WriteLine("Print your text:");
                        string answer3 = AskForString();  //Console.ReadLine();
                        for (int index = 0; index < 10; index += 1)
                        {
                            //"Write" does NOT change to the next line
                            Console.Write($"{index}: {answer3}");

                            //add a comma after the text except after the last one
                            if (index < 9)
                            {
                                Console.Write(", ");
                            }
                        }
                        Console.WriteLine();
                        Console.WriteLine();
                        break;

                    //the 3rd word
                    case 4:
                        Console.WriteLine("Write your text containing at least 3 words");
                        var answer4 = AskForString();   //Console.ReadLine();

                        //replaces more than 1 whitespace with only 1 whitespace
                        var replaced = Regex.Replace(answer4, @"\s+", " ");

                        //split the string and remove the whitespace between the words
                        var splitted = replaced.Split(" ");

                        Console.WriteLine($"The 3rd word is: \"{splitted[2]}\".");
                        Console.WriteLine();
                        break;

                    default:
                        Console.WriteLine("Wrong Input!");
                        break;
                }
            } while (condition);

            //returns price depending on your age
            int GetPrice(int age)
            {
                if (age < 5) return 0;
                else if (age < 20) return 80;
                else if (age > 64 && age <= 100) return 90;
                else if (age > 100) return 0;
                else return 120;
            }

            string AskForString()
            {
                //we have not got the correct answer yet
                bool correctAnswer = false;
                string answer;

                do
                {
                    answer = Console.ReadLine();

                    if (!string.IsNullOrEmpty(answer))
                    {
                        //now we have got the correct answer => exit loop
                        correctAnswer = true;
                    }
                } while (!correctAnswer);

                return answer;
            }

            int IntRead()
            {
                bool success = false;
                int answer;

                do
                {
                    string input = AskForString();

                    //trying to parse the string to int
                    //if successful => returns true => quit the loop
                    //if NOT successful => returns false
                    success = int.TryParse(input, out answer);

                    if (!success)
                    {
                        Console.WriteLine("Only numbers, please");
                        Console.WriteLine();
                    }

                } while (!success);

                return answer;
            }

            void ReadMenu()
            {
                Console.WriteLine("Welcome to the Main menu");
                Console.WriteLine("Please use numbers to navigate");
                Console.WriteLine("Quit with 0");
                Console.WriteLine("1: Youth or Pensioner");
                Console.WriteLine("2: Groups");
                Console.WriteLine("3: Print arbitrary text 10 times");
                Console.WriteLine("4: The 3rd word");
            }
        }
    }

}
