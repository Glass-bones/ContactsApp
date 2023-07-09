using ContactsApp.Model;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ontactsApp.Model.UnitTests
{
    [TestFixture]
    public class ContactTest
    {
        private Contact _contact;
        [SetUp]
        public void InitContact()
        {
            _contact = new Contact();
        }
        [Test(Description ="positive (Get/Set)FullName test")]
        public void FullName_SetCorrectValue_ValueIsSet()
        {
            var expected = "Johnny";
            _contact.SetFullName(expected);
            var actual=_contact.GetFullName();
            Assert.AreEqual(expected, actual,"GetFullName returns wrong name");
        }
        [Test(Description ="negative SetFullName test")]
        public void FullName_SetTooLongValue_ThrowException()
        {
            var expected = "Typically, random packing of coins can achieve an efficiency of around 60-70%, meaning that around 30-40% of the container space would be left empty. However, this efficiency can vary depending on the specific circumstances and conditions of the packing process.";
            Assert.Throws<ArgumentException>(() => {_contact.SetFullName(expected); }, "SetFullName accepts invalid name");
        }
        [Test(Description ="positive (Get/Set)Email test")]
        public void Email_SetCorrectValue_ValueIsSet()
        {
            var expected = "sui@no.mail";
            _contact.SetEmail(expected);
            var actual = _contact.GetEmail();
            Assert.AreEqual(expected, actual, "GetEmail returns wrong email");
        }
        [Test(Description="negative SetEmail test")]
        public void Email_SetTooLongValue_ThrowException()
        {
            var expected = "Typically, random packing of coins can achieve an efficiency of around 60-70%, meaning that around 30-40% of the container space would be left empty. However, this efficiency can vary depending on the specific circumstances and conditions of the packing process.";
            Assert.Throws<ArgumentException>(() => { _contact.SetEmail(expected); }, "SetEmail accepts invalid email");
        }
        [Test(Description ="positive (Get/Set)PhoneNumer test")]
        public void PhoneNumber_SetCorrectValue_ValueIsSet()
        {
            var expected = "21+-() ";
            _contact.SetPhoneNumber(expected);
            var actual = _contact.GetPhoneNumber();
            Assert.AreEqual(expected, actual, "GetPhoneNumber returns wrong phone number");
        }
        [Test(Description ="negative SetPhoneNumber test")]
        public void PhoneNumber_SetInvalidCharactersValue_ThrowException()
        {
            var expected = "21+-() e";
            Assert.Throws<ArgumentException>(() => { _contact.SetPhoneNumber(expected); }, "SetPhoneNumber accepts invalid number");
        }
        [Test(Description ="positive (Get/Set)VK test")]
        public void VK_SetCorrectValue_ValueIsSet()
        {
            var expected = "nay";
            _contact.SetVK(expected);
            var actual = _contact.GetVK();
            Assert.AreEqual(expected, actual, "GetVK returns wrong vk");
        }
        [Test(Description ="negative SetVK test")]
        public void VK_SetTooLongValue_ThrowException()
        {
            var expected = "Typically, random packing of coins can achieve an efficiency of around 60-70%, meaning that around 30-40% of the container space would be left empty. However, this efficiency can vary depending on the specific circumstances and conditions of the packing process.";
            Assert.Throws<ArgumentException>(() => { _contact.SetVK(expected); }, "SetVK accepts invalid name");
        }
        [Test(Description ="positive (Get/Set)BirthDate test")]
        public void BirthDate_SetCorrectValue_ValueIsSet()
        {
            var expected = DateTime.Today;
            _contact.SetBirthDate(expected);
            var actual = _contact.GetBirthDate();
            Assert.AreEqual(expected, actual, "GetBirthDate returns wrong date");
        }
        [Test(Description ="negative SetBirthDate high value test")]
        public void BirthDate_SetTomorrowValue_ThrowException()
        {
            var expected = DateTime.Today.AddDays(1);
            Assert.Throws<ArgumentException>(() => { _contact.SetBirthDate(expected); }, "SetBirthDate accepts invalid date");
        }
        [Test(Description ="negative SetBirthDate low value test")]
        public void BirthDate_SetTooLowValue_ThrowException()
        {
            var expected = new DateTime(1899,12,31);
            Assert.Throws<ArgumentException>(() => { _contact.SetBirthDate(expected); }, "SetBirthDate accepts invalid date");
        }
        [Test(Description ="Full Contact class test")]
        public void Contact_Tests_Suit()
        {
            FullName_SetCorrectValue_ValueIsSet();
            FullName_SetTooLongValue_ThrowException();
            Email_SetCorrectValue_ValueIsSet();
            Email_SetTooLongValue_ThrowException();
            PhoneNumber_SetCorrectValue_ValueIsSet();
            PhoneNumber_SetInvalidCharactersValue_ThrowException();
            VK_SetCorrectValue_ValueIsSet();
            VK_SetTooLongValue_ThrowException();
            BirthDate_SetCorrectValue_ValueIsSet();
            BirthDate_SetTomorrowValue_ThrowException();
            BirthDate_SetTooLowValue_ThrowException();
        }
    }
}
