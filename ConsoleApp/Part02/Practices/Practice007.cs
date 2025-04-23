namespace DotnetPractice.Part02.Practices;

using Framework.Console;

public static class Practice007
{
	public static void Run()
	{
		int[] array = [1, 2, 3, 4, 5, 2, 4];

		array.Write("Array value's: ");

		for (int i = 0; i < array.Length; i++)
		{
			int curentIndex = array[i];

			for (int j = 0; j < array.Length; j++)
			{
				if (curentIndex == array[j] && i != j)
				{
					array[i] = -1;
				}
			}
		}

		array.WriteFilterNegatives("Array new value's: ");
	}
}