public class CreateAccountPage : Page
{
    public new bool IsInputPage = true;
    public override void Display()
    {
        Console.Clear();
        GetInput("Create An Account:", new string[] { "Email", "Password", "[Create]" });
        // Utils.Incomplete();
    }

    public override Page ChoosePage(int input)
    {
        return null!;
    }

    public void CreateAccount(string name)
    {
        List<BankAccount> bankAccounts = Data.BankAccounts;

        int nextId;
        if (bankAccounts.Count == 0 || bankAccounts == null) nextId = 1;
        else nextId = bankAccounts[bankAccounts.Count - 1].Id + 1;

        BankAccount bankAccount = new BankAccount(nextId, name);

        if (bankAccounts == null)
        {
            JsonAccess<BankAccount>.BankAccountAccess.WriteAll(new List<BankAccount>() { bankAccount });
        }
        else
        {
            bankAccounts.Add(bankAccount);
            JsonAccess<BankAccount>.BankAccountAccess.WriteAll(bankAccounts);
        }
    }
}