public class AboutPage : Page
{
    public override void Display()
    {
        Console.WriteLine("About page!\n");
        Console.WriteLine("This online banking platform was created by Pablo Sanderman.");
        Console.WriteLine("This is just to practise object-orientated-design-programming (OODP).");
        Console.WriteLine("\nPress any key to return to the home page...");
        Console.ReadKey(true);
        Router.GoBack();
    }

    public override Page ChoosePage(int input)
    {
        return null!;
    }
}