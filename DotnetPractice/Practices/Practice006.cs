namespace DotnetPractice.Practices;

public static class Practice006
{
	public static void Run()
	{
		Console.Write("Enter number: ");

		var number = Convert.ToInt32(Console.ReadLine());

		Console.WriteLine(number.ToString().Length);
	}
}