public static class Data
{
    public static List<BankAccount> BankAccounts = new JsonAccess<BankAccount>(@"\Data\bankAccounts.json").LoadAll();
}