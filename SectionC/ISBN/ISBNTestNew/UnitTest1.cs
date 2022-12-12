using Microsoft.VisualStudio.TestTools.UnitTesting;
using Isbnmain;
namespace ISBNTestNew
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            ISBNClass mIsbn= new ISBNClass();
            string isbnthi = mIsbn.ISBNCheck("9780316066525");
            Assert.AreEqual("VALID", isbnthi);

        }
        [TestMethod]
        public void TestMethod2()
        {
            ISBNClass mIsbn = new ISBNClass();
            string isbnthi = mIsbn.ISBNCheck("0316066524");
            Assert.AreEqual("9780316066525", isbnthi);

        }
        [TestMethod]
        public void TestMethod3()
        {
            ISBNClass mIsbn = new ISBNClass();
            string isbnthi = mIsbn.ISBNCheck("9780316066525");
            Assert.AreNotEqual("0330301824", isbnthi);

        }
    }
}
