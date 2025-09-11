using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.ShelomentsevYA.Sprint0.Task2.V0.Lib;
namespace Tyuiu.ShelomentsevYA.Sprint0.Task2.V0.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void CheckGetMessageValid()
        {
            var name = "Ярослав";
            var res = DataService.GetMessage(name);

            Assert.AreEqual("Привет..., Ярослав", res);
        }
    }
}
