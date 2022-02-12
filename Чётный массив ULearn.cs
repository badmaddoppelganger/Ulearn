public static int[] GetFirstEvenNumbers(int count)
{
	var array = new int[count];
	var array2 = new List<int>();
	var x = 1;
	foreach (var i in array)
	{
		array2.Add(x*2);
		x++;
	}
	return array2.ToArray();
}
/// 2nd path (more simple but foreach excl)
public static int[] GetFirstEvenNumbers(int count)
{
	var array = new int[count];
	var i= 0;
	for (; i < count; i++)
		array[i] = 2*(i+1);
	return array;
}