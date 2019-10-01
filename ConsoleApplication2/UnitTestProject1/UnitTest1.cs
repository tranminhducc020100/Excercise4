using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ConsoleApplication2;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
          
        public void TestIsOdd()
        {
            bool result3 = Program.IsOdd(3);
            Assert.AreEqual(true, result3);

            bool result4 = Program.IsOdd(4);
            Assert.AreEqual(false, result4);

        }
        [TestMethod]
        public void TestCeil()
        {
            int rs1= Program.Ceil((float)2.3);
            Assert.AreEqual(3, rs1);

            int rs2= Program.Ceil(-2.3f);
            Assert.AreEqual(-2, rs2);

           // int rs3 = Program.Ceil(3);
            //Assert.AreEqual()
        }
         [TestMethod]
        public void TestFloor()
        {
           int rs = Program.Floor((float)2.3);
             Assert.AreEqual(2,rs);

             int rs5 = Program.Floor(-2.3f);
             Assert.AreEqual(-3, rs5);

        }
         [TestMethod]

         public void TestRand1()
         {
            
         }
        }
    }

