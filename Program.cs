using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string pangram = "The quick brown fox jumps over the lazy dog";

// 1. Dividir en palabras
string[] words = pangram.Split(' ');


// 2. Crear array para palabras invertidas
string[] reversedWords = new string[words.Length];


// 3. Invertir cada palabra
foreach (string word in words)
{
  char[] letters = word.ToCharArray();
  Array.Reverse(letters);
  string reversedWord = new string(letters);
  reversedWords[Array.IndexOf(words, word)] = reversedWord;
}


// 4. Unir palabras invertidas con espacios

string result = string.Join(" ", reversedWords);
Console.WriteLine(result);




