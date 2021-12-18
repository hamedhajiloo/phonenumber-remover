using Microsoft.VisualStudio.TestTools.UnitTesting;
using Service;

namespace PhoneRemover.Test
{
    [TestClass]
    public class PhoneServiceTest
    {
        private readonly static string Phone1 = "09199876543";
        private readonly static string Phone2 = "+989199876543";
        private readonly static string Phone3 = "9199876543";
        private readonly static string Phone4 = "08199876543";

        [TestMethod]
        public void RemovePhones_SinglePhoneNumber_ReturnEmpty()
        {
            var result1 = PhoneService.RemovePhones(Phone1);

            var result2 = PhoneService.RemovePhones(Phone2);

            var result3 = PhoneService.RemovePhones(Phone3);

            Assert.AreEqual(result1, "");
            Assert.AreEqual(result2, "");
            Assert.AreEqual(result3, "");
        }

        [TestMethod]
        public void RemovePhones_SinglePhoneNumber_ReturnString()
        {
            var result1 = PhoneService.RemovePhones($"havij {Phone1}");
            var result2 = PhoneService.RemovePhones($"havij {Phone2}");
            var result3 = PhoneService.RemovePhones($"havij {Phone3}");

            Assert.AreEqual(result1, "havij ");
            Assert.AreEqual(result2, "havij ");
            Assert.AreEqual(result3, "havij ");
        }

        [TestMethod]
        public void RemovePhones_MultiPhoneNumbers_ReturnString()
        {
            var result1 = PhoneService.RemovePhones($"{Phone1}havij {Phone1}");
            var result2 = PhoneService.RemovePhones($"{Phone1}havij {Phone2}");
            var result3 = PhoneService.RemovePhones($"{Phone1}havij {Phone3}");

            Assert.AreEqual(result1, "havij ");
            Assert.AreEqual(result2, "havij ");
            Assert.AreEqual(result3, "havij ");
        }

        [TestMethod]
        public void RemovePhones_MultiPhoneNumbers_ReturnEmpty()
        {
            var result1 = PhoneService.RemovePhones($"{Phone1}{Phone1}");
            var result2 = PhoneService.RemovePhones($"{Phone1}{Phone2}");
            var result3 = PhoneService.RemovePhones($"{Phone1}{Phone3}");

            Assert.AreEqual(result1, "");
            Assert.AreEqual(result2, "");
            Assert.AreEqual(result3, "");
        }
    }
}