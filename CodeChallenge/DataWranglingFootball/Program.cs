// See https://aka.ms/new-console-template for more information
using System.Text.RegularExpressions;

Regex splitSpaces = new(@"\s+");
Regex numOnly = new(@"\d+");
int lowestSpread = int.MaxValue;
string bestTeam = "No team";
string file = DataWranglingFootball.Properties.Resources.footballdat;
string[] lines = File.ReadAllLines(file);
foreach (var s in lines)
{
    var l = splitSpaces.Split(s.Trim());

    if (l.Length > 1 && int.TryParse(numOnly.Match(l[6]).Value, out int high) && int.TryParse(numOnly.Match(l[8]).Value, out int low))
    {
        var testSpread = Math.Abs(high - low);
        if (lowestSpread > testSpread)
        {
            lowestSpread = testSpread;
            bestTeam = l[1];
        }
    }
}
Console.WriteLine($"Team {bestTeam} had the smallest score difference at {lowestSpread}");
Console.WriteLine("Press any key to exit.");
Console.ReadKey();