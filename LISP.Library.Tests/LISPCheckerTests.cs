using NUnit.Framework;

namespace LISP.Library.Tests
{
    [TestFixture]
    public class LISPCheckerTests
    {
   
        [Test]
        public void Same_Amount_Open_And_Closed(
            [Values("","()","(()())")] string input)
        {
            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(true,output);
        }

        [Test]
        public void Not_Same_Amount_Open_And_Closed(
            [Values("(", ")", "(()))")] string input)
        {
            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(false, output);
        }

        [Test]
        public void All_Closed(
            [Values("(write (/ 1 2))", "(write ( + (/ 1 2) (/ 3 4)))", "(setf (book-id book3) 100)")] string input)
        {

            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(true, output);
        }

        [Test]
        public void Not_Closed(
            [Values("(write ( + #c( 1 2) #c( 3 -4))", "(write  + (/ 1 2) (/ 3 4)))", "(setf book-id book3) 100)")] string input)
        {
            bool output = LISPChecker.IsLispValid(input);

            Assert.AreEqual(false, output);
        }



    }
}