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

        public static string decode(String input)
        {
            foreach (String key in wordToCode.Keys)
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
