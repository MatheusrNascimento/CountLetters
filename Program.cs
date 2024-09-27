// See https://aka.ms/new-console-template for more information
Console.WriteLine("Contador de letras \n ---------------------------------------------------");
System.Console.WriteLine("Informe uma frase");
string sentence = Console.ReadLine() ?? string.Empty;

char[] chars = sentence.ToCharArray();
Dictionary<char, int> countLatters = new Dictionary<char, int>();

foreach (char c in chars)
{
    if(countLatters.ContainsKey(c))    
        countLatters[c]++;
    else
        countLatters.Add(c, 1);
}

foreach (var d in countLatters)
    System.Console.WriteLine($" {d.Key}: {d.Value}");