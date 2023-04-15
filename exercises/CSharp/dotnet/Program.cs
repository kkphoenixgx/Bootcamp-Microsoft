// block

string reservedDays = "3";

int defaultValue = 0;
var convertedReservedDays = int.TryParse(reservedDays, out defaultValue);

Console.WriteLine(defaultValue);