namespace Framework.Console;

using System;


public class ConsoleMethod
{
	static ConsoleMethod()
	{
	}


	public static int InputInt32(string message = default!)
	{
		if (string.IsNullOrWhiteSpace(message) == false)
		{
			Console.Write(message);
		}

		int value = Convert.ToInt32(Console.ReadLine());

		return value;
	}
}