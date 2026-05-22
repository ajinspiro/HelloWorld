// See https://aka.ms/new-console-template for more information
using EOPL.Examples;

Enumerable.Range(0, 15).Select(InSWrapper.InS).ToList().ForEach(Console.WriteLine);
Console.WriteLine("Hello, World!");