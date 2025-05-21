using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeechRecognision
{
    internal class Decoder
    {
        public static Dictionary<String, String> wordToCode = new Dictionary<string, string> { };

        List sortedKeys = new List<String>();

        public static string decode(string input)
        {
            // Сортируем ключи по убыванию длины
            if (sortedKeys.Count == 0 || sortedKeys.Count != wordToCode.Keys.Count)
            { 
                sortedKeys = wordToCode.Keys.OrderByDescending(k => k.Length);
            }

            foreach (string key in sortedKeys)
            {
                if (input.Contains(key))
                {
                    input = input.Replace(key, wordToCode[key]);
                }
            }
            return input;
        }

    }
}
