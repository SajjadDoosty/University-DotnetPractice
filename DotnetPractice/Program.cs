#region Min Number

Console.Write("Enter count of number's: ");

var count = Convert.ToInt32(Console.ReadLine());

int minNumber = 0;

for (int i = 0; i < count; i++)
{
	var number = Convert.ToInt32(Console.ReadLine());

	if (i == 0)
	{
		minNumber = number;
		continue;
	}

	if (number < minNumber)
	{
		minNumber = number;
	}
}

Console.WriteLine(minNumber);

#endregion