﻿string[,] corporate =
{
    {"Robert", "Bavin"}, {"Simon", "Bright"},
    {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
    {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
};

string[,] external =
{
    {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
    {"Shay", "Lawrence"}, {"Daren", "Valdes"}
};

string externalDomain = "hayworth.com";

for (int i = 0; i < corporate.GetLength(0); i++)
{
  // display internal email addresses
  Console.WriteLine(GenerateEmail(corporate[i, 0], corporate[i, 1]));

}

for (int i = 0; i < external.GetLength(0); i++)
{
  // display external email addresses
  Console.WriteLine(GenerateEmail(external[i, 0], external[i, 1], externalDomain));
}

// Función para generar correos electrónicos
string GenerateEmail(string firstName, string lastName, string domain = "contoso.com")
{
  // Tomar las dos primeras letras del nombre y el apellido completo
  string emailPrefix = $"{firstName.ToLower().Substring(0, 2)}{lastName.ToLower()}";
  return $"{emailPrefix}@{domain}";
}