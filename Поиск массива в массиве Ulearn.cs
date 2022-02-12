public static bool ContainsAtIndex(int[] array, int[] subArray, int i)
{
    foreach (int item in subArray)
        if (item != array[i]) return false;
        else i++;
    return true;
}
////
static bool ContainsAtIndex(int[] array, int[] subArray, int i)
{
    for (int j = 0; j < subArray.Length; j++)
    {
        if (array[i + j] != subArray[j]) return false;
    }
    return true;
}