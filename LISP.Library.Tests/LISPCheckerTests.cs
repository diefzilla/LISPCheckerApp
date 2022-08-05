using NUnit.Framework;

namespace LISP.Library.Tests
{
    [TestFixture]
    public class LISPCheckerTests
    {
   
        [Test]
        public void Same_Amount_Open_And_Closed()
        {
            string input = "()";

            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(true,output);
        }

        [Test]
        public void Not_Same_Amount_Open_And_Closed()
        {
            string input = ")";

            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(false, output);
        }

        [Test]
        public void All_Closed()
        {
            string input = "()(())()";

            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void Not_Closed()
        {
            string input = ")(())(";

            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(false, output);
        }



    }
}