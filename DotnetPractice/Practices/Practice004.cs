namespace DotnetPractice.Practices;

public static class Practice004
{
	public static void Run()
	{
		Console.Write("Enter count of number's: ");

		var count = Convert.ToInt32(Console.ReadLine());

		for (int i = 0; i < count; i++)
		{
			var number = Convert.ToInt32(Console.ReadLine());

			if (number % 5 == 0)
			{
				Console.WriteLine("YES!");
			}
			else
			{
				Console.WriteLine("NO!");
			}
		}
	}
}