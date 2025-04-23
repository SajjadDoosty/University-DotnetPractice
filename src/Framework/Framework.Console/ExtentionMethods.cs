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
			if (i == array.GetLength(0) - 1)
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

			if (i == array.GetLength(0) - 1)
			{
				Console.WriteLine($"{array[i]}");
			}
			else
			{
				Console.Write($"{array[i]}, ");
			}
		}
	}
}