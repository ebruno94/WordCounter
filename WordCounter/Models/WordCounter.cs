using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterProject
{
    public class WordCounter
    {
        private Dictionary<string, int> _dictionary = new Dictionary<string,int>(){};

        public int CountWords(string word)
        {
            return word.Split(' ').Length;
        }
    }
}
