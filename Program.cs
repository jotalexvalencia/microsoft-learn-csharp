using System.Globalization; 
CultureInfo.CurrentCulture = new CultureInfo("en-US");
int first = 5;
int second = 7;
string message = first.ToString() + second.ToString();
Console.WriteLine(message);