using System;

class Program
{
	static void Main()
	{
	   Console.Write("How many Entries would you like to type?: ");
	   int entries = Convert.ToInt32(Console.ReadLine());
		int[,] matrix = new int[entries, entries];

		for (int i = 0; i < entries; i++)
		{
			for (int a = 0; a < entries; a++)
			{
				matrix[i, a] = (i + 1) * (a + 1);
			}
		}

		Console.WriteLine("The matrix is:");
		for (int i = 0; i < entries; i++)
		{
			for (int a = 0; a < entries; a++)
			{
				Console.Write(matrix[i, a] + " ");
			}
			Console.WriteLine();
		}
	}
}
