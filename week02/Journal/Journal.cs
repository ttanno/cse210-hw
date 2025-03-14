    using System.IO;
    public class Journal
    {
        public List<Entry> _entries;
        public void AddEntry(Entry newEntry)
        {
            _entries.Add(newEntry);
        }
        public void DisplayAll()
        {

            foreach (Entry entry in _entries)
            {
                entry.Display();
            }
        }
        public void SaveToFile(string file)
        {
            using (StreamWriter outputFile = new StreamWriter(file))
            {
                foreach (Entry entry in _entries)
                {
                    outputFile.WriteLine($"{entry._date}||{entry._promptText}||{entry._entryText}");
                }
            }
        }
    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();

        string[] lines = File.ReadAllLines(file);
        foreach (string line in lines)
        {
            string[] parts = line.Split("||");

            if (parts.Length == 3)
            {
                Entry entry = new Entry
                {
                    _date = parts[0].Trim(),
                    _promptText = parts[1].Trim(),
                    _entryText = parts[2].Trim()
                };

                _entries.Add(entry);
            }
        }
    }
}
    