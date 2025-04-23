namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice006
{
	public static void Run()
	{
		int[] firstArray = [1, 2, 3, 4, 5];
		int[] secondArray = [1, 2, 4];

		firstArray.Write("First array value's: ");
		secondArray.Write("Second array value's: ");

		Console.WriteLine("Duplicated value's: ");

		for (int i = 0; i < firstArray.Length; i++)
		{
			for (int j = 0; j < secondArray.Length; j++)
			{
				if (firstArray[i] == secondArray[j])
				{
					Console.WriteLine(secondArray[j]);
				}
			}
		}
	}
}