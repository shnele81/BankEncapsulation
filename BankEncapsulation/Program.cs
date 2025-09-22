namespace BankEncapsulation
{
    public class Program
    {
        static void Main(string[] args)
        {
            var newAccount = new BankAccount();
            Console.WriteLine("How much will you deposit?");
            var amountToDeposit = double.Parse(Console.ReadLine());
            newAccount.Deposit(amountToDeposit);
            Console.WriteLine($"Your bank account is now {newAccount.GetBalance()}");
        }
    }
}
