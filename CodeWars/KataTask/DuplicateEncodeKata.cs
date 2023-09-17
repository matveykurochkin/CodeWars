using System.Text;

namespace CodeWars.KataTask;

public class DuplicateEncodeKata
{
    /// <summary>
    /// Задача - преобразовать строку в новую строку, где каждый символ в новой строке является,
    /// "(" если этот символ появляется только один раз в исходной строке,
    /// или ")" если этот символ появляется в исходной строке более одного раза.
    /// Ссылка на задание: https://www.codewars.com/kata/54b42f9314d9229fd6000d9c
    /// </summary>
    /// <param name="word">Исходная строка</param>
    /// <returns>Закодированная строка</returns>
    public static string DuplicateEncode(string word)
    {
        var codeWord = new StringBuilder();

        var result = word.ToLower().Select(letter => letter.ToString()).ToArray();

        foreach (var letter in result)
        {
            var letterIsRepeat = result.Count(c => c == letter) > 1;

            codeWord.Append(letterIsRepeat ? ")" : "(");
        }

        return codeWord.ToString();
    }
}