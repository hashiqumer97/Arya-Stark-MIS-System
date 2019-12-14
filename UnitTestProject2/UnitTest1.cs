    using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using AryaStarkHashiqCsd55;

namespace UnitTestProject2
{
    [TestClass]
    public class UnitTest1
    {

        [TestMethod]
        public void TestMethod1()
        {
            frm_modifyclients frm = new frm_modifyclients();
            frm.deleterecord(114);
           
        }
    }
}
