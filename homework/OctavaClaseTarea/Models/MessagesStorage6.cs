namespace OctvaClaseTarea.Models;

public class MessagesStorage6
{
    private static List <string> Messages {get; set;} = new List<string> {"ni hao", "wo shi"};

    public static void AddANewMessage(string newMessage)
    {
        Messages.Add(newMessage);
    }
    public static void ShowAllMessages()
    {
        int counter = 0;
        foreach (var item in Messages)
        {
            Console.WriteLine(counter + ". "+ item);   
            counter++;
        }
    }
}