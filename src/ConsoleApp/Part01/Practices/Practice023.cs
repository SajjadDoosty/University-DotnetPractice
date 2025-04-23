namespace DotnetPractice.Part01.Practices;

public static class Practice023
{
	public static void Run()
	{
		Console.Write("Enter first number number: ");
		var firstNumber = Convert.ToInt32(Console.ReadLine());

		Console.Write("Enter second number number: ");
		var secondNumber = Convert.ToInt32(Console.ReadLine());

		int sum = 0;

		for (int i = 0; i < secondNumber; i++)
		{
			sum += firstNumber;
		}

		Console.WriteLine($"{firstNumber} * {secondNumber} = {sum}");
	}
}