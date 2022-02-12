        public static int GetElementCount(int[] items, int itemToCount)
        {
            var count = 0;
            foreach(var item in items)
            {
                if (item == itemToCount)
                    count++;
            }
            return count;
        }
        ////////// 2nd solution
                public static int GetElementCount(int[] items, int itemToCount)
        {
            var count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == itemToCount)
                    count++;
            }
            return count;
        }