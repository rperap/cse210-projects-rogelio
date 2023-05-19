using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace Classes
{
    class Journal
    {
        public List<Entry> _entries = new List<Entry>();
        public string _filename;
        
        public Journal()
        {
        }
        public void DisplayEntries()
        {
            foreach (Entry entry in _entries)
            {
                entry.DisplayEntry();
            }
        }
        public void SaveJournal()
        {
            using (StreamWriter outputFile = new StreamWriter(_filename))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}~{entry._prompt}~{entry._entry}");
                }
            }

        }
        public void LoadJournal()
        {
            string[] lines = System.IO.File.ReadAllLines(_filename);

            foreach (string line in lines)
            {
                string[] parts = line.Split("~");

                string date = parts[0];
                string prompt = parts[1];
                string entry = parts[2];

                Entry newEntry = new Entry();
                newEntry._date = date;
                newEntry._prompt = prompt;
                newEntry._entry = entry;

                _entries.Add(newEntry);
            }
        }

    }
}
