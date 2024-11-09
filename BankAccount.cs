using System;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace BankAccount;
public class BankAccount
{
    private double _amount;

    public BankAccount(double amount)
    {
        if (amount <= 0)
        {
            throw new ArgumentException();
        }
        _amount = amount;
    }

    public string Deposit(double amount)
    {
        if (amount < 0)
        {
            return "Error: Deposit amount must be positive";

        }
        if (amount == 0)
        {
            return "Error: Deposit amount must be greater than 0";
        }

        _amount += amount;

        return "Deposit successful";
    }

    public string Withdraw(double amount)
    {

        if (amount < 0)
        {
            return "Error: Withdrawal amount must be positive";

        }
        if (amount == 0)
        {
            return "Error: Withdrawal amount must be greater than 0";
        }

        if (_amount - amount < 0)
        {
            return "Error: Insufficient funds available";
        }

        _amount -= amount;

        return "Withdrawal successful";
    }

    public double Balance()
    {
        return Math.Round(_amount, 2);
    }
}
