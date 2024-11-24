using System;
using System.IO;
using System.Linq;

class Program
{
    static void Main()
    {
        string file1 = "Text1.txt";
        string file2 = "Text2.txt";

        string contentFromFile1 = File.ReadAllText(file1);

        File.AppendAllText(file2, contentFromFile1);

        string updatedContent = File.ReadAllText(file2);

        int wordCount = updatedContent.Split(new[] { ' ', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries).Count();

        Console.WriteLine("Total number of words in Text2.txt: " + wordCount);
    }
}
