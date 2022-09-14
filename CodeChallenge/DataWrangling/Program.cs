// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Regex splitSpaces = new(@"\s+");
Regex numOnly = new(@"\d+");
int lowestSpread = int.MaxValue;
int spreadDay = int.MaxValue;
string file = DataWrangling.Properties.Resources.weatherdat;
string[] lines = File.ReadAllLines(file);
foreach (var s in lines)
{
    var l = splitSpaces.Split(s.Trim());
     
    if (int.TryParse(numOnly.Match(l[0]).Value,out int day) && int.TryParse(numOnly.Match(l[1]).Value, out int high) && int.TryParse(numOnly.Match(l[2]).Value, out int low))
    {
        var testSpread = high - low;        
        if( lowestSpread > testSpread) {
            lowestSpread = testSpread;
            spreadDay = day;
        }
    }    
}
Console.WriteLine($"Day {spreadDay} had the lowest temperature spread at {lowestSpread}");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();