namespace ConsoleApp1.Models;
using CommandLine;

[Verb("otherverb", HelpText = "it is not the first verb")]
public class OtherVerb
{
    [Option('n', "Num", Required = false, Default = 9,
        HelpText = "random int")]
    public int Num { get; set; }

}