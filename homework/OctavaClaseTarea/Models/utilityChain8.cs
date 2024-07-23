namespace OctvaClaseTarea.Models;

public static class utilityChain8
{
    

    public static void ReverseChain(string chainText)
    {
        string newWord = new string(chainText.Reverse().ToArray());
        Console.WriteLine(newWord);
    }
}