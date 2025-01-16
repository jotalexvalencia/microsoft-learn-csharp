using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");
string[] values = { "12.3", "45", "ABC", "11", "DEF" };
float result = default(float);
string Message = "";
foreach (string value in values)
{
   if (float.TryParse(value, out float number))
   {
      result += number;
   }
   else
   {
      Message += value;
   }
}
Console.WriteLine($"Message: {Message.Trim()}");
Console.WriteLine($"Total: {result}");