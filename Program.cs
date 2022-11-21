using System;

namespace Magic_8_Ball
{
    class Program
    {
        static void Main(string[] args)
        {
            //Variables I've used
            string userQuestion = "";
            string continueLoop = "Y";
            int rand = 0;
            int prevRand = 0;

            //Start a loop
            while (continueLoop == "Y")
            {
                //Write introductory line for user
                Console.WriteLine(">Ask the Almighty Ball a Question!");

                //User inputs a string which sets the userQuestion plus "?"
                userQuestion = Console.ReadLine() + "?";

                //Reject input if blank and reask for an input
                while (userQuestion == "?")
                {
                    Console.WriteLine(">Do not waste the Almighty Ball's time, ask me a question!");
                    userQuestion = Console.ReadLine() + "?";
                };

                //Appliation writes lines back to console
                Console.WriteLine($">The foolish user has asked the Almighty Ball... {userQuestion}");
                System.Threading.Thread.Sleep(2000);
                think();

                //Roll a random variable, but not the one from before
                while (rand == prevRand)
                {
                    Random rnd = new Random();
                    rand = rnd.Next(1, 6);
                }
                prevRand = rand;

                //Debug rand value
                //Console.WriteLine($"{rand}");

                //Use a bunch of if's to write out the random response
                if (rand == 1)
                {
                    Console.WriteLine(">It is certain");
                };

                if (rand == 2)
                {
                    Console.WriteLine(">Most likely");
                };

                if (rand == 3)
                {
                    Console.WriteLine(">Maybe");
                };

                if (rand == 4)
                {
                    Console.WriteLine(">Cannot predict now");
                };

                if (rand == 5)
                {
                    Console.WriteLine(">Very doubtful");
                };

                //Wait and ask for another question
                System.Threading.Thread.Sleep(1500);
                Console.WriteLine(">...Ask again? (Y/N)");
                continueLoop = Console.ReadLine();

                //If yes or Y then clear console, else console will end
                if (continueLoop == "Y")
                {
                    Console.Clear();
                }

                //Handles alterative inputs
                if (continueLoop == "y") //if y
                {
                    continueLoop = "Y";
                    Console.Clear();
                }
                if (continueLoop == "Yes") //if Yes
                {
                    continueLoop = "Y";
                    Console.Clear();
                }
                if (continueLoop == "yes") //if yes
                {
                    continueLoop = "Y";
                    Console.Clear();
                }
            }

            //End console Chat if not Y or Yes
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine(">Goodbye");

        }

        private static void think()
        {
            Console.WriteLine(">The Almighty Ball ponders your question...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(">...");
            System.Threading.Thread.Sleep(1000);
            Console.WriteLine(">hmm...");
            System.Threading.Thread.Sleep(1500);
            Console.WriteLine(">oh-ho!");
            System.Threading.Thread.Sleep(1500);
        }

    }
}
