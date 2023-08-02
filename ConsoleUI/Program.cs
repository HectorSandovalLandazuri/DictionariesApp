// See https://aka.ms/new-console-template for more information
Dictionary<int,string> importantYears = new Dictionary<int,string>();

importantYears[1492] = "Columbus discover the new world.";
importantYears[1969] = "Man walks the moon.";
importantYears[1975] = "Héctor Sandoval is born.";
Console.WriteLine($"In the year 1975, this happened: {importantYears[1975]}");

Dictionary<int, string> employees = new Dictionary<int, string>();
employees[449] = "Héctor.";
employees[1492] = "Claudia.";
employees[1969] = "Juan.";
employees[1975] = "Pedro.";
Console.Write("What is your ID? ");
string iD = Console.ReadLine();
bool iDValido = int.TryParse(iD, out int intId);
if (iDValido)
{
    Console.WriteLine($"El nombre del empleado {intId}: {employees[intId]}");
}






