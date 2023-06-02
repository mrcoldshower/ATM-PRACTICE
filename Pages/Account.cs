public class AccountPage : Page
{
    public override void Display()
    {
        Console.WriteLine("Accounts Page!");
        BankAccount acc = Router.CurrentAccount!;
        Console.WriteLine($"Name: {acc.Name}");
        Console.WriteLine($"Email: {acc.Email}");
        Console.WriteLine($"Balance: {acc.Balance}");
    }

    public override Page ChoosePage(int input)
    {
        return null!;
    }
}