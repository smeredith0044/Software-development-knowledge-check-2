using System;
using System.ComponentModel;

namespace knowledgecheck2;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("How many records do you want to add? ");
        var numberOfRecords = int.Parse(Console.ReadLine());

        var recordList = new List<Cat>();
        for (int i = 0; i < numberOfRecords; i++)
        {
            // In this loop, populate the object's properties using Console.ReadLine()
            var cat = new Cat();

            Console.WriteLine("Enter the value for animal's name:");
            cat.name = Console.ReadLine();
            Console.WriteLine("Enter the value for animal's sound:");
            cat.sound = Console.ReadLine();


            recordList.Add(cat);
        }
        foreach (Cat record in recordList) {
            Console.WriteLine(record.name);
            Console.WriteLine(record.sound);
        }
    }
}


