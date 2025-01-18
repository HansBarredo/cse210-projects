using System.IO;

public class Journal
{
        public List<Entry> _entries;



        public void AddEntry(Entry newEntry)
        {
                PromptGenerator promptGenerator = new PromptGenerator();

                newEntry._date = DateTime.Now.ToString("yyyy-MM-dd");
                newEntry._propmtText = promptGenerator.GetRandomPrompt();
                Console.WriteLine(newEntry._propmtText);
                newEntry._entryText = Console.ReadLine();
                Console.Write("Rate your stress level from 1-10: ");
                newEntry._stressLevel = double.TryParse(Console.ReadLine(), out double result) ? result : 0.0;

                _entries.Add(newEntry);
        }

        public void DisplayAll()
        {
                foreach (var entry in _entries)
                {
                        entry.Display();
                }
        }

        public void SaveToFile(string file)
        {
                using (StreamWriter writer = new StreamWriter(file))
                {
                        foreach (var entry in _entries)
                        {
                                writer.WriteLine($"{entry._date}|{entry._propmtText}|{entry._entryText}");
                        }
                }
        }

        public void LoadFromFile(string file)
        {
                string[] lines = File.ReadAllLines(file);

                _entries.Clear();

                foreach (string line in lines)
                {
                        string[] parts = line.Split("|");

                        if (parts.Length == 3)
                        {
                                Entry newEntry = new Entry
                                {
                                        _date = parts[0],
                                        _propmtText = parts[1],
                                        _entryText = parts[2],
                                };

                                _entries.Add(newEntry);
                        }
                }

        }
}