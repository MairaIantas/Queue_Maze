using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue_Maze;

namespace Queue_Maze_Test
{
    [TestClass]
    public class QueueTest
    {
        [TestMethod]
        public void testEnqueueIsEmpty()
        {
            Queue<Point> queue = new Queue<Point>();
            Assert.IsTrue(queue.Size == 0);
            Assert.IsTrue(queue.IsEmpty());
        }

        [TestMethod]
        public void testEnqueueSingleElementSuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            queue.Enqueue(element);

            Assert.IsTrue(queue.Size == 1);
            Assert.IsTrue(queue.Head.Element == element);
        }

        [TestMethod]
        public void testEnqueueMoreThanOneElementsSuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            queue.Enqueue(element);

            Assert.IsTrue(queue.Size == 1);
            Assert.IsTrue(queue.Head.Element == element);

            queue.Enqueue(element2);

            Assert.IsTrue(queue.Size == 2);
            Assert.IsTrue(queue.Tail.Element == element2);

            queue.Enqueue(element3);

            Assert.IsTrue(queue.Size == 3);
            Assert.IsTrue(queue.Tail.Element == element3);
        }

        [TestMethod]
        public void testDequeueSingleElementSuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            queue.Enqueue(element);

            Assert.IsTrue(queue.Size == 1);
            Assert.IsTrue(queue.Head.Element == element);

            queue.Enqueue(element2);

            Assert.IsTrue(queue.Size == 2);
            Assert.IsTrue(queue.Head.Element == element);

            Assert.IsTrue(queue.Dequeue() == element);

            Assert.IsTrue(queue.Size == 1);
            Assert.IsTrue(queue.Tail.Element == element2);

        }

        [TestMethod]
        public void testDequeueMoreThanOneSuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 2);
            queue.Enqueue(element);
            queue.Enqueue(element2);
            queue.Enqueue(element3);

            Assert.IsTrue(queue.Size == 3);
            Assert.IsTrue(queue.Front() == element);
            Assert.IsTrue(queue.Tail.Element == element3);

            Assert.IsTrue(queue.Dequeue() == element);
            Assert.IsTrue(queue.Size == 2);
            Assert.IsTrue(queue.Front() == element2);
            Assert.IsTrue(queue.Tail.Element == element3);

            Assert.IsTrue(queue.Dequeue() == element2);
            Assert.IsTrue(queue.Size == 1);
            Assert.IsTrue(queue.Front() == element3);
            Assert.IsTrue(queue.Tail.Element == element3);

            Assert.IsTrue(queue.Dequeue() == element3);
            Assert.IsTrue(queue.IsEmpty());
            Assert.IsNull(queue.Head);
            Assert.IsNull(queue.Tail);
        }

        [TestMethod]
        public void testFrontSuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            queue.Enqueue(element);

            Assert.IsNotNull(queue.Front());
            Assert.IsTrue(queue.Front() == element);
        }

        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void testFrontException()
        {
            Queue<Point> queue = new Queue<Point>();
            queue.Front();
        }

        [TestMethod]
        public void testGetSizeIncreased()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            queue.Enqueue(element);

            Assert.IsTrue(queue.GetSize() == 1);

            queue.Enqueue(element2);

            Assert.IsTrue(queue.GetSize() == 2);

            queue.Enqueue(element3);

            Assert.IsTrue(queue.GetSize() == 3);
        }

        [TestMethod]
        public void testGetSizeDecreased()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            queue.Enqueue(element);
            queue.Enqueue(element2);
            queue.Enqueue(element3);

            Assert.IsTrue(queue.GetSize() == 3);

            while (queue.GetSize() != 0)
            {
                queue.Dequeue();
            }

            Assert.IsTrue(queue.GetSize() == 0);
        }

        [TestMethod]
        public void testIsEmptySuccessfully()
        {
            Queue<Point> queue = new Queue<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            queue.Enqueue(element);
            queue.Enqueue(element2);
            queue.Enqueue(element3);

            Assert.IsFalse(queue.IsEmpty());

            while (queue.GetSize() != 0)
            {
                queue.Dequeue();
            }

            Assert.IsTrue(queue.IsEmpty());
        }

    }
}
