using Wordle.Api.Services;

namespace Wordle.Api.Tests
{
    [TestClass]
    public class WordOfTheDayServiceTests
    {
        [TestMethod]
        public void LoadWordList_SuccessfullyGetsWords()
        {
            CollectionAssert.AllItemsAreNotNull(WordOfTheDayService.LoadWordList(WordOfTheDayService.filePath));
        }

        [TestMethod]
        public void LoadWordList_ContainsYules()
        {
            List<string> collection = WordOfTheDayService.LoadWordList(WordOfTheDayService.filePath);
            CollectionAssert.Contains(collection, "yules");
        }
    }
}