using Wordle.Api.Services;

namespace Wordle.Api.Tests
{
    [TestClass]
    public class WordOfTheDayServiceTests
    {
        [TestMethod]
        public void LoadWordList_SuccessfullyGetsWords()
        {
            CollectionAssert.AllItemsAreNotNull(WordOfTheDayService.LoadWordList(Path.Combine("..", "..", "..", "..", "..", "wordle-web", "scripts", "wordList.ts")));
        }

        [TestMethod]
        public void LoadWordList_ContainsYules()
        {
            List<string> collection = WordOfTheDayService.LoadWordList(Path.Combine("..", "..", "..", "..", "..", "wordle-web", "scripts", "wordList.ts"));
            CollectionAssert.Contains(collection, "yules");
        }
    }
}