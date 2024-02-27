using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestAdditionOperator()
        {
            CreditCard card = new CreditCard("1234567890123456", 123, 1000);
            card += 500;
            Assert.AreEqual(1500, card.Balance);
        }

        [TestMethod]

        public void TestSubtractionOperator()
        {
            CreditCard card = new CreditCard("1234567890123456", 123, 1000);
            card -= 500;
            Assert.AreEqual(500, card.Balance);
        }

        [TestMethod]

        public void TestEqualityOperator()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000);
            CreditCard card2 = new CreditCard("6543210987654321", 123, 2000);
            Assert.IsTrue(card1 == card2);
        }

        [TestMethod]

        public void TestInequalityOperator()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000);
            CreditCard card2 = new CreditCard("6543210987654321", 456, 2000);
            Assert.IsTrue(card1 != card2);
        }

        [TestMethod]

        public void TestGreaterThanOperator()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000);
            CreditCard card2 = new CreditCard("6543210987654321", 456, 2000);
            Assert.IsTrue(card2 > card1);
        }

        [TestMethod]

        public void TestLessThanOperator()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000);
            CreditCard card2 = new CreditCard("6543210987654321", 456, 2000);
            Assert.IsTrue(card1 < card2);
        }

        [TestMethod]

        public void TestEqualsMethod()
        {
            CreditCard card1 = new CreditCard("1234567890123456", 123, 1000);
            CreditCard card2 = new CreditCard("1234567890123456", 123, 1000);
            Assert.IsTrue(card1.Equals(card2));
        }

    }
}