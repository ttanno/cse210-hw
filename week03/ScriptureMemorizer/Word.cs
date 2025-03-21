public class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }
    public void show()
    {
        _isHidden = false;
    }
    public void Hide()
    {
        if (!_isHidden)
        {
            string word = _text;
            int count = 0;

            foreach (char letter in word)
            {
                count++;
            }
            int i = 1;
            string newWord = "";
            while (i <= count)
            {
                newWord = newWord + "_";
                i++;
            }
            _text = newWord;
            _isHidden = true;
        }
    }
    public string GetDisplayText()
    {
        return _text;
    }
    public bool IsHidden()
    {
        return _isHidden;
    }
}