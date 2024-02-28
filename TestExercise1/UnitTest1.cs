using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestStoreAddition()
        {
            
            Store store = new Store("Test Store", 100.0);

            
            store += 50.0;

            
            Assert.AreEqual(150.0, store.Area);
        }

        [TestMethod]

        public void TestStoreSubtraction()
        {
            
            Store store = new Store("Test Store", 100.0);

            
            store -= 50.0;

            
            Assert.AreEqual(50.0, store.Area);
        }

        [TestMethod]

        public void TestStoreEquality()
        {
            
            Store store1 = new Store("Test Store 1", 100.0);
            Store store2 = new Store("Test Store 2", 100.0);

            
            Assert.IsTrue(store1 == store2);
        }

        [TestMethod]

        public void TestStoreComparison()
        {
            
            Store store1 = new Store("Test Store 1", 100.0);
            Store store2 = new Store("Test Store 2", 50.0);

            
            Assert.IsTrue(store1 > store2);
        }
    }
}