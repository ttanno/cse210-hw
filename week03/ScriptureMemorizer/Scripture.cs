public class Scripture
{
    private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        string[] splitWords = text.Split(' ');
        foreach (string word in splitWords)
        {
            _words.Add(new Word(word));
        }
    }

    public void HideRandomWords(int count)
    {
        Random rand = new Random();
        int hiddenWords = 0;

        // Count how many words are still visible
        int visibleWords = 0;
        foreach (var word in _words)
        {
            if (!word.IsHidden())
            {
                visibleWords++;
            }
        }

        // If fewer visible words than count, adjust the count
        int wordsToHide = count;
        if (visibleWords < count)
        {
            wordsToHide = visibleWords;
        }

        while (hiddenWords < wordsToHide)
        {
            int index = rand.Next(_words.Count);
            if (!_words[index].IsHidden())
            {
                _words[index].Hide();
                hiddenWords++;
            }
        }
    }


    public string GetDisplayText()
    {
        string scriptureText = "";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return $"{_reference.GetDisplayText()} {scriptureText}";
    }
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
            {
                return false;
            }
        }
        return true;
    }
}