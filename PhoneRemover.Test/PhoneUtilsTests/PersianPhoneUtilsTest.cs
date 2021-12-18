using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;

namespace PhoneRemover.Test
{
    [TestClass]
    public class PersianPhoneUtilsTest
    {
        private readonly static string Phone1 = "۰۹۱۹۸۷۶۵۴۳۲";
        private readonly static string Phone2 = "+۹۸۹۱۹۸۷۶۵۴۳۲";
        private readonly static string Phone3 = "۹۱۹۸۷۶۵۴۳۲";
        private readonly static string Phone4 = "۰۸۱۲۲۲۳۴";

        [TestMethod]
        public void RemovePhones_SinglePhoneNumber_ReturnEmpty()
        {
            var result1 = PhoneUtils.RemovePhones(Phone1);

            var result2 = PhoneUtils.RemovePhones(Phone2);

            var result3 = PhoneUtils.RemovePhones(Phone3);

            Assert.AreEqual(result1, "");
            Assert.AreEqual(result2, "");
            Assert.AreEqual(result3, "");
        }

        [TestMethod]
        public void RemovePhones_SinglePhoneNumber_ReturnString()
        {
            var result1 = PhoneUtils.RemovePhones($"havij {Phone1}");
            var result2 = PhoneUtils.RemovePhones($"havij {Phone2}");
            var result3 = PhoneUtils.RemovePhones($"havij {Phone3}");

            Assert.AreEqual(result1, "havij ");
            Assert.AreEqual(result2, "havij ");
            Assert.AreEqual(result3, "havij ");
        }

        [TestMethod]
        public void RemovePhones_MultiPhoneNumbers_ReturnString()
        {
            var result1 = PhoneUtils.RemovePhones($"{Phone1}havij {Phone1}");
            var result2 = PhoneUtils.RemovePhones($"{Phone1}havij {Phone2}");
            var result3 = PhoneUtils.RemovePhones($"{Phone1}havij {Phone3}");

            Assert.AreEqual(result1, "havij ");
            Assert.AreEqual(result2, "havij ");
            Assert.AreEqual(result3, "havij ");
        }

        [TestMethod]
        public void RemovePhones_MultiPhoneNumbers_ReturnEmpty()
        {
            var result1 = PhoneUtils.RemovePhones($"{Phone1}{Phone1}");
            var result2 = PhoneUtils.RemovePhones($"{Phone1}{Phone2}");
            var result3 = PhoneUtils.RemovePhones($"{Phone1}{Phone3}");

            Assert.AreEqual(result1, "");
            Assert.AreEqual(result2, "");
            Assert.AreEqual(result3, "");
        }

        [TestMethod]
        public void RemovePhones_WrongPhoneNumbers_ReturnSame()
        {
            var result1 = PhoneUtils.RemovePhones($"{Phone4}");

            Assert.AreEqual(result1, $"{Phone4}");
        }
    }
}