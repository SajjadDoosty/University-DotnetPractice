namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice008
{
	public static void Run()
	{
		int[] firstArray = [1, 2, 3, 4, 5];
		int[] secondArray = [5, 4, 3, 2, 1];

		firstArray.Write("First array value's: ");
		secondArray.Write("Second array value's: ");

		// Extention Method [IsEquals]
		var isEqual = 
			firstArray.IsEquals(secondArray);

		if (isEqual == true)
		{
			Console.WriteLine("Array's is equal!");
		}
		else
		{
			Console.WriteLine("Array's not equal!");
		}

		Console.WriteLine("-----------------------");

		firstArray = [1, 2, 3, 4, 5];
		secondArray = [5, 4, 3, 2, 0];

		firstArray.Write("First array value's: ");
		secondArray.Write("Second array value's: ");

		isEqual =
			firstArray.IsEquals(secondArray);

		if (isEqual == true)
		{
			Console.WriteLine("Array's is equal!");
		}
		else
		{
			Console.WriteLine("Array's not equal!");
		}
	}
}