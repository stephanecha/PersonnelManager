using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PersonnelManager.Business.Services;

namespace PersonnelManager.Business.Tests
{
    [TestClass]
    public class ServiceEmployeTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            var serviceEmploye = 
                new ServiceEmploye(new FauxDataEmploye());
        }
    }
}
