using System;
using System.Runtime.CompilerServices;

public class Word{
private string _text;
private bool _hidden;

public Word(string text, bool hidden){
    _text = text;
    _hidden = hidden;
}
public void Hide()
{
    _hidden = true;
}

public void Show()
{
    _hidden = false;
}

public bool IsHidden()
{
    return _hidden;
}

public string GetRenderedText()
{
    return _hidden ? "____" : _text;
}

}
