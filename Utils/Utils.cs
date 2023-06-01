public static class Utils
{
    public static void ExitApplication()
    {
        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey(true);
        Environment.Exit(0);
    }

    public static void Incomplete()
    {
        Console.WriteLine("\nThis part of the program is incomplete. Press any key to go back...");
        Console.ReadKey(true);
        Router.GoBack();
    }
}