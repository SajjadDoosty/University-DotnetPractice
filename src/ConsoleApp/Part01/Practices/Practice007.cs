namespace DotnetPractice.Part01.Practices;

public static class Practice007
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		for (int i = number.ToString().Length - 1; i >= 0; i--)
		{
			Console.Write(number.ToString()[i]);
		}
	}
}