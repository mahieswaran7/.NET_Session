using System;

class Program
{
    static void Main()
    {
        string name = "Eswaran";

        // Format()
        string formattedString = string.Format("Name: {0}", name);
        Console.WriteLine(formattedString);

        // Split()
        string sentence = "I am learning C#";
        string[] words = sentence.Split(' ');
        Console.WriteLine(string.Join(", ", words));

        // Substring()
        string sub = name.Substring(2, 4); // Starts at index 2 and takes 4 characters
        Console.WriteLine(sub);

        // Compare()
        string str1 = "Hello";
        string str2 = "World";
        int comparison = string.Compare(str1, str2);
        Console.WriteLine(comparison); // Will print negative if str1 < str2

        // Replace()
        string replaced = sentence.Replace("learning", "mastering");
        Console.WriteLine(replaced);

        // Contains()
        bool contains = sentence.Contains("learning");
        Console.WriteLine(contains); // True

        // Join()
        string[] names = { "Dinesh", "Bala", "Yokesh" };
        string joined = string.Join(", ", names);
        Console.WriteLine(joined);

        // Trim()
        string paddedString = "   Changepond Technologies   ";
        string trimmed = paddedString.Trim();
        Console.WriteLine($"'{trimmed}'");

        // EndsWith()
        bool endsWith = sentence.EndsWith("C#");
        Console.WriteLine(endsWith); // True

        // IndexOf()
        int index = sentence.IndexOf("learning");
        Console.WriteLine(index); // Position of 'learning'

        // Remove()
        string removed = sentence.Remove(2, 5); // Removes 5 characters starting at index 2
        Console.WriteLine(removed);

        // ToUpper()
        string upper = sentence.ToUpper();
        Console.WriteLine(upper);

        // ToLower()
        string lower = sentence.ToLower();
        Console.WriteLine(lower);

        // PadLeft()
        string paddedLeft = "123".PadLeft(5, '0'); // Pads with '0' to a total width of 5
        Console.WriteLine(paddedLeft);

        // PadRight()
        string paddedRight = "123".PadRight(5, '0'); // Pads with '0' to a total width of 5
        Console.WriteLine(paddedRight);

        // StartsWith()
        bool startsWith = sentence.StartsWith("I am");
        Console.WriteLine(startsWith); // True

        // ToCharArray()
        char[] charArray = sentence.ToCharArray();
        Console.WriteLine(charArray);

        // LastIndexOf()
        string str3 = "apple orange banana apple";
        int lastIndex = str3.LastIndexOf("apple");
        Console.WriteLine(lastIndex); // Last occurrence of 'apple'

        //LastIndexOf()

        string vegetables = "tomato potato tomato carrot onion drumstick tomato onion";
        int lastind = vegetables.LastIndexOf("tomato");
        Console.WriteLine(lastind);
    }
}
