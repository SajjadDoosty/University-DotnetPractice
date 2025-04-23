namespace DotnetPractice.Part01.Practices;

public static class Practice016
{
	public static void Run()
	{
		Console.Write("Enter number: ");
		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for (int i = 0; i < number.ToString().Length; i++)
		{
			sum += Convert.ToInt32(number.ToString()[i].ToString());
		}

		Console.WriteLine($"Sum of digit's: {sum}");
	}
}