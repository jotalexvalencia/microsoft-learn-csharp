using System.Globalization; 
CultureInfo.CurrentCulture = new CultureInfo("en-US");
string first = "5";
string second = "7";
int sum = int.Parse(first) + int.Parse(second);
Console.WriteLine(sum);