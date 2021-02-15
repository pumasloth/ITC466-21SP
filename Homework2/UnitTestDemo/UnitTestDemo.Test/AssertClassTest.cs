namespace UnitTestDemo.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using PersonClasses;

    [TestClass]
    public class AssertClassTest
    {
        #region AreEqual/AreNotEqual Tests

        [TestMethod]
        public void AreEqualTest()
        {
            string str1 = "GoBears";
            string str2 = "GoBears";

            Assert.AreEqual(str1, str2);
        }

        [TestMethod]
        [ExpectedException(typeof(AssertFailedException))]
        public void AreEqualCaseSensitiveTest()
        {
            string str1 = "GoBears";
            string str2 = "goBears";

            Assert.AreEqual(str1, str2, false);
        }

        [TestMethod]
        public void AreNotEqualTest()
        {
            string str1 = "MissouriState";
            string str2 = "MSU";

            Assert.AreNotEqual(str1, str2);
        }

        #endregion

        #region AreSame/AreNotSame Tests

        [TestMethod]
        public void AreSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = x;

            Assert.AreSame(x, y);
        }

        [TestMethod]
        public void AreNotSameTest()
        {
            FileProcess x = new FileProcess();
            FileProcess y = new FileProcess();

            Assert.AreNotSame(x, y);
        }

        #endregion

        #region IsInstanceOfType Test

        [TestMethod]
        public void IsInstanceOfTypeTest()
        {
            // Arrange
            PersonManager manager = new PersonManager();
            Person person;

            // Act
            person = manager.CreatePerson("Ethan", "Penrose", true);

            // Assert
            Assert.IsInstanceOfType(person, typeof(Supervisor));
        }

        #endregion

        #region IsNull Test

        [TestMethod]
        public void IsNullTest()
        {
            // Arrange
            PersonManager manager = new PersonManager();
            Person person;

            // Act
            person = manager.CreatePerson("", "Penrose", true);

            // Assert
            Assert.IsNull(person);
        }

        #endregion
    }
}
