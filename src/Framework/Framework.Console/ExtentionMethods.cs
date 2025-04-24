namespace Framework.Console;

using System;


public static class ExtentionMethods
{
	static ExtentionMethods()
	{
	}


	public static void Write(this int[] array, string message = default!)
	{
		if (string.IsNullOrEmpty(message) == false)
		{
			Console.WriteLine(message);
		}

		for (int i = 0; i < array.Length; i++)
		{
			if (i == array.Length - 1)
			{
				Console.WriteLine($"{array[i]}");
			}
			else
			{
				Console.Write($"{array[i]}, ");
			}
		}
	}

	public static void WriteFilterNegatives(this int[] array, string message = default!)
	{
		if (string.IsNullOrEmpty(message) == false)
		{
			Console.WriteLine(message);
		}

		for (int i = 0; i < array.Length; i++)
		{
			if (array[i] < 0)
			{
				continue;
			}

			if (i == array.Length - 1)
			{
				Console.WriteLine($"{array[i]}");
			}
			else
			{
				Console.Write($"{array[i]}, ");
			}
		}
	}

	public static bool IsEquals(this int[] firstArray, int[] secondArray)
	{
		if (firstArray.Length != secondArray.Length)
		{
			return false;
		}

		bool isEquals = true;

		for (int i = 0; i < firstArray.Length; i++)
		{
			bool isIndexEquals = false;

			for (int j = 0; j < secondArray.Length; j++)
			{
				if (firstArray[i] == secondArray[j])
				{
					isIndexEquals = true;
				}
			}

			if (isIndexEquals == false)
			{
				isEquals = false;
				break;
			}
		}

		return isEquals;
	}
}