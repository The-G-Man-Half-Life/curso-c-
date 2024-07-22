namespace OctvaClaseTarea.models;

public class Configuration3
{
    private static bool DarkMode {get; set;}


    static Configuration3()
    {
        DarkMode = false;
    }

    public static void ChangeMode()
    {
        if(DarkMode == false)
        {
            DarkMode = true;
        }
        else
        {
            DarkMode = false;
        }
        Console.WriteLine($"The Dark mode is in mode: {DarkMode}");
    }
}
