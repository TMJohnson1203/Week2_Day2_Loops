using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week2_Day2_Loops
{
    class Program
    {
        static void Main(string[] args)
        {

            ////for(int i = 0; i <= 10; i += 2) ;
            ////// Console.Writeine(i);

            ////for (int counter = 50; counter <= 100; counter++)
            ////{
            ////    //    Console.WriteLine(counter);
            ////}

            ////string greetings = "My name is Teresa.";
            ////string[] words = greetings.Split();

            ////for(int i =0; i < greetings.Length;i++)
            ////{
            ////    Console.WriteLine(words[i]);
            ////}

            //for (int i = 1; i <= 10; i++)
            //{
            //    Console.WriteLine(i);
            //}

            //for (int counter = 50; counter <= 100; counter++)
            //{
            //    Console.WriteLine(counter);
            //}

            //// Console.Write will print it all on one line

            //string greeting = "My name is Teresa Marie";
            //string[] words = greeting.Split();

            //for (int i = 0; i < words.Length; i++)
            //{
            //    Console.WriteLine(words[i]);
            //}

            //// Prints all of the words in an array
            //// above is same as 
            //// string [] words = { "My", "name", " is", "Teresa", "Marie"} 

            //// PRACTICE slides

            //string[] dayOfWeek = { "Monday", "Tuesday", "Wednesday" };
            //for (int i = 0; i <= dayOfWeek.Length - 1; i++)
            //{
            //    Console.WriteLine(dayOfWeek[i]);
            //}


            ////string fairyTale = "Once upon a time...";
            ////string[] storyWords

            ////Console.WriteLine(Array.Split(storyWords));

            //// for each

            //string sentence = "Once upon a time";
            //string[] storyWords = sentence.Split();
            //Array.Reverse(storyWords);
            //for (int i = 0; i < storyWords.Length; i++)
            //{
            //    Console.WriteLine(storyWords[i]);
            //}

            //string[] months = { "Jan", "Feb", "Mar", "Apr", "May", "Jun", "Jul", "Aug", "Sept", "Oct", "Nov", "Dec" };

            //foreach (string month in months)
            //{
            //    Console.WriteLine(month);
            //}

            //string[] bands = { "U2", "Pearl Jam", "Soundgarden", "NIN", "INXS" };

            //foreach (string band in bands)
            //{
            //    Console.WriteLine(band);
            //}

            //int[] luckyNum = { 13, 19, 7, 3, 19 };
            //Array.Sort(luckyNum);

            //foreach (int number in luckyNum)
            //{
            //    Console.WriteLine("Your lucky number is  " + number);
            //}


            //string[] favFoods = { "pizza", "pop-tarts", "popcorn" };
            //foreach (string food in favFoods)
            //{
            //    Console.WriteLine(food);
            //}

            //for (int i = 10; i > 10; i--)
            //{
            //    Console.WriteLine(i);
            //}
            //// why is the above i-- instead of i++

            //Console.WriteLine("Do you want to play the game?");
            //string playAgain = Console.ReadLine().ToUpper(); 
            //while(playAgain == "YES")
            //{
            //    Console.WriteLine("It's a rematch");
            //    Console.WriteLine("Do you want to play again? (YES/ NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}

            //Console.WriteLine("Would you like to check in to the patient portal? (YES/ NO)");
            //string userAnswer = Console.ReadLine().ToUpper();

            //while(userAnswer == "YES" || userAnswer == "NO")
            //{
            //    Console.WriteLine("Patient Portal system.");
            //    Console.WriteLine("Please enter your full name?");
            //    Console.ReadLine();
            //    Console.WriteLine("Please enter your six digit ID number");
            //    Console.ReadLine();
            //    Console.WriteLine("What was the time of your appointment?");
            //    Console.ReadLine();
            ////}

            //string playAgain;
            //do
            //{
            //    Console.WriteLine("Great game!");
            //    Console.WriteLine("Do you want to play again? (YES/NO)");
            //    playAgain = Console.ReadLine().ToUpper();
            //}
            //while (playAgain == "YES");
            //Console.WriteLine("Thank you for playing!");

            //string addGpa;
            //do
            //{
            //    Console.WriteLine("Please enter the letter grade for your class.");
            //    addGpa = Console.ReadLine().ToUpper();
            //    Console.WriteLine("Please enter the letter grade for another class.");
            //    addGpa = Console.ReadLine().ToUpper();
            //}
            //while(addGpa == "YES");

            for(int i = 0; i <= 20; i++)
            {
                if(i % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }

            Console.WriteLine("The loop has finished.");

            for (int i = 1; i <=2; i++)
            {
                for (int j = 1; j <= 4; j++)
                {
                    Console.Write(j); 
                }
                Console.WriteLine();
            }

            Console.WriteLine("Please enter an integer between 1 and 100.");

            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write(col + " ");
                }
                Console.WriteLine();
            }




        }
    }
}
