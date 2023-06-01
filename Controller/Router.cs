using System;
using System.Collections;

public class Router
{
    private static Stack<Page> Stack = new Stack<Page>();

    public static void ViewCurrentPage()
    {
        GetCurrentPage().Display();
    }

    public static void ChangePage(Page GoToPage)
    {
        Stack.Push(GoToPage);
    }

    public static Page GetCurrentPage()
    {
        return Stack.Peek();
    }

    public static void GoBack()
    {
        if (Stack.Count > 1)
        {
            Stack.Pop();
            ViewCurrentPage();
        }
    }
}