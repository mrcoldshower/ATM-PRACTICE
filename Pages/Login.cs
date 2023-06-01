public class LoginPage : Page
{
    public override void Display()
    {
        Console.Clear();
        Console.WriteLine("Login page!");
        Utils.Incomplete();
    }

    public override Page ChoosePage(int input)
    {
        return null!;
    }
}