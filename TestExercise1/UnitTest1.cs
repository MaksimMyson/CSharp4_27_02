using CSharp4_27_02;

namespace TestExercise1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TesMatrix()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 5;
            m2[0, 1] = 6;
            m2[1, 0] = 7;
            m2[1, 1] = 8;

            Matrix m3 = m1 + m2;
            Assert.AreEqual(6, m3[0, 0]);
            Assert.AreEqual(8, m3[0, 1]);
            Assert.AreEqual(10, m3[1, 0]);
            Assert.AreEqual(12, m3[1, 1]);

            m3 = m1 - m2;
            Assert.AreEqual(-4, m3[0, 0]);
            Assert.AreEqual(-4, m3[0, 1]);
            Assert.AreEqual(-4, m3[1, 0]);
            Assert.AreEqual(-4, m3[1, 1]);

            m3 = m1 * m2;
            Assert.AreEqual(19, m3[0, 0]);
            Assert.AreEqual(22, m3[0, 1]);
            Assert.AreEqual(43, m3[1, 0]);
            Assert.AreEqual(50, m3[1, 1]);
        }

        [TestMethod]

        public void TestMatrixException()
        {
            Matrix m1 = new Matrix(2, 2);
            Matrix m2 = new Matrix(3, 3);
            Assert.ThrowsException<InvalidOperationException>(() => m1 + m2);
            Assert.ThrowsException<InvalidOperationException>(() => m1 - m2);
        }

        [TestMethod]

        public void Tesbooloperator()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 1;
            m2[0, 1] = 2;
            m2[1, 0] = 3;
            m2[1, 1] = 4;

            Assert.IsTrue(m1 == m2);
            Assert.IsFalse(m1 != m2);
        }

        [TestMethod]

        public void TestMatrixIndexer()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Assert.AreEqual(1, m1[0, 0]);
            Assert.AreEqual(2, m1[0, 1]);
            Assert.AreEqual(3, m1[1, 0]);
            Assert.AreEqual(4, m1[1, 1]);
        }

        [TestMethod]

        public void TestMatrixConstructor()
        {
            Matrix m1 = new Matrix(2, 2);
            Assert.AreEqual(2, m1.Rows);
            Assert.AreEqual(2, m1.Columns);
        }

        [TestMethod]

        public void TestMatrixEquals()
        {
            Matrix m1 = new Matrix(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            Matrix m2 = new Matrix(2, 2);
            m2[0, 0] = 1;
            m2[0, 1] = 2;
            m2[1, 0] = 3;
            m2[1, 1] = 4;

            Assert.IsTrue(m1.Equals(m2));
        }
    }
}