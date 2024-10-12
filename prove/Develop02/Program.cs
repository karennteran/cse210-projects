using System;

public class Program
{
    static void Main(string[] args)
    {
        Journal journal = new Journal();  //Create a new journal
        PromptGenerator PromptGenerator = new PromptGenerator(); // Prompts generator
        bool isRunning = true;

        while (isRunning)
        {
            Console.WriteLine("What would you like to do next? Select from the following choices.");
            Console.WriteLine("1. Write");
            Console.WriteLine("2. Display");
            Console.WriteLine("3. Load");
            Console.WriteLine("4. Save");
            Console.WriteLine("5. Quit");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1": // Write a new entry
                    Entry newEntry = new Entry
                    {
                        _date = DateTime.Now.ToString("MM-dd-yyyy HH:mm:ss"),
                        _promptText = promptGenerator.GetRandomPrompt()
                    };
                    Console.WriteLine(newEntry._promptText);
                    newEntry._enrtyText = Console.ReadLine();
                    journal.AddEntry(newEntry);
                    break;

                case "2": // show all entries
                    journal.DisplayAll();
                    break;

                case "3": // load entries from file
                    Console.WriteLine("Enter the name of the file o load");
                    string loadFile =Console.ReadLine();
                    break;

                case "4": // save file to txt
                    Console.WriteLine("Enter the name of the file to save");
                    string saveFile = Console.ReadLine();
                    journal.saveToFile(saveFile);
                    break;

                Case "5": // Quit the program
                    isRunning = false;
                    Console.WriteLine("Exiting program...");
                    break;

                default:
                    Console.WriteLine("Option not valid, try again.");
                    break;
            }
        }
    }
}

