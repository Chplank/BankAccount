namespace BankAccount;

internal class Programm
{
    static void Main(string[] args)
    {
        BankAccount account = new BankAccount(1000.00);

        string result1 = account.Deposit(500.00);
        Console.WriteLine(result1);               // Output: "Deposit successful"
        Console.WriteLine(account.Balance());       // Output: 1500.00

        string result2 = account.Withdraw(800.00);
        Console.WriteLine(result2);               // Output: "Withdrawal successful"
        Console.WriteLine(account.Balance());       // Output: 700.00

        string result3 = account.Withdraw(800.00);
        Console.WriteLine(result3);               // Output: "Error: Insufficient funds available"
        Console.WriteLine(account.Balance());       // Output: 700.00

    }
}