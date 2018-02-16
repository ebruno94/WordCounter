using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace WordCounterProject
{
    public class WordCounter
    {
        private Dictionary<string, int> _dictionary = new Dictionary<string,int>(){};

        // SIMPLE CASE
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
