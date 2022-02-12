        private static string DecodeMessage(string[] lines)
        {
            var sentence = new List<string>();
            foreach (var line in lines)
            {
                if (line.Length > 0)
                {
                    foreach (var word in line.Split(' '))
                    {
                        if (Char.IsUpper(word[0]) && word.Length > 0)
                            sentence.Add(word);
                    }
                }
            }
            sentence.Reverse();
            return string.Join(" ", sentence);
        }