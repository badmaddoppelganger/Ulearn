private static void WriteBoard(int size)
	{
        for (int i = 1; i < size+1; i++)
			{
				if (i % 2 != 0)
					Console.WriteLine(string.Join(".", Enumerable.Repeat("#", (size/2)+1)).Substring(0, size));
				else
					Console.WriteLine(string.Join("#", Enumerable.Repeat(".", (size / 2) + 1)).Substring(0, size));
			}
		Console.WriteLine();
    }