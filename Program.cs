using System.Globalization;
CultureInfo.CurrentCulture = new CultureInfo("en-US");

string orderStream = "B123,C234,A345,C15,B177,G3003,C235,B179";

// Split the order stream into individual orders
string[] orders = orderStream.Split(',');

// sort the orders  by order number
Array.Sort(orders);

// Print the sorted order stream
foreach (string order in orders)
{
  if (order.Length != 4)
  {
    Console.WriteLine($"{order}\t -Error");
  }
  else
  {
    Console.WriteLine(order);
  }
}


