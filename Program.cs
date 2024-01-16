using ATM;

List<CardHolder> cardHolders = new List<CardHolder>();

cardHolders.Add(new CardHolder("1234567890123456", 1234, "John", "Doe", 100.31));
cardHolders.Add(new CardHolder("2943837293987243", 2222, "Steve", "Fennington", 2051.32));
cardHolders.Add(new CardHolder("8598768734208434", 3344, "Juanita", "Barros", 5.70));
cardHolders.Add(new CardHolder("0939478632534356", 4445, "Melinda", "Derr", 1031.29));
cardHolders.Add(new CardHolder("0328472353480983", 6667, "Xavier", "Nodan", 500.00));

Console.WriteLine("Welome to the ATM");
Console.WriteLine("Please insert card");
String debitCardNum = "";
CardHolder currentUser;

while(true)
{
    try
    {
        debitCardNum = Console.ReadLine();
        currentUser = cardHolders.FirstOrDefault(a => a.GetNumber() == debitCardNum);
        if (currentUser != null) { break; }
        else { Console.WriteLine("Card not recognized. Please try again"); }
    } catch { Console.WriteLine("Card not recognized. Please try again"); }
}
Console.WriteLine("Please enter your pin: ");
int userPin = 0;
while (true)
{
    try
    {
        userPin = int.Parse(Console.ReadLine());
        if (currentUser.GetPin() == userPin) { break; }
        else { Console.WriteLine("Incorrect pin. Please try again."); }
    }
    catch { Console.WriteLine("Incorrect pin. Please try again"); }
}

Console.WriteLine($"Welcome {currentUser.GetFirstName()}");
int option = 0;
do
{
    Machine.PrintOptions();
    try
    {
        option = int.Parse(Console.ReadLine());
    }
    catch { }
    if (option == 1) { Machine.Deposit(currentUser); }
    else if (option == 2) { Machine.Withdraw(currentUser); }
    else if (option == 3) { Machine.DisplayBalance(currentUser); }
    else if (option == 4) { break; }
    else { option = 0; }
}
while (option != 4);
Console.WriteLine("Thank you! Have a nice day!");

