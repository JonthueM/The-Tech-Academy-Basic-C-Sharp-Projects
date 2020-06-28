using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace step137_147_ArrayOfAssigments
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro
            Console.WriteLine("Welcome to a the Array of Assignments, this 11 part assignment can't be completed without your input so hang on to your seat, get a beer and enjoy the digital adventure! \n\n ");
            //Assignment 137 - Poetry Marker
                //Store & Prompt
            string[] poetry = { "Loves To Dance","Makes More Money via Freelance", "Always Take Matters into their hands","Hates paying that expensive insurance","Shuns Code that lacks Substance & Relevance","Anxiously stares at the account balance waiting for that stimulus check","Regrets adding their name to this program" };
            Console.WriteLine("Welcome to the Poetry Marker Program, We already have poem but the only thing that we need to complete it is your name, so kindly type it below");
            string name = Console.ReadLine();
                //Cycle & Print
            for (int p =0; p <poetry.Length;p++)
            {
                Console.WriteLine(name + " " + poetry[p]);
            }
            Console.WriteLine("The End! \n \n");

            //Assignment 138to139 - The Infinite Line
            Console.WriteLine("Time for some Loops\n");
            string quote = $"\"Tomorrow I wake with second wind and strong because of pride. \n I know I fought with all my heart to keep the dream alive.\" \n- Tupac[And 2Morrow] \n Shared by {name} \n \n";
            //138 - Infinte Chaos
            //InfiniteLoop
            //    for (int c = 0; c <50; c--)
            //{
            //    Console.WriteLine(c + quote);

            //}

            //FiniteLoop
            for (int f = 0; f < 3; f++)
            {
                Console.WriteLine("Loop "+ f + "---"+"\n" +quote);

            }
            //Assignment 140 - Determine the Fate of the Loop
                //Store & Prompt
            string iLoveYouBarney = $"I love you, you love me\nWe're a happy family\nWith a great big hug\nAnd a kiss from me to you\nWon't you say you love me too?\n\nI love you, you love me\nWe're best friends like friends should be\nWith a great big hug\nAnd a kiss from me to you\nWon't you say you love me too?\n Looped by {name}\n\n ";
            Console.WriteLine("Determine the fate of the Loop by specifying how many times the barney I love You song is displayed");
            int fate = Convert.ToInt32(Console.ReadLine());
                //Processing Fate
            for (int b = 0; b < fate; b++)
            {
                Console.WriteLine($"Loop  {b}---\n"+iLoveYouBarney);
            }

            //Assignment 141 - Suprise Song
                //Store & Prompt
            string spiceUpYourLife = $"This is for you {name}\nWhen you're feelin' sad and low\nWe will take you where you gotta go\nSmilin', dancin', everything is free\nAll you need is positivity\n\nColours of the world\nSpice up your life\nEvery boy and every girl\nSpice up your life\nPeople of the world\nSpice up your life aah\n---Spice Girl[Spice Up Your Life]";
            Console.WriteLine("Pick a number? `u`");
            int numberPicked = Convert.ToInt32(Console.ReadLine());
                //Processing Number
            for (int s = 0; s <= numberPicked; s++)
            {
                Console.WriteLine("\nLoop " + s + "---\n" + spiceUpYourLife);

            }
            //Assignment 142-144 - Retriever
            //Store & Prompt
            List<string> tools = new List<string>() { "Wrench", "Screwdriver", "Hammer", "Drill", "Chain Saw" };
            Console.WriteLine("Well Hello [0]\n\nWelcome to the Shop, We have limited quantity of Wreches, Screwdriver, and other stuff. Let us know and we will see if they are still available", name);
            string findTools = Console.ReadLine();
                //Retreive
            Console.WriteLine("\nRetrieving Now");
            for (int t = 0; t < tools.Count; t++)
            {
                if (tools[t] == findTools)
                {
                    //Assignment 144 - Once the match it found the execution stops
                    Console.WriteLine("\nHands over " + tools[t] + " to [0] \nGeezz You could say thank you!!!",name);

                }

                else
                {
                    Console.WriteLine("No Match");
                }


            }

            //Assignment 145 - Spot the Pair
            List<string> duplicate = new List<string> { "Cat", "Fat,", "Cat", "Fat", "Nap" };
            Console.WriteLine("\n\n Hello to Spot the Pair, I will show you the list of words and you sadly have to choose one word that has a pair in the list.");
            for (int spot = 0; spot < duplicate.Count; spot++)
            {
                Console.WriteLine(duplicate[spot]);
            }
            Console.WriteLine("Choose one word that has a pair!");
            string selectedWord = Console.ReadLine();
            for (int d = 0; d < duplicate.Count; d++)
            {
                if (duplicate[d] == selectedWord)
                {
                    Console.WriteLine(duplicate[d]);
                }
                else
                {//Step 146 Add code to that above loop that tells a user if they put in text that isn’t in the List.
                    Console.WriteLine($"\nAhhh {name}  where do you see from the list above");
                }
                Console.ReadLine();
            }
            //Assignment 147 - Final Duplicate
            List<string> spotIt = new List<string> { "Cream","Peaches", "Cream", "Peaches", "Apple" };
            Console.WriteLine("\n \n Spot the Pair\n");
            for (int show = 0; show < spotIt.Count;show++)
            {
                Console.WriteLine(spotIt[show]);
            }
            Console.WriteLine("[0], Chose one pair!", name);
            string selectedOne = Console.ReadLine();
            foreach(string spotOne in spotIt)
            {
                if(spotOne == selectedOne)
                {
                    Console.WriteLine("[0] It's In",selectedOne);
                }
                else
                {
                    Console.WriteLine("[1] Doesn't Exit", selectedOne);
                }
            }
            Console.ReadLine();
        }
    }
}
