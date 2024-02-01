using Fibonacci.Helpers;
using NUnit.Framework;

namespace FibonacciFuncTests
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
            DatabaseHelper.InitializeDatabase();
        }

        [Test]
        public void CreateUserTest()
        {
            var login = "test";
            var password = "test";
            var created = DatabaseHelper.CreateUser(login, password);
            Assert.AreEqual(true, created);
        }

        [Test]
        public void ValidateUserTest()
        {
            var login = "test";
            var password = "test";
            var exist = DatabaseHelper.ValidateUser(login, password);
            Assert.AreEqual(true, exist);
        }

        [Test]
        public void NotValidatedUserTest()
        {
            var login = "test";
            var password = "testtest";
            var exist = DatabaseHelper.ValidateUser(login, password);
            Assert.AreEqual(false, exist);
        }

        [Test]
        public void PassHashTest()
        {
            var password = "test";
            var passHash = "9f86d081884c7d659a2feaa0c55ad015a3bf4f1b2b0b822cd15d6c15b0f00a08";
            var encrypted = SecurityHelper.EncryptPassword(password);
            Assert.AreEqual(passHash, encrypted);
        }

        [Test]
        public void FibonacciTest()
        {
            var array = new int[10] { 1, 2, 3, 4, 5, 6, 7 ,8, 9, 10};
            var n = 15;
            var k = 5;
            var j = 3;
            var fibArray = new int[25] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 14, 16, 18, 23, 26, 32, 39, 44, 55, 65, 76, 94, 109, 131, 159 };
            var generated = FibonacciHelper.GenerateFibonacciSequence(array, n, j, k);
            Assert.AreEqual(fibArray, generated);
        }
    }
}