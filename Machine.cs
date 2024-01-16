namespace ATM
{
    public class Machine
    {
        public Machine()
        {
        }
        public static void PrintOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        public static void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit? ");
            double deposit = double.Parse(Console.ReadLine());
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine($"Thank you for your deposit of {deposit}. Your balance is now {currentUser.GetBalance()}.");
        }

        public static void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw? ");
            double withdrawal = double.Parse(Console.ReadLine());
            if (currentUser.GetBalance() < withdrawal)
            {
                Console.WriteLine("Insufficient balance.");
            }
            else
            {
                currentUser.SetBalance(currentUser.GetBalance() - withdrawal);
                Console.WriteLine($"Your new balance after the withdrawal is {currentUser.GetBalance()}");
            }
        }

        public static void DisplayBalance(CardHolder currentUser)
        {
            Console.WriteLine($"Current balance is {currentUser.GetBalance()}");
        }
    }

}

