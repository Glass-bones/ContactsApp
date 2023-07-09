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
    public class ProjectTest
    {
        private Project _project;
        [SetUp]
        public void InitProject()
        {
            _project = new Project();
            _project.AddElement(new Contact());
        }
        [Test(Description ="positive GetCount test")]
        public void Array_GetCount_ReturnsValue()
        {
            Assert.AreEqual(1, _project.GetCount(),"GetCount returns wrong number of elements");
        }
        [Test(Description ="positive (Add/Get)Element test")]
        public void ArrayElement_AddCorrectValue_ValueIsSet()
        {
            var expected =new Contact("F","F@no.mail"," - ","pressF",DateTime.Today);
            _project.AddElement(expected);
            var actual = _project.GetElement(_project.GetCount()-1);
            Assert.AreEqual(expected, actual, "GetElement returns wrong contact");
        }
        [Test(Description ="negative AddElement Test")]
        public void ArrayElement_AddNullValue_ThrowException()
        {
            Assert.Throws<ArgumentException>(() => { _project.AddElement(null); },"AddElement accepts null value");
        }
        [Test(Description ="positive (Get/Set)Element test")]
        public void ArrayElement_SetCorrectValueOnCorrectPlace_ValueIsSet()
        {
            var targetIndex = 0;
            var expected = new Contact("F", "F@no.mail", " - ", "pressF", DateTime.Today.AddDays(-1));
            _project.AddElement(new Contact());
            _project.SetElement(expected,targetIndex);
            var actual = _project.GetElement(targetIndex);
            //метод assert не может сравнить объекты класса, поэтому сравниваются строки
            Assert.AreEqual(expected.GetEmail(), actual.GetEmail(), "GetElement returns wrong contact");
        }
        [Test(Description ="negative SetElement null value test")]
        public void ArrayElement_SetNullValueOnCorrectPlace_ThrowException()
        {
            var targetIndex = 0;
            Assert.Throws<ArgumentException>(() => { _project.SetElement(null, targetIndex); }, "SetElement accepts null value");
        }
        [Test(Description ="negative SetElement high index value test")]
        public void ArrayElement_SetCorrectValueOnTooHighPlace_ThrowException()
        {
            var targetIndex = _project.GetCount();
            var expected = new Contact("F", "F@no.mail", " - ", "pressF", DateTime.Today);
            Assert.Throws<ArgumentException>(() => { _project.SetElement(expected, targetIndex); }, "SetElement accepts too high index value");
        }
        [Test(Description = "negative SetElement low index value test")]
        public void ArrayElement_SetCorrectValueOnTooLowPlace_ThrowException()
        {
            var targetIndex = -1;
            var expected = new Contact("F", "F@no.mail", " - ", "pressF", DateTime.Today);
            Assert.Throws<ArgumentException>(() => { _project.SetElement(expected, targetIndex); }, "SetElement accepts too low index value");
        }
        [Test(Description ="positive RemoveElement test")]
        public void ArrayElement_RemoveInboundsElement_ElementIsRemoved()
        {
            var expected = _project.GetCount() - 1;
            var targetIndex = 0;
            _project.RemoveElement(targetIndex);
            var actual = _project.GetCount();
            Assert.AreEqual(expected, actual, "RemoveElement didn't removed element in bounds");
        }
        [Test(Description ="negative RemoveElement too high index test")]
        public void ArrayElement_RemoveTooHighIndexElement_DoesNothing()
        {
            var expected = _project.GetCount() - 1;
            var targetIndex = _project.GetCount();
            _project.RemoveElement(targetIndex);
            var actual = _project.GetCount();
            Assert.AreNotEqual(expected, actual, "RemoveElement removed wrong element from too high input");
        }
        [Test(Description ="Full Project class test")]
        public void Project_Tests_Suit()
        {
            Array_GetCount_ReturnsValue();
            ArrayElement_AddCorrectValue_ValueIsSet();
            ArrayElement_AddNullValue_ThrowException();
            ArrayElement_SetCorrectValueOnCorrectPlace_ValueIsSet();
            ArrayElement_SetCorrectValueOnTooHighPlace_ThrowException();
            ArrayElement_SetCorrectValueOnTooLowPlace_ThrowException();
            ArrayElement_SetNullValueOnCorrectPlace_ThrowException();
            ArrayElement_RemoveInboundsElement_ElementIsRemoved();
            ArrayElement_RemoveTooHighIndexElement_DoesNothing();
        }
    }
}
