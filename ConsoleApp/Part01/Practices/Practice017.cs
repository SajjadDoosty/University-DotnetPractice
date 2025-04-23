namespace DotnetPractice.Part01.Practices;

public static class Practice017
{
	public static void Run()
	{
		Console.Write("Enter worked hour's of employee: ");
		var workedHours = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter wage per hour's of employee: ");
		var wagePerHours = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine($"Payed wage: {workedHours * wagePerHours}");
	}
}