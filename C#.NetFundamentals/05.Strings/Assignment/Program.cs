

using System;
using System.Text;
using System.Text.RegularExpressions;

string text = @"In object-oriented programming, encapsulation is a fundamental principle that involves bundling data and methods that operate on that data within a single unit or class. This concept allows for the hiding of implementation details from the outside world and exposing only the necessary interfaces for interacting with the object. By encapsulating data and methods together, we promote code reusability, maintainability, and flexibility.One of the key benefits of encapsulation is the ability to enforce access control on the members of a class. This means we can specify which parts of the class are accessible to the outside world and which are not. By using access modifiers such as public, private, and protected, we can control the visibility of members, ensuring that they are only accessed in appropriate ways. For example, we may have a class representing a bank account with properties such as balance and methods for depositing and withdrawing funds. By making the balance property private and providing public methods for depositing and withdrawing funds, we encapsulate the internal state of the account and ensure that it can only be modified in a controlled manner. Encapsulation also allows us to enforce data validation and maintain invariants within our classes. By providing controlled access to data through methods, we can ensure that it is always in a valid state. For instance, when setting the balance of a bank account, we can check that the new balance is not negative before updating the internal state of the object. Overall, encapsulation is a powerful concept in object-oriented programming that promotes modularity, reusability, and maintainability. By bundling data and methods together within a class and controlling access to them, we can create more robust and flexible software systems.";

Console.WriteLine($"Word count: {WordCount(text)}");
Console.WriteLine($"Sentences count: {SentenceCount(text)}");
string word = "encapsulation"; 
Console.WriteLine($"Appearances of the word {word}: {WordEncapsulationCount(text, "encapsulation")}");
Console.WriteLine($"Appearances of the word {word}: {WordEncapsulationCount2(text, "encapsulation")}");
Console.WriteLine($"Reverse string {ReverseString(text)}");
string word1 = "object-oriented programming";
string word2 = "OOP";
Console.WriteLine($"Replace occurrence of {word1} with {word2}: {ReplacingWord(text, word1, word2)}");


int WordCount(string text)
{
    char[] delimiters = { ' ', ',', '.' };
    string[] words = text.Split(delimiters, StringSplitOptions.RemoveEmptyEntries);
    return words.Length;
}

int SentenceCount(string text)
{
    return text.Split(". ",StringSplitOptions.RemoveEmptyEntries).Length;
}

int WordEncapsulationCount(string text, string word)
{
    string pattern = word;
    MatchCollection matches = Regex.Matches(text, pattern);
    return matches.Count();
}

int WordEncapsulationCount2(string text, string word)
{
    int count = 0;
    int start = 0;
    int index = text.IndexOf(word, start);
    while (index != -1)
    {
        count++;
        start = index + word.Length;
        index = text.IndexOf(word, start);
    }
    return count;
}

string ReverseString(string text)
{
    StringBuilder reversedSring = new StringBuilder();
    for (int i = text.Length - 1; i >=0; i--)
    {
        reversedSring.Append(text[i]);
    }
    return reversedSring.ToString().Trim();
}

string ReplacingWord(string text, string word1, string word2)
{
    return Regex.Replace(text, word1, word2);
}

//- Display the word count of this string
//- Display the sentence count of this string
//- Display how often the word "encapsulation" appears in this string
//- Display this string in reverse, without using any C# language feature. (Create your own algorith)
//- In the given string, replace all occurances of "object-oriented programming" with "OOP" and display the new string