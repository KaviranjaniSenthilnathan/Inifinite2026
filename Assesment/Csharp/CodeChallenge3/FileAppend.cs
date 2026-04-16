using System;
using System.IO;
public class FileAppend
{
    public void AppendTextToFile(string filePath)
    {
        Console.Write("Enter text to append: ");
        string text = Console.ReadLine();

        using (StreamWriter sw = new StreamWriter(filePath, true))
        {
            sw.WriteLine(text);
        }

        Console.WriteLine("Text appended successfully.");
    }
}