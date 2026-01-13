using System;

namespace ChooseYourOwnAdventure
{
    class Program
    {
        static void Main(string[] args)
        {
            /* THE MYSTERIOUS NOISE */

            // Start by asking for the user's name:
            Console.Write("What is your name?: ");
            string name = Console.ReadLine();
            Console.WriteLine($"Hello, {name}! Welcome to our story.");
            Console.WriteLine("It begins on a cold rainy night. You're sitting in your room and hear a noise coming from down the hall. Do you go investigate?\r\n");
            Console.Write("Type YES or NO: ");


            string noiseChoice = Console.ReadLine();
            string noiseChoiceUpper = noiseChoice.ToUpper();

            if (noiseChoiceUpper == "NO")
            {
                Console.WriteLine("Not much of an adventure if we don't leave our room!\r\nTHE END.\r\n");
            }
            else if (noiseChoiceUpper == "YES")
            {
                Console.WriteLine("You walk into the hallway and see a light coming from under a door down the hall.\r\nYou walk towards it. Do you open it or knock?\r\n");
                Console.Write("Type OPEN or KNOCK: ");
                string doorChoice = Console.ReadLine();
                string doorChoiceUpper = doorChoice.ToUpper();
                if (doorChoiceUpper == "KNOCK")
                {
                    Console.WriteLine("A voice behind the door speaks. It says, \"Answer this riddle: \"\r\n\"Poor people have it. Rich people need it. If you eat it, you die. What is it?\"\r\n");
                    Console.Write("Type your answer: ");
                    string riddleAnswer = Console.ReadLine();
                    string riddleAnswerUpper = riddleAnswer.ToUpper();
                    if (riddleAnswerUpper == "NOTHING")
                    {
                        Console.WriteLine("The door opens and NOTHING is there.\r\nYou turn off the light and run back to your room and lock the door.\r\nTHE END.\r\n");
                    }
                    else
                    {
                        Console.WriteLine("You answered incorrectly. The door doesn't open.\r\nTHE END.\r\n");
                    }
                }
                else if (doorChoiceUpper == "OPEN")
                {
                    Console.WriteLine("The door is locked! See if you can find the key.\r\n");
                    Console.Write("Enter a number (1-3):\r\n");
                    string keyChoice = Console.ReadLine();
                    string keyChoiceUpper = keyChoice.ToUpper();
                    switch (keyChoiceUpper)
                    {
                        case "1":
                            Console.WriteLine("You choose the first key. Lucky choice!\r\nThe door opens and NOTHING is there. Strange...\r\nTHE END.\r\n");
                            break;
                        case "2":
                            Console.WriteLine("You choose the second key. The door doesn't open.\r\nTHE END.\r\n");
                            break;
                        case "3":
                            Console.WriteLine("You choose the third key. The door doesn't open.\r\nTHE END.\r\n");
                            break;
                    }
                }

            }
        }
    }
}



