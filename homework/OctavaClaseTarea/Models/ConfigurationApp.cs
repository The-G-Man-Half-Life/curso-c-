namespace OctavaClaseTarea.Models;

public class ConfigurationApp
{
    private static string versionApp {get; set;}


    static ConfigurationApp()
    {
        versionApp = "12.1.43.69";
    }


    public static void ToShowVersion()
    {
        Console.WriteLine($"The version of the app is {versionApp}");
    }
}