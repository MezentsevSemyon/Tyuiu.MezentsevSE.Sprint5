﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using System.IO;
using Tyuiu.MezentsevSE.Sprint5.Task2.V8.Lib;
namespace Tyuiu.MezentsevSE.Sprint5.Task2.V8.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.MezentsevSE.Sprint5\Tyuiu.MezentsevSE.Sprint5.Task2.V8\bin\Debug\OutPutFileTask2.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;

            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
