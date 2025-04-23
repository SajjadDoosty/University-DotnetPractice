namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice001
{
	public static void Run()
	{
		int[] array = [1, 2, 3, 4, 5];

		array.Write("Array value's: ");

		int searchValue =
			ConsoleMethod.InputInt32("Enter value to search: ");

		var founded = false;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == searchValue)
			{
				founded = true;

				Console.WriteLine($"Value found in index {i}!");
			}
		}

		if (founded == false)
		{
			Console.WriteLine("Value not found!");
		}
	}
}