using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.MezentsevSE.Sprint5.Task1.V7.Lib;
namespace Tyuiu.MezentsevSE.Sprint5.Task1.V7.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MezentsevSE.Sprint5\Tyuiu.MezentsevSE.Sprint5.Task1.V7\bin\Debug\OutPutFileTask1.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
