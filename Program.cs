using System.Globalization; 
CultureInfo.CurrentCulture = new CultureInfo("en-US");
int value = (int)1.5m; // casting truncates
Console.WriteLine(value);

int value2 = Convert.ToInt32(1.5m); // converting rounds up
Console.WriteLine(value2);