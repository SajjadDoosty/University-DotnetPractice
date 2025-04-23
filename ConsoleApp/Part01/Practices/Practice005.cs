namespace DotnetPractice.Part01.Practices;

public static class Practice005
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		long sum = 1;

		for (int i = 1; i <= number; i++)
		{
			sum *= i;
		}

		Console.WriteLine(sum);
	}
}