using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary1;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            int maxVal = 100;
            Class1 cls1 = new Class1(maxVal);
            dynamic res = JsonConvert.DeserializeObject(cls1.RTNINfo());
            Assert.IsInstanceOfType(res, typeof(Newtonsoft.Json.Linq.JObject));

        }
    }
}
