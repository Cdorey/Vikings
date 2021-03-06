﻿// <copyright file="GoogleTranslateTest.cs" company="Vikings">Copyright ©  2019</copyright>

using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Vikings.Translate;

namespace Vikings.Translate.Tests
{
    [TestClass]
    [PexClass(typeof(GoogleTranslate))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    public partial class GoogleTranslateTest
    {

        [PexMethod]
        public string GetTK(string text, string tkk)
        {
            string result = GoogleTranslate.GetTK(text, tkk);
            return result;
            // TODO: 将断言添加到 方法 GoogleTranslateTest.GetTK(String, String)
        }
    }
}
