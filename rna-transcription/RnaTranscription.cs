using System;
using System.Collections.Generic;
using System.Linq;

public static class RnaTranscription
{
    private static readonly Dictionary<char,char> DnaToRna = new Dictionary<char,char>{
        {'A','U'},
        {'C','G'},
        {'G','C'},
        {'T','A'}
    };
    
    public static string ToRna(string nucleotide)
    {
        return string.Concat(nucleotide.Select(ch => DnaToRna[ch]));
    }
}