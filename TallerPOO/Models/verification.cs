namespace TallerPOO.Models;

public static class verification
{
    public static string NormalizationOfString(string word1)
    {
        bool flag = true;
        string validWord = "";

        while (flag == true)
        {
            
            string word = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(word) == false)
            {
                validWord= word.ToLower().Trim();
                flag = false;
            }
            else
            {   
                Console.WriteLine("You must write a valid string");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return validWord;
    }

    public static int verificateInt(string word1)
    {
        
        int number = 0;
        bool flag = true;

        while (flag == true)
        {

            string word = Console.ReadLine();

            if(int.TryParse(word, out number)==true && word.Contains("-")==false)
            {
                flag = false;
            }
            else
            {   
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;
        
    }

    public static double verificateDouble(string word1)
    {
        double number = 0;
        bool flag = true;

        while (flag == true)
        {
            string word = Console.ReadLine();

            if(double.TryParse(word, out number)==true&& word.Contains("-")==false)
            {
                flag = false;
            }
            else
            {   
                Console.WriteLine("You must write a valid number");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return number;
    }

        public static string NormalizationEmail(string word1)
    {
        bool flag = true;
        string validWord = "";

        while (flag == true)
        {
            
            string word = Console.ReadLine();

            if(string.IsNullOrWhiteSpace(word) == false && word.Contains("@")== true && word.Contains(".com")==true)
            {
                validWord= word.ToLower().Trim();
                flag = false;
            }
            else
            {   
                Console.WriteLine("You must write a valid email");
                Console.WriteLine("Press any key to continue");
                Console.ReadKey();
                Console.Clear();
                Console.Write(word1);
            }
        }
        Console.Clear();
        return validWord;
    }

}