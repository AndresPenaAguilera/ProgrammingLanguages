using BasicConcepts.TypeOfData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1.TypeOfData
{
    [TestClass]
    public class TestGenerics
    {
        [TestMethod]
        public void Must_Generics_ReturnType_Alumno()
        {
            Generics<Student> generics = new Generics<Student>(2);
            generics.AddElement(new Student(1));
            generics.AddElement(new Student(1.5));

            var actual = generics.GetElement(0);
            Assert.AreEqual(typeof(Student), actual.GetType());
        }

        [TestMethod]
        public void Must_Generics_ReturnType_String()
        {
            Generics<string> generics = new Generics<string>(2);
            generics.AddElement("Juan");
            generics.AddElement("Otro");

            var actual = generics.GetElement(0);
            Assert.AreEqual(typeof(string), actual.GetType());
            Assert.AreEqual("Juan", actual);
        }
    }
}
