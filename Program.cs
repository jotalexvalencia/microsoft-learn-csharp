using System.Globalization; 
CultureInfo.CurrentCulture = new CultureInfo("en-US");
string value1 = "5";
string value2 = "7";
int result = Convert.ToInt32(value1) * Convert.ToInt32(value2);
Console.WriteLine(result);