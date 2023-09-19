using System.Text;

namespace CodeWars.KataTask;

public class ReplaceWithAlphabetPositionKata
{
    /// <summary>
    /// В этом ката от вас требуется, получив строку, заменить каждую букву на ее позицию в алфавите.
    /// Если что-то в тексте не является буквой, проигнорируйте это и не возвращайте.
    /// </summary>
    /// <param name="text">Исходный текст</param>
    /// <returns></returns>
    public static string AlphabetPosition(string text)
    {
        var resultText = new StringBuilder();

        foreach (var letter in text.Where(char.IsLetter))
        {
            resultText.Append($"{char.ToUpper(letter) - 64} ");
        }

        if (!string.IsNullOrEmpty(resultText.ToString()))
            resultText.Remove(resultText.Length - 1, 1);

        return resultText.ToString();
    }
}