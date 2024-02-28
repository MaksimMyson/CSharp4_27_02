using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AddBook_AddsBookToList()
        {
            var readingList = new ReadingList();

            readingList.AddBook("Book 1");

            Assert.IsTrue(readingList.ContainsBook("Book 1"));

        }

        [TestMethod]

        public void RemoveBook_RemovesBookFromList()
        {
            var readingList = new ReadingList();

            readingList.AddBook("Book 1");

            readingList.RemoveBook("Book 1");

            Assert.IsFalse(readingList.ContainsBook("Book 1"));
        }

        [TestMethod]

        public void ContainsBook_ReturnsTrueIfBookExists()
        {
            var readingList = new ReadingList();

            readingList.AddBook("Book 1");

            Assert.IsTrue(readingList.ContainsBook("Book 1"));
        }

        [TestMethod]

        public void ContainsBook_ReturnsFalseIfBookDoesNotExist()
        {
            var readingList = new ReadingList();

            readingList.AddBook("Book 1");

            Assert.IsFalse(readingList.ContainsBook("Book 2"));
        }

        [TestMethod]

        public void Indexer_CanAccessBookByIndex()
        {
            var readingList = new ReadingList();

            readingList.AddBook("Book 1");

            Assert.AreEqual("Book 1", readingList[0]);
        }
    }
}