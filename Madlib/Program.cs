using System;
using System.Globalization;

namespace Game
{
    static class Madlib
    {
        //declare variables
        static string[] Words = {
        "creature",
        "luminous",
        "ghastly",
        "spectral",
        "countryman",
        "farrier",
        "farmer",
        "dreadful",
        "apparition",
        "hound"
        };

        static string[] Prompts = {
        "creature",
        "luminous",
        "ghastly",
        "spectral",
        "countryman",
        "farrier",
        "farmer",
        "dreadful",
        "apparition",
        "hound"
        };
        static string Story;
        static string GameTitle;
        public static void Run()
        {
            Start();
            GetWords();
            WriteStory();
            End();
        }

        static void Start()
        {
            //write out a header 
            Console.WriteLine("--------");
            Console.WriteLine("Welcome to Madlib");
            Console.WriteLine("--------");
        }
        static void GetWords()
        {
            //ask player to enter words
            for (int i = 0; i < Words.Length; i++)
            {
                Console.Write("Please enter a/an " + Prompts[i] + ": ");
                Words[i] = Console.ReadLine();
            }
           
            //clear the console window
            Console.Clear();
        }
        static void WriteStory()
        {
            //Concatenate strings to make a title
            GameTitle = "The " + Words[1] + " " + Words[2] + " " + Words[0];

            //So we can capitalize the words in our title
            TextInfo TitleCase = new CultureInfo("en-US", false).TextInfo;
            GameTitle = TitleCase.ToTitleCase(GameTitle);

            Console.WriteLine(GameTitle);

            //change the title of the application window
            Console.Title = GameTitle;

            //write out finished story
            Story = "They all agreed that it was a huge {0}, {1}, {2}, and {3}.\nI have cross-examined these men, one of them a hard-headed {4},\none a {5}, and one a moorland {6}, who all tell the same story\nof this {7} {8}, exactly corresponding to the {9} of the legend.";
            Console.WriteLine(Story, Words[0], Words[1], Words[2], Words[3], Words[4], Words[5], Words[6], Words[7], Words[8], Words[9]);
        }
        static void End()
        {
            //keep window open and prompt for exit
            Console.WriteLine("Please press enter to exit");
            Console.ReadKey();
        }
    }
    class Program
    {
        static void Main()
        {
            Madlib.Run();
        }
    }
}
