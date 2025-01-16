using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string value = "abc123";
char[] valueArray = value.ToCharArray();
Array.Reverse(valueArray);
string result = new string(valueArray);
Console.WriteLine(result);