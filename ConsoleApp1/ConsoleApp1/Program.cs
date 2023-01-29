using CommandLine;
using ConsoleApp1.Models;

namespace ConsoleApp1;

public static class Program
{
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<
            Verb1, OtherVerb>(args).WithParsed<Verb1>(DoVerb1)
            .WithParsed<OtherVerb>(DoOtherVerb);

    }

    private static void DoVerb1(Verb1 obj)
    {
        Console.WriteLine("Verb1 Selected");
        Console.WriteLine(obj.IsTrue);
        Console.WriteLine(obj.RandomText);
    }
    
    private static void DoOtherVerb(OtherVerb inputs)
    {
        Console.WriteLine("OtherVerb Selected");
        Console.WriteLine(inputs.Num);
    }
}