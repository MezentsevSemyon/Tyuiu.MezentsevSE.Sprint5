using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;

using Tyuiu.MezentsevSE.Sprint5.Task0.V10.Lib;
namespace Tyuiu.MezentsevSE.Sprint5.Task0.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MezentsevSE.Sprint5\Tyuiu.MezentsevSE.Sprint5.Task0.V10\bin\Debug\OutPutFileTask0.txt";
            FileInfo fileInfo = new FileInfo(path);
            bool fileExist = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExist);
        }
    }
}
