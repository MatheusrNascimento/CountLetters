using BenchmarkDotNet.Attributes;
using BenchmarkDotNet.Running;
using CountLetters;

internal class Program
{
    
    private static void Main(string[] args)
    {

        BenchmarkRunner.Run<LetterCounter>();
    }
}