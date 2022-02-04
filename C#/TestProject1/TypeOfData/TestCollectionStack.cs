using BasicConcepts.TypeOfData;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1.TypeOfData
{
    [TestClass]
    public class TestCollectionStack
    {

        [TestMethod]
        public void Must_CollectionStack_ReturnValuesWithPosition()
        {
            CollectionStack collectionStack = new CollectionStack();
            
            collectionStack.AddElement(1.1);
            Assert.AreEqual("index 0 value 1.1 -", collectionStack.GetElement());

            collectionStack.AddElement(2);
            Assert.AreEqual("index 0 value 2 -index 1 value 1.1 -", collectionStack.GetElement());
        }
    }
}
