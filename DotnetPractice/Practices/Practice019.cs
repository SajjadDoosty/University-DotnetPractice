namespace DotnetPractice.Practices;

public static class Practice019
{
	public static void Run()
	{
		Console.Write("Enter number: ");
		var number = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for (int i = 0; i < number.ToString().Length; i++)
		{
			sum += Convert.ToInt32((number.ToString()[i]).ToString());
		}

		if (number % sum == 0)
		{
			Console.WriteLine("Yes!");
		}
		else
		{
			Console.WriteLine("No!");
		}
	}
}