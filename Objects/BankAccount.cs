public class BankAccount
{
    public int Id { get; set; }
    public string Owner { get; set; }
    protected int _balance { get; set; }

    public BankAccount(int id, string owner)
    {
        Id = id;
        Owner = owner;
        _balance = 0;
    }

    public int GetBalance() => _balance;

    public bool Deposit(int amount)
    {
        if (amount < 0) return false;
        _balance += amount;
        return true;
    }

    public bool Withdraw(int amount)
    {
        if (amount < 0 || _balance - amount < 0) return false;
        _balance -= amount;
        return true;
    }

    public override string ToString()
    {
        return $"({Id}) Owner: {Owner}, Balance: ${_balance}";
    }


}