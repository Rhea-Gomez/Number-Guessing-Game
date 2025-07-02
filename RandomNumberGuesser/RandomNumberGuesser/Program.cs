namespace RandomNumberGuesser
{
    internal class Program
    {
        static void RandomNumberGuess()
        {
            Random random = new Random();
            int randomnumber = random.Next(100);
            int counter = 0, guess;

            do
            {
                Console.Write("Guess a number? ");
                guess = int.Parse(Console.ReadLine());
                if (randomnumber > guess)
                {
                    Console.WriteLine("Sorry, too low");
                    counter++;
                }
                else if (randomnumber < guess)
                {
                    Console.WriteLine("Sorry, too high");
                    counter++;
                }
            } while (randomnumber != guess || counter != 6);

                if(randomnumber == guess)
                {
                counter++;
                Console.WriteLine("You won in attempt: " + counter);
                }
        }
        static void Main(string[] args)
        {
            string flag;

            do
            {                
                RandomNumberGuess();
                Console.WriteLine("Do you want to play the game again? (Yes/No): ");
                flag = Console.ReadLine();

            } while (flag != "no");

            
        }
    }
}
