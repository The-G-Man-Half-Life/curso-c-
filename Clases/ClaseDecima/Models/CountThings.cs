using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ClaseDecima.Models;

public static class CountThings
{
    public static void CountAmountOfCharactersAndReplaceVocalsWithA(string word)
    {
        int amountOfCharacters = word.Count();

        var newWord = new List<char>();

        for (int i = 0; i < word.Length; i++)
        {
        if(word[i]=='e' || word[i]=='i'||word[i]=='o' || word[i]=='u')
        {
            newWord.Add('a');
        }
        else
        {
            newWord.Add(word[i]);
        }
        }

        string newWordJ = string.Join("",newWord);
        Console.WriteLine($"The word {word} has {amountOfCharacters} and now it is called {newWordJ}");
    }
}
