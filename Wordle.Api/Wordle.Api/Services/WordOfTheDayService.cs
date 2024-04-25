namespace Wordle.Api.Services;

public class WordOfTheDayService
{

    private static readonly string filePath = Path.Combine("..", "..", "wordle-web", "scripts", "wordList.ts");
    private List<string> wordList = LoadWordList(filePath);

    public static List<string> LoadWordList(string filePath)
    {
        List<string> words = [];

        using (StreamReader reader = new(filePath))
        {
            _ = reader.ReadLine();
            string? line;
            while ((line = reader.ReadLine()) != null)
            {
                // Ignore comment lines and empty lines
                if (!string.IsNullOrWhiteSpace(line) && !line.StartsWith("//"))
                {
                    string word = string.Concat(line.Where(char.IsLetter)).Trim();
                    words.Add(word);
                }
            }
        }

        return words;
    }

    public string GetRandomWord()
    {
        Random random = new();
        return wordList[random.Next(wordList.Count)];
    }

    public string GetWordOfTheDay()
    {
        DateTime now = DateTime.Now;
        int dayOfYear = now.DayOfYear;
        Random random = new(dayOfYear);
        return wordList[random.Next(wordList.Count)];
    }

}
