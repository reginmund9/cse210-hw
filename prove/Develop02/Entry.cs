using System;
using System.Collections.Generic;
using System.IO;

class Entry
{
    public string _prompt;
    public string _response;
    public DateTime _date;

    public Entry(string Prompt, string Response)
    {
        _prompt = Prompt;
        _response = Response;
        _date = DateTime.Now.Date;
        
    }

    public override string ToString()
    {
        return $"{_date.ToShortDateString()}: {_prompt}\n{_response}\n";
    }
}


