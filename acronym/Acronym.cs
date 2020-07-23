using System;
using System.Text;

public static class Acronym
{
    private static readonly char[] delimiters = {' ', '-', '_'};

    public static string Abbreviate(string phrase)
    {
        StringBuilder sb = new StringBuilder();
        foreach(string word in phrase.ToUpper().Split(delimiters, StringSplitOptions.RemoveEmptyEntries)) {
            sb.Append(word[0]);
        }
        return sb.ToString();
    }
}