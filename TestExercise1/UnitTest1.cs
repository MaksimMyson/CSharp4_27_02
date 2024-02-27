using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestEmploee()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
        }

        [TestMethod]
        public void TestIncreaseSalary()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            employee1.IncreaseSalary(1000);
            Assert.AreEqual(2000, employee1.Salary);
        }

        [TestMethod]
        public void TestEquals()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
            Assert.IsTrue(employee1.Equals(employee3));
            Assert.IsFalse(employee1.Equals(employee2));
        }

        [TestMethod]
        public void TestNotEquals()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
            Assert.IsFalse(employee1.NotEquals(employee3));
            Assert.IsTrue(employee1.NotEquals(employee2));
        }

        [TestMethod]
        public void TestIsGreaterThan()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
            Assert.IsFalse(employee1.IsGreaterThan(employee3));
            Assert.IsTrue(employee2.IsGreaterThan(employee1));
        }

        [TestMethod]
        public void TestIsLessThan()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
            Assert.IsFalse(employee2.IsLessThan(employee1));
            Assert.IsTrue(employee1.IsLessThan(employee2));
        }

        [TestMethod]
        public void TestToString()
        {
            Employee employee1 = new Employee("Ivan", 1000);
            Employee employee2 = new Employee("Petro", 2000);
            Employee employee3 = new Employee("Ivan", 1000);
            Assert.AreEqual("Співробітник: Ivan, Зарплата: 1000", employee1.ToString());
            Assert.AreEqual("Співробітник: Petro, Зарплата: 2000", employee2.ToString());
            Assert.AreEqual("Співробітник: Ivan, Зарплата: 1000", employee3.ToString());
        }
    }
}