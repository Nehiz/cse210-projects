public class Word
{
    private string _text;
    private bool _hidden;

    //Constructor
    public Word(string text)
    {
        _text = text;
        _hidden = false; // By default, the word is not hidden
    }

    // Methods
    public string GetDisplayText()
    {
        if (_hidden)
        {
            return "-----"; // Display underscores if the word is hidden

        }
        else{
            return _text; // DIsplay the actual word
        }
    }

    public void Hide()
    {
        _hidden = true;
    }

    public void Show()
    {
        _hidden = false;
    }

    public bool isHidden()
    {
        return _hidden;
    }

}