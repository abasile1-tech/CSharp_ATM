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
    }
}
