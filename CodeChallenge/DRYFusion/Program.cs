// See https://aka.ms/new-console-template for more information
using DRYFusion;

Console.WriteLine(SpreadCalculator.CalculateSpreads(new Weather(DRYFusion.Properties.Resources.weatherdat).Spreads));
Console.WriteLine(SpreadCalculator.CalculateSpreads(new Football(DRYFusion.Properties.Resources.footballdat).Spreads));

Console.WriteLine("Press any key to exit.");
Console.ReadKey();