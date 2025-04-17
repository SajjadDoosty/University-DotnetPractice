namespace DotnetPractice.Practices;

public static class Practice020
{
	public static void Run()
	{
		Console.Write("Enter first number number: ");
		var firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number number: ");
		var secondNumber = Convert.ToInt32(Console.ReadLine());

		if (firstNumber > secondNumber)
		{
			int temp = firstNumber;
			firstNumber = secondNumber;
			secondNumber = temp;
		}

		for (int i = firstNumber; i <= secondNumber; i++)
		{
			if (i % 3 == 0)
			{
				Console.WriteLine(i);
			}
		}
	}
}