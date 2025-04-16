namespace DotnetPractice.Practices;

public static class Practice015
{
	public static void Run()
	{
		Console.Write("Enter first number: ");
		var firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number: ");
		var secondNumber = Convert.ToInt32(Console.ReadLine());

		while (secondNumber != 0)
		{
			int temp = secondNumber;
			secondNumber = firstNumber % secondNumber;
			firstNumber = temp;
		}

		Console.WriteLine(firstNumber);
	}
}