
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class Entry
    {
        public string _prompt;
        public string _date;
        public string _entry;

        public Entry()
        {
        }

        public void CreateEntry()
        {
            PromptGenerator newPrompt = new PromptGenerator();

            _prompt = newPrompt.CreatePrompt();
            _date = DateTime.Now.ToShortDateString();

            Console.WriteLine($"{_prompt}");
            _entry = Console.ReadLine();
        }

        public void DisplayEntry()
        {
            Console.WriteLine($"{_date}\n{_prompt}\n{_entry}");
            Console.WriteLine();
        }
    }
}

