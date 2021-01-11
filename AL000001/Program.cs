using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace AL000001
{
    class Program
    {
        static void Main(string[] args)
        {
            // Dado un texto, obtener el número de veces que se repite cada palabra
            string text = "No comas ajos ni cebollas, porque no saquen por el olor tu villanería. Anda despacio; habla con resposo; pero no de manera que parezca que te escuchas a ti mismo; que toda afectación es mala. Come poco y cena más poco; que la salud de todo el cuerpo se fragua en la oficina del estómago. Sé templado en el beber, considerando que el vino demasiado ni guarda secreto, ni cumple palabra. Ten cuenta, Sancho, de no mascar a dos carrillos, ni de erutar delante de nadie";

            string[] words = separateWords(text);

            Dictionary<string, int> result = wordRepetitions(words);

            printCollection(result);
        }

        static string[] separateWords(string text)
        {
            return text.Split(' ');
        }

        static Dictionary<string, int> wordRepetitions(string[] words)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();

            foreach (var word in words)
            {
                string _word = normalize(word);
                if (dict.ContainsKey(_word))
                    ++dict[_word];
                else
                    dict[_word] = 1;
            }
            return dict;
        }

        static string normalize(string text)
        {
            text = text.ToLower().Replace(",", "").Replace(".", "").Replace(";", "");
            return text;
        }

        static void printCollection(Dictionary<string, int> collection)
        {
            foreach (var value in collection)
            {
                Console.WriteLine(value);
            }
        }
    }
}
