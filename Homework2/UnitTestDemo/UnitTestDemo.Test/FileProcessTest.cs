namespace UnitTestDemo.Test
{
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using System;

    [TestClass]
    public class FileProcessTest
    {
        [TestMethod]
        public void FileNameDoesExist()
        {
            // Arrange
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            // Act
            fromCall = fileProcess.FileExists(@"C:\Windows\regedit.exe");

            // Assert
            Assert.IsTrue(fromCall);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException))]
        public void FileNameDoesNotExist()
        {
            // Arrange
            FileProcess fileProcess = new FileProcess();
            bool fromCall;

            // Act
            fromCall = fileProcess.FileExists(@"");

            // Assert
            Assert.IsFalse(fromCall);
        }
    }
}
