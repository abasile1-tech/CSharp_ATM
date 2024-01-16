namespace ATM
{
    public class CardHolder
    {
        private string cardNumber;
        private int pin;
        private string firstName;
        private string lastName;
        private double balance;

        public CardHolder(string number, int pin, string firstName, string lastName, double balance)
        {
            cardNumber = number;
            this.pin = pin;
            this.firstName = firstName;
            this.lastName = lastName;
            this.balance = balance;
        }

        public string GetNumber()
        {
            return cardNumber;
        }

        public void SetNumber(string number)
        {
            cardNumber = number;
        }

        public int GetPin()
        {
            return pin;
        }

        public void SetPin(int pin)
        {
            this.pin = pin;
        }

        public string GetFirstName()
        {
            return firstName;
        }

        public void SetFirstName(string firstName)
        {
            this.firstName = firstName;
        }

        public string GetLastName()
        {
            return lastName;
        }

        public void SetLastName(string lastName)
        {
            this.lastName = lastName;
        }

        public double GetBalance()
        {
            return balance;
        }

        public void SetBalance(double balance)
        {
            this.balance = balance;
        }

        public void PrintOptions()
        {
            Console.WriteLine("Please choose from one of the following options...");
            Console.WriteLine("1. Deposit");
            Console.WriteLine("2. Withdraw");
            Console.WriteLine("3. Show Balance");
            Console.WriteLine("4. Exit");
        }

        public void Deposit(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to deposit? ");
            double deposit = Double.Parse(Console.ReadLine());
            currentUser.SetBalance(currentUser.GetBalance() + deposit);
            Console.WriteLine($"Thank you for your deposit of {deposit}. Your balance is now {currentUser.GetBalance()}.");
        }

        public void Withdraw(CardHolder currentUser)
        {
            Console.WriteLine("How much would you like to withdraw? ");
            double withdrawal = Double.Parse(Console.ReadLine());
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

        public void DisplayBalance(CardHolder currentUser)
        {
            Console.WriteLine($"Current balance is {currentUser.GetBalance()}");
        }
    }
}
