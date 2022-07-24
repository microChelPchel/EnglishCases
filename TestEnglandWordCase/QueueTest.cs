using EnglandWordCase.StructureData;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestEnglandWordCase
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void CtorTest()
        {
            Queue<int> queue = new Queue<int>();
            Assert.IsTrue(queue.IsEmpty());
            queue = new Queue<int>(3);
            Assert.IsTrue(!queue.IsEmpty());
        }

        [TestMethod]
        public void QueTest()
        {
            Queue<int> queue = new Queue<int>(3);
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            Assert.AreEqual(queue.Dequeue(), 1);
            Assert.AreEqual(queue.Dequeue(), 2);
            Assert.AreEqual(queue.Dequeue(), 3);
            Assert.ThrowsException<InvalidOperationException>(() => queue.Dequeue());
            //check extension array
            queue.Enqueue(4);
            queue.Enqueue(new Random().Next());
            queue.Enqueue(new Random().Next());
            queue.Enqueue(new Random().Next());
            Assert.AreEqual(queue.Dequeue(), 4);
        }

        [TestMethod]
        public void PeekTest()
        {
            Queue<int> queue = new Queue<int>();
            Assert.ThrowsException<InvalidOperationException>(()=>queue.Peek());
            queue.Enqueue(1);
            queue.Enqueue(2);
            Assert.AreEqual(queue.Peek(), 1);
            Assert.AreEqual(queue.Peek(), 1);
            queue.Dequeue();
            Assert.AreEqual(queue.Peek(), 2);
        }

    }
}
