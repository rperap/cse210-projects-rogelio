
using System;
using System.Collections.Generic;
using System.Text;

namespace Classes
{
    class PromptGenerator
    {
        public PromptGenerator()
        {
        }

        public string CreatePrompt()
        {
            string[] file = System.IO.File.ReadAllLines("JournalPrompts.txt");
            Random random = new Random();
            var randomIndex = random.Next(0, file.Length);
            string prompt = file[randomIndex];

            return prompt;   
        }
    }
}
