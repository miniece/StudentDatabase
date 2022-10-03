using System.Reflection.Metadata.Ecma335;

namespace StudentDatabase
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool goAgain = true;
            while (goAgain == true)
            {
                //array of student names
                string[] names = { "Mick", "Leonardo", "Oliver", "Ethan", "Ciara", "Ron", "Dean", "Kiara", "Alex" };

                string[] hometowns = { "Detroit", "Rochester", "Ann Arbor", "Atlanta", "Chicago", "Toronto", "Grand Rapids", "Seattle", "Los Angeles" };

                string[] favFoods = { "pizza", "pasta", "burgers", "ribs", "sandwiches", "steak", "tacos", "hot dogs", "burrito" };


                //start of the program
                Console.Write("Welcome! Which student would you like to learn more about? Enter a number 1-9: ");
                int studentNumber = int.Parse(Console.ReadLine());



                //if user inputs a number that is out of bounds
                if (studentNumber < 1 || studentNumber > 9)
                {
                    Console.Write("Sorry, that number is out of bounds, please enter a number 1-9: ");
                    studentNumber = int.Parse(Console.ReadLine());
                }
                //category choices
                int studentsArray = studentNumber - 1;
                int hometownsArray = studentNumber - 1;
                int favFoodsArray = studentNumber - 1;

                Console.WriteLine("Student " + studentNumber + " is " + names[studentsArray] + ". What would you like to know? Enter \"hometown\" or \"favorite food\".");
                

                //while loop for if a user inputs
                string category = Console.ReadLine();
                bool tryAgain = true;
                while (tryAgain == true)
                {
                    if (category == "hometown" || category == "Hometown")
                    {
                        Console.WriteLine(names[studentsArray] + " is from " + hometowns[hometownsArray] + ".");
                        tryAgain = false;
                    }
                    else if (category == "favorite food" || category == "food" || category == "Favorite Food" || category == "Food")
                    {
                        Console.WriteLine(names[studentsArray] + "'s favorite food is " + favFoods[favFoodsArray] + ".");
                        tryAgain = false;
                    }
                    else
                    {
                        Console.WriteLine("Sorry, that category was not listed. Please try again. Enter \"hometown\" or \"favorite food\".");
                        category = Console.ReadLine().ToLower();
                        tryAgain = true;
                    }
                }
                

                goAgain = AskToContinue();
            }

        }
        public static bool AskToContinue()
        {
            Console.WriteLine("Would you like to learn about another student? Y/N.");
            string answer = Console.ReadLine().ToLower();

            if (answer == "y")
            {
                return true;
            }
            else if (answer == "n")
            {
                return false;
            }
            else
            {
                Console.WriteLine("Sorry, that was an invalid response, please input a valid response.");
                return AskToContinue();
            }
        }
        }
}
