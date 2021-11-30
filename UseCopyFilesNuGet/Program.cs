// See https://aka.ms/new-console-template for more information
using NuGetCopyFiles;

var text = await File.ReadAllTextAsync("Files/File.txt");
var output = new Hello().Echo(text);
Console.WriteLine(output);
Console.ReadLine();
