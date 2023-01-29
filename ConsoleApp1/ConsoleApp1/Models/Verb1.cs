namespace ConsoleApp1.Models;
using CommandLine;

[Verb("verb1", HelpText = "it is the first verb we created")]
public class Verb1
{
    [Option('t', "IsTrue", Required = false, Default = false,
        HelpText = "whether this is true or not")]
    public bool IsTrue { get; set; }

    [Option('r', "RandomText", Required = true,
        HelpText = "Random Text you want to use")]
    public string RandomText { get; set; } = "";
}