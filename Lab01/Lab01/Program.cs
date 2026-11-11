// ============================================================
// ФАЙЛ 3: TempConverter/Program.cs (без изменений — данных студента нет)
// ============================================================

double celsius = 23.5;

const double FahrenheitMultiplier = 9.0 / 5.0;
const double FahrenheitOffset = 32.0;
const double KelvinOffset = 273.15;

double fahrenheit = celsius * FahrenheitMultiplier + FahrenheitOffset;
double kelvin = celsius + KelvinOffset;

Console.WriteLine($"{celsius:F1}°C = {fahrenheit:F1}°F = {kelvin:F2}K");