public class Program
{
    public static void Main()
    {
        Case1();
    }

    public static void Start()
    {
        HomePage homePage = new();
        Router.ChangePage(homePage);
        Router.ViewCurrentPage();
    }

    public static void Case1()
    {
        Start();
    }
}