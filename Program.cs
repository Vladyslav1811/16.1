using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.Write("Source file path: ");
            string src = Console.ReadLine();

            Console.Write("Destination file path: ");
            string dest = Console.ReadLine();

            File.Copy(src, dest, true);
            Console.WriteLine("File copied successfully!");
        }
        catch (Exception e)
        {
            Console.WriteLine($"Error: {e.Message}");
        }
    }
}
