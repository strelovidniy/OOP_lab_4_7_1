using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Test
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            OOP_lab_4_7_1.Program.Roman.Rating = 95;

            Assert.AreEqual(OOP_lab_4_7_1.Program.Roman.StudentRating(), "\nВiтаємо вiдмiнника!");
        }

        [TestMethod]
        public void TestMethod2()
        {
            OOP_lab_4_7_1.Program.Roman.Rating = 80;

            Assert.AreEqual(OOP_lab_4_7_1.Program.Roman.StudentRating(), "\nМожна вчитися краще!");
        }

        [TestMethod]
        public void TestMethod3()
        {
            OOP_lab_4_7_1.Program.Roman.Rating = 60;

            Assert.AreEqual(OOP_lab_4_7_1.Program.Roman.StudentRating(), "\nВарто бiльше уваги придiляти навчанню!");
        }
    }
}
