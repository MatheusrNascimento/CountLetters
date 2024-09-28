using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace CountLetters
{

    [MemoryDiagnoser]
    public class LetterCounter
    {

        [Params("Frase curta", "Frase longa para testar quanto de memoria é alocado e se demora muito mais para solucionar")]
        public static string sentences { get; set; }

        [Benchmark]
        public void Counter()
        {

            char[] chars = sentences.ToCharArray();
            Dictionary<char, int> countLatters = new Dictionary<char, int>();
            foreach (char c in chars)
            {
                if (countLatters.ContainsKey(c))
                    countLatters[c]++;
                else
                    countLatters.Add(c, 1);
            }
        }

        [Benchmark]
        public void Counter2()
        {

            Dictionary<char, int> countLatters = new Dictionary<char, int>();
            foreach (char c in sentences)
            {
                if (countLatters.ContainsKey(c))
                    countLatters[c]++;
                else
                    countLatters.Add(c, 1);
            }
        }
    }
}