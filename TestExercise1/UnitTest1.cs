using CSharp4_27_02;
namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestJournalAddition()
        {
            Journal journal = new Journal("Test Journal", 5);

            
            journal += 3;

           
            Assert.AreEqual(8, journal.NumberOfEmployees);
        }

        [TestMethod]

        public void TestJournalSubtraction()
        {
            Journal journal = new Journal("Test Journal", 5);

            
            journal -= 3;

            
            Assert.AreEqual(2, journal.NumberOfEmployees);
        }

        [TestMethod]

        public void TestJournalEquality()
        {
            Journal journal1 = new Journal("Test Journal 1", 5);
            Journal journal2 = new Journal("Test Journal 2", 5);

            
            Assert.IsTrue(journal1 == journal2);
        }

        [TestMethod]

        public void TestJournalInequality()
        {
            Journal journal1 = new Journal("Test Journal 1", 5);
            Journal journal2 = new Journal("Test Journal 2", 3);

            
            Assert.IsTrue(journal1 != journal2);
        }

        [TestMethod]

        public void TestJournalComparison()
        {
            Journal journal1 = new Journal("Test Journal 1", 5);
            Journal journal2 = new Journal("Test Journal 2", 3);


            Assert.IsTrue(journal1 > journal2);
    }   }
}