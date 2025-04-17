namespace DotnetPractice.Practices;

public static class Practice024
{
	public static void Run()
	{
		Console.Write("Enter number of row's: ");
		var rows = Convert.ToInt32(Console.ReadLine());

		var recentRow = new List<int>() { 1 };

		foreach (var number in recentRow)
		{
			Console.WriteLine(number);
		}

		for (int i = 0; i < rows - 1; i++)
		{
			var nowRow = new List<int>();

			for (int j = 0; j < recentRow.Count + 1; j++)
			{
				if (j == 0 || j == recentRow.Count)
				{
					nowRow.Add(1);
					continue;
				}

				int number = recentRow[j] + recentRow[j - 1];

				nowRow.Add(number);
			}

			recentRow = nowRow;

			foreach (var number in nowRow)
			{
				Console.Write($"{number} ");
			}

			Console.WriteLine();
		}
	}
}