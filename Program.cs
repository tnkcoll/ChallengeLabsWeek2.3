namespace ChallengeLabsWeek2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId;
            string userPassword;
            bool isPasswordMatch;

            Console.WriteLine("Please enter your User Id.");
            userId = Console.ReadLine();

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Please enter your password.");
                userPassword = Console.ReadLine();
                isPasswordMatch = MatchPassword(userPassword);
                if (isPasswordMatch)
                {
                    Console.WriteLine("Congratulations! Correct Password.");
                    break;
                }
                else
                {
                    if (i > 1)
                    {
                        Console.WriteLine("That was the incorrect password. You have " + (i - 1) + " tries left before the system locks you out.");
                    }
                    else
                    {
                        Console.WriteLine("That was the incorrct password. You have been locked out of the system.");
                    }
                }
            }

        }

        public static bool MatchPassword(string password)
        {
            const string correctPassword = "password";
            if (password == correctPassword)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
