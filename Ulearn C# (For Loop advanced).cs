		private static void WriteBoard(int size)
		{
		var i = 0;
		while (true)
            {
				FirstRow(size);
				i+=2;
				if (i >= size && i%2 != 0)
				{
					Console.WriteLine();
					break;
				}
				SecRow(size);
            }
		}
		private static void FirstRow(int size)
		{
			var i = 0;
			var bs = new List<string>() { };
			for (; i < size/2; i++)
			{
				bs.Add("#");
			}
			Console.WriteLine(string.Join(".", bs));
		}
		private static void SecRow(int size)
		{
			var i = 0;
			var ws  = new List<string>() {};
			for (; i < size/2; i++)
			{
				ws.Add(".");
			}
			Console.WriteLine(string.Join("#", ws));
		}