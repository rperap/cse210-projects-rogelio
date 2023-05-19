using System;
using System.Collections.Generic;
using System.IO;
using System.Globalization;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
   
            Journal newJournal = new Journal();

            bool menuLoop;
            do
            {
                Console.Clear();
                menuLoop = MainMenu(newJournal);
                Console.Clear();
            }
            while (menuLoop);
        }

        static bool MainMenu(Journal journal)
        {
            //Create a menu for the user to iteract with
            Console.WriteLine("--- Welcome to your daily journal ---\n");
            Console.WriteLine("What will you do today\n");

            Console.WriteLine("1- Create Entry");
            Console.WriteLine("2- Read Entries");
            Console.WriteLine("3- Save Journal");
            Console.WriteLine("4- Load Journal");
            Console.WriteLine("5- Close Journal");
            string userChoice = Console.ReadLine();

            if (userChoice == "1")
            {
                Console.Clear();
                Entry newEntry = new Entry();
                newEntry.CreateEntry();
                Console.Clear();
                newEntry.DisplayEntry();
                Console.WriteLine();
                Console.WriteLine("Entry created sucessfully");
                journal._entries.Add(newEntry);
                Console.ReadLine();
            }

            else if (userChoice == "2")
            {
                if (journal._entries.Count == 0)
                {
                    Console.Clear();
                    Console.WriteLine("There are no new entries, write new entries or load an existing file.");
                    Console.ReadLine();
                }

                else
                {
                    Console.Clear();
                    Console.WriteLine("These are all the current entries:");
                    journal.DisplayEntries();
                    Console.ReadLine();
                }
            }

            else if (userChoice == "3")
            {
                Console.Clear();
                Console.WriteLine("Please enter a file name");
                string filename = Console.ReadLine();
                ConfirmFileSave(filename, journal);
            }

            else if (userChoice == "4")
            {
                Console.Clear();
                Console.WriteLine("Please enter a file name");
                string filename = Console.ReadLine();
                ConfirmFileLoad(filename, journal);

            }

            else if (userChoice == "5")
            {
                Console.Clear();
                Console.WriteLine("Goodbye");
                Console.ReadLine();
                return false;
            }
            return true;
        }

        
        static  void ConfirmFileSave(string filename, Journal journal)
        {
            Console.Clear();
            if (File.Exists(filename))
            {
                bool answerLoop = true;

                while (answerLoop)
                {
                    Console.WriteLine($"Warning, {filename} already exist," + 
                    " if you save, your file will be overwritten. Do you still want to save? (yes/no)");
                    string answer = Console.ReadLine();

                    if (answer.ToUpper() == "YES")
                    {    
                        Console.Clear();
                        journal._filename = filename;
                        journal.SaveJournal();
                        Console.WriteLine("File Saved Succesfully");
                        Console.ReadLine();
                        answerLoop = false;
                    }
                    else if (answer.ToUpper() == "NO")
                    {
                        Console.Clear();
                        Console.WriteLine("File not saved");
                        Console.ReadLine();
                        answerLoop = false;
                    }
                    else
                    {
                        Console.Clear();
                        Console.WriteLine("Please enter yes or no");
                        Console.ReadLine();
                    }
                }
            }
            else{
                Console.WriteLine("File Saved Sucessfully");
            }
        }

        static  void ConfirmFileLoad(string filename, Journal journal)
        {
            Console.Clear();
            if (File.Exists(filename))
            {
                journal._filename = filename;
                journal.LoadJournal();
                Console.WriteLine("File Loaded Succesfully");
                Console.ReadLine();
                
            }

            else{
                Console.WriteLine("No such file in directory");
            }
        }

    }
}

