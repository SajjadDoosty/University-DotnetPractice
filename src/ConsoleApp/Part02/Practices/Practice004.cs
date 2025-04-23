namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice004
{
	public static void Run()
	{
		int[] array = [1, 2, 3, 4, 5];

		array.Write("Array value's: ");

		int insertIndex =
			ConsoleMethod.InputInt32($"Enter index between {1} and {array.Length} to insert: ") - 1;

		int insertValue =
			ConsoleMethod.InputInt32($"Enter number to insert: ");

		if (insertIndex > array.Length - 1 || insertIndex < 0)
		{
			Console.WriteLine("Index Error!");
		}
		else
		{
			array[insertIndex] = insertValue;
			array.Write("Array new value's: ");
		}
	}
}