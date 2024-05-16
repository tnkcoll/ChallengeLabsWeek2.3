namespace ChallengeLabsWeek2._3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string userId;
            string userPassword;
            bool isUserIdMatch;
            bool isPasswordMatch;

            for (int i = 3; i > 0; i--)
            {
                Console.WriteLine("Please enter your User Id.");
                userId = Console.ReadLine();
                
                Console.WriteLine("Please enter your password.");
                userPassword = Console.ReadLine();
                isUserIdMatch = MatchUserId(userId);
                isPasswordMatch = MatchPassword(userPassword);
                if (isUserIdMatch && isPasswordMatch)
                {
                    Console.WriteLine("Congratulations! Correct UserID and Password.");
                    break;
                }
                else
                {
                    if (i > 1)
                    {
                        Console.WriteLine("Either the user Id or password is incorrect. You have " + (i - 1) + " tries left before the system locks you out.");
                    }
                    else
                    {
                        Console.WriteLine("You have been locked out of the system.");
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
        public static bool MatchUserId(string user)
        {
            const string correctUserId = "Ted";
            if (user == correctUserId)
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
