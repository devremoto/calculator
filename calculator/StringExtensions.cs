static class StringExtensions
{
    public static string ReplaceAt(this string str, int index, char newChar)
    {
        return str.Remove(index, 1).Insert(index,newChar.ToString()); 
    }
}