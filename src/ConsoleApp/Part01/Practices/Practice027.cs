namespace DotnetPractice.Part01.Practices;

public static class Practice027
{
	public static void Run()
	{
		Console.Write("Enter a text to reverse: ");
		var text = Console.ReadLine()!;

		for (int i = text.Length - 1; i >= 0; i--)
		{
			Console.Write(text[i]);
		}
	}
}