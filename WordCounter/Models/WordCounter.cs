using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterProject
{
    public class RepeatCounter
    {
        private Dictionary<string, int> _dictionary = new Dictionary<string,int>(){};

        // SIMPLE CASE -- might not use it, I found a better way.
        public int CountWords(string word)
        {
            return word.Split(' ').Length;
        }

        public void SetDictionary(string input)
        {
            string[] wordArray = input.Split(' ');
            foreach (string word in wordArray)
            {
                if (!_dictionary.ContainsKey(word))
                {
                    _dictionary.Add(word, 1);
                }
                else
                {
                    _dictionary[word]++;
                }
            }
        }

        public Dictionary<string, int> GetDictionary()
        {
            return _dictionary;
        }
    }
}
