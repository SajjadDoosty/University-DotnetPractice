namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice003
{
	public static void Run()
	{
		int[] firstArray = [1, 2, 3, 4, 5];

		firstArray.Write("First array value's: ");

		int[] secondArray = new int[firstArray.Length];

		for (int i = 0; i < secondArray.Length; i++)
		{
			secondArray[i] = firstArray[i];
		}

		secondArray.Write("Second array value's: ");

		Console.WriteLine("Copied..!");
	}
}