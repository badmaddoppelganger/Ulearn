		public static void WriteLineBorder(int line)
        {
			Console.Write("+");
			int i = 0;
			for (; i < line; i++)
			{
				Console.Write("-");
			}
			Console.Write("+\n");
		}
		private static void WriteTextWithBorder(string text)
		{
			var len = text.Length + 2;
			WriteLineBorder(len);
			Console.WriteLine("| " + text + " |");
			WriteLineBorder(len);
		}