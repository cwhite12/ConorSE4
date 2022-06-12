using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Windows.Forms;
using System.Drawing;


namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        Graphics g = new Graphics();
        Pen p = new Pen();
        ConorSE4.Form1 form = new ConorSE4.Form1();
        private bool expected;
        private bool actual;

        [TestMethod]
        public void TestValidCommand()
        {
            string validCommand = "circle 20";

            form.sendCommand(validCommand);
            expected = true;
            actual = form.validateSyntax();
            Assert.AreEqual(expected, actual);

        }
        [TestMethod]
        public void TestInvalidCommand()
        {
            string invalidCommand = "@@@~@!";
            form.sendCommand(invalidCommand);
            expected = false;
            actual = form.validateSyntax();
            Assert.AreEqual(expected, actual);
        }
        [TestMethod]
        public void TestDraw()
        {

            ConorSE4.Draw draw = new ConorSE4.Draw(g, p, 10, 100);
            
               
        }
    }
}
