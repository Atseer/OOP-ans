using System.Runtime;

namespace Encapsulation.Banking;

public class BankAccount
{
    private string _accountNumber;
    private string _accountHolder;
    private double _balance;

    public string AccountNumber
    {
        get {return _accountNumber;}
        set {_accountNumber = value;}
    }
    public string AccountHolder
    {
        get {return _accountHolder;}
        set {_accountHolder = value;}
    }
    public double Balance
    {
        get {return _balance;}
        set
        {
            if(value < 0)
            {
                _balance = 0.0;
            }
            else
            {
                _balance = value;
            }
        }
    }


    public BankAccount(string accountNumber, string accountHolder, double balance)
    {
        if(string.IsNullOrEmpty(accountNumber))
            _accountNumber = "Unknown";
        else
            _accountNumber = accountNumber;

        if(string.IsNullOrEmpty(accountHolder))
            _accountHolder = "Unknown";
        else 
            _accountHolder = accountHolder;

        if(balance < 0)
            _balance  = 0.0;
        else 
            _balance = balance;
    }
    
    public void Deposit(double amount)
    {
        if(amount >= 0)
            _balance += amount;
    }
    public void Withdraw(double amount)
    {
        if(amount >= 0 && _balance - amount >= 0)
            _balance -= amount;
    }
    public double GetBalance()
    {
        return _balance;
    }
}