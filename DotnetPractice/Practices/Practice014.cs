namespace DotnetPractice.Practices;

public static class Practice014
{
	public static void Run()
	{
		Console.Write("Enter month number [1, 12]: ");
		var monthNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter day number [1, 30]: ");
		var dayNumber = Convert.ToInt32(Console.ReadLine());

		if (monthNumber > 12 || monthNumber < 1 || dayNumber > 30 || dayNumber < 1)
		{
			Console.WriteLine("Out of range!");
		}
		else
		{
			int dayOfYear = ((monthNumber - 1) * 30) + dayNumber;

			Console.WriteLine($"Day {dayOfYear} of the year.");
		}
	}
}