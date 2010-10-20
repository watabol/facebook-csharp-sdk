// <copyright file="UnixDateTimeTest.cs" company="Thuzi, LLC">Microsoft Public License (Ms-PL)</copyright>
using System;
using Microsoft.Pex.Framework;
using Microsoft.Pex.Framework.Validation;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Facebook
{
    /// <summary>This class contains parameterized unit tests for UnixDateTime</summary>
    [PexClass(typeof(DateTimeConvertor))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(InvalidOperationException))]
    [PexAllowedExceptionFromTypeUnderTest(typeof(ArgumentException), AcceptExceptionSubtypes = true)]
    [TestClass]
    public partial class DateTimeConvertorTest
    {
        /// <summary>Test stub for FromUnixTime(String)</summary>
        [PexMethod, PexAllowedException(typeof(FormatException))]
        internal DateTime FromUnixTime(string unixTime)
        {
            DateTime result = DateTimeConvertor.FromUnixTime(unixTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.FromUnixTime(String)
        }

        /// <summary>Test stub for FromUnixTime(String)</summary>
        [PexMethod, PexAllowedException(typeof(FormatException))]
        internal DateTime FromUnixTime(double unixTime)
        {
            DateTime result = DateTimeConvertor.FromUnixTime(unixTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.FromUnixTime(String)
        }

        /// <summary>Test stub for ToUnixTime(DateTime)</summary>
        [PexMethod]
        internal double ToUnixTime(DateTime dateTime)
        {
            double result = DateTimeConvertor.ToUnixTime(dateTime);
            return result;
            // TODO: add assertions to method UnixDateTimeTest.ToUnixTime(DateTime)
        }
    }
}
