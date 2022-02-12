        public static int MaxIndex(double[] array)
        {
            if (array.Length < 1) return -1;
            var i = 0;
            double maxVal = 0;
            for (; i < array.Length; i++)
            {
                if (array[i] > maxVal)
                    maxVal = array[i];
            }
            return Array.IndexOf(array, maxVal);
        }