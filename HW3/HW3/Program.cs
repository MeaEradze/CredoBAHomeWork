using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task1
            //1.შექმენით კონსოლური აპლიკაცია რომელიც ხმოვანებს დაითვლის
            //* მომხმარებელს შეაყვანინეთ input
            //*მიღებულ input ში დაითვალეთ ხმოვნები
            //*დაბეჭდეთ სულ რამდენი ხმოვანი იყო

            //Enter a string: Hello World
            //Number of vowels: 3

            Console.WriteLine("---------------Task 1---------------");
            Console.WriteLine();
            Console.Write("Enter a string: ");
            string text = Console.ReadLine();
            int vowels = 0;

            foreach (var i in text)
            {
                if (i == 'a' || i == 'e' || i == 'i' || i == 'o' || i == 'u')
                    vowels++;
            }
            Console.WriteLine("Number of vowels: " + vowels);
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Task2
            //2.შექმენით კონსოლური აპლიკაცია, რომელიც დააგენერირებს და შეინახავს გამრავლების ტაბულას მასივში და შემდეგ მის მნიშვნელობებს დაბეჭდავს.
            //მაგ.:
            //Enter a number: 5
            //Multiplication Table of 5:
            //5 x 1 = 5
            //5 x 2 = 10...
            //5 x 10 = 50

            Console.WriteLine("---------------Task 2---------------");
            Console.WriteLine();
            Console.Write("Enter a number between 1-10: ");
            int number = Convert.ToInt32(Console.ReadLine());
            if (number >= 1 && number <= 10)
            {
                Console.WriteLine($"Multiplication Table of {number}: ");
                int[,] multiplicationTableResults = new int[11, 11];

                //ვავსებთ ცხრილს
                for (int i = 1; i < multiplicationTableResults.GetLength(0); i++)
                {
                    for (int j = 1; j < multiplicationTableResults.GetLength(1); j++)
                    {
                        multiplicationTableResults[i, j] = i * j;
                    }
                }
                for (int i = 1; i < multiplicationTableResults.GetLength(1); i++)
                {
                    Console.WriteLine($"{number} x {i} =  {multiplicationTableResults[number, i]}");
                }
            }
            else
            {
                Console.WriteLine("Number is out of range!");
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Task3
            //3.მატრიცების შეკრება:
            //შექმენით ორი 3x3 ზე მატრიცა(ორ განზომილებიანი მასივი)
            //მოხმარებელს შეავსებინეთ მატრიცაში მნიშვნელობები
            //შეკრიბეთ მატრიცები https://en.wikipedia.org/wiki/Matrix_addition

            Console.WriteLine("---------------Task 3---------------");
            Console.WriteLine();

            int[,] matrics1 = new int[3, 3];
            int[,] matrics2 = new int[3, 3];
            int[,] matricesResult = new int[3, 3];
            Console.WriteLine("Fill the first matrices");
            for (int i = 0; i < matrics1.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < matrics1.GetLength(1); j++)
                {
                    matrics1[i, j] = Convert.ToInt32(input[j]);
                    matricesResult[i, j] = matrics1[i, j];
                }
            }
            Console.WriteLine("Fill the second matrices");
            for (int i = 0; i < matrics2.GetLength(0); i++)
            {
                string[] input = Console.ReadLine().Split();
                for (int j = 0; j < matrics2.GetLength(1); j++)
                {
                    matrics2[i, j] = Convert.ToInt32(input[j]);
                    matricesResult[i, j] += matrics2[i, j];
                }
            }
            for (int i = 0; i < matricesResult.GetLength(0); i++)
            {
                for (int j = 0; j < matricesResult.GetLength(1); j++)
                {
                    Console.Write(matricesResult[i, j] + "  ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            Console.WriteLine();
            #endregion

            #region Task4
            //4.შექმენით კონსოლური კალკულატორი რომელსაც მენიუ ექნება.კალკულატორი მანამდე უნდა მუშაობდეს
            //სანამ მომხმარებელს არ მოუნდება მისი გათიშვა.
            //მაგ.:
            //Calculator Menu:
            //1) Addition
            //2) Subtraction
            //3) Multiplication
            //4) Division
            //5) Exit
            //Choose an option: 1
            //Enter first number: 10
            //Enter second number: 5
            //Result: 15
            //[The menu repeats until the user selects Exit]

            Console.WriteLine("---------------Task 4---------------");
            Console.WriteLine();

            string[] menu = { "Addition", "Subtraction", "Multiplication", "Division", "Exit" };
            bool exit = true;
            while(exit)
            {
                for (int i = 0; i < menu.Length; i++)
                {
                    Console.WriteLine($"{i + 1}. {menu[i]}");
                }

                Console.Write("Choose an option: ");
                int option = Convert.ToInt32(Console.ReadLine());

                if (option >= 1 && option <= 4)
                {
                    int o = option - 1;
                    Console.Write("Enter first number: ");
                    int x = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    int y = Convert.ToInt32(Console.ReadLine());

                    switch (o)
                    {
                        case 0:
                            Console.WriteLine($"Result: {x + y}");
                            break;
                        case 1:
                            Console.WriteLine($"Result: {x - y}");
                            break;
                        case 2:
                            Console.WriteLine($"Result: {x * y}");
                            break;
                        case 3:
                            Console.WriteLine($"Result: {x / y}");
                            break;
                        default:
                            Console.WriteLine("Something is wrongg!");
                            break;
                    }
                }
                else if (option == 5)
                {
                    Console.WriteLine("You are closing the calculator.");
                    exit = false;
                }
                else
                {
                    Console.WriteLine("Option out of range");
                }
            }
            #endregion

            Console.ReadKey();
        }
    }
}