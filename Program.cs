double usd = 23.73;
int vnd = UsdToVnd(usd);

Console.WriteLine($"${usd} USD = ${vnd} VND");

int UsdToVnd(double usd)
{
  int rate = 23500;
  return (int)(rate * usd);
}