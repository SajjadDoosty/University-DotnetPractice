namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice002
{
	public static void Run()
	{
		int[] array = [1, 2, 3, 4, 5];

		array.Write("Array value's: ");

		int valueForRemove =
			ConsoleMethod.InputInt32("Enter Index + 1 to remove: ");

		var founded = false;

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] == valueForRemove)
			{
				founded = true;

				array[i] = -1;

				Console.WriteLine($"Value removed in index {i}!");
			}
		}

		if (founded == false)
		{
			Console.WriteLine("Value not found!");
		}
		else
		{
			array.WriteFilterNegatives("Array value's: ");
		}
	}
}