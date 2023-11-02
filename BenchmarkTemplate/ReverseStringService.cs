using System.Text;

namespace BenchmarkTemplate;

/// <summary>
/// Class ReverseStringService.
/// </summary>
public class ReverseStringService
{
    public string ReverseString1(string text)
    {
        return new string(text.Reverse().ToArray());
    }

    public string ReverseString2(string text)
    {
        return new string(text.ToCharArray().Reverse().ToArray());
    }

    public string ReverseString3(string text)
    {
        char[] charArray = text.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }

    public string ReverseString4(string text)
    {
        var reverse = new StringBuilder(text.Length);
        for (int i = text.Length - 1; i >= 0; i--)
        {
            reverse.Append(text[i]);
        }

        return reverse.ToString();
    }
}
