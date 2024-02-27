using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class CityTests
    {
        [TestMethod]
        public void TestCityPopulationIncrease()
        {
            
            City city = new City("TestCity", 1000);

            
            city += 500;

            
            Assert.AreEqual(1500, city.Population);
        }

        [TestMethod]
        public void TestCityPopulationDecrease()
        {
            
            City city = new City("TestCity", 1000);

            
            city -= 300;

            
            Assert.AreEqual(700, city.Population);
        }

        [TestMethod]
        public void TestCityPopulationDecreaseWithInvalidOperation()
        {
            
            City city = new City("TestCity", 1000);

            
            Assert.ThrowsException<InvalidOperationException>(() => city -= 1500);
        }

        [TestMethod]
        public void TestCityEquality()
        {
            
            City city1 = new City("City1", 1000);
            City city2 = new City("City2", 1000);
            City city3 = new City("City3", 2000);

            
            Assert.IsTrue(city1 == city2);
            Assert.IsFalse(city1 == city3);
        }

        [TestMethod]
        public void TestCityInequality()
        {
            
            City city1 = new City("City1", 1000);
            City city2 = new City("City2", 1000);
            City city3 = new City("City3", 2000);

            
            Assert.IsFalse(city1 != city2);
            Assert.IsTrue(city1 != city3);
        }

        [TestMethod]
        public void TestCityGreaterThan()
        {
            
            City city1 = new City("City1", 1000);
            City city2 = new City("City2", 2000);

            
            Assert.IsFalse(city1 > city2);
            Assert.IsTrue(city2 > city1);
        }

        [TestMethod]
        public void TestCityLessThan()
        {
            
            City city1 = new City("City1", 1000);
            City city2 = new City("City2", 2000);

            
            Assert.IsTrue(city1 < city2);
            Assert.IsFalse(city2 < city1);
        }

        [TestMethod]
        public void TestCityEqualsMethod()
        {
            
            City city1 = new City("City1", 1000);
            City city2 = new City("City2", 1000);
            City city3 = new City("City3", 2000);

            
            Assert.IsTrue(city1.Equals(city2));
            Assert.IsFalse(city1.Equals(city3));
        }
    }
}