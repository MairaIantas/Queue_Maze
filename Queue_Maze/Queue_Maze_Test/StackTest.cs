using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Queue_Maze;

namespace Queue_Maze_Test
{
    [TestClass]
    public class StackTest
    {
        /// <summary>
        /// Method to test constructor successful
        /// </summary>
        [TestMethod]
        public void testStackConstructor()
        {
            Stack<Point> stack = new Stack<Point>();
            Assert.IsNotNull(stack);
        }

        /// <summary>
        /// Method to test Push method successful
        /// </summary>
        [TestMethod]
        public void testPushSuccessful()
        {
            Stack<Point> stack = new Stack<Point>();
            Point element = new Point(0, 0);
            stack.Push(element);

            Assert.IsTrue(stack.Size == 1);
            Assert.IsTrue(stack.Head.Element == element);
        }

        /// <summary>
        /// Method to test Top method successful
        /// </summary>
        [TestMethod]
        public void testTopSuccessful()
        {
            Stack<Point> stack = new Stack<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            stack.Push(element);
            stack.Push(element2);

            Assert.IsTrue(stack.Top() == element2);
        }

        /// <summary>
        /// Method to test Top method exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void testTopException()
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Top();
        }

        /// <summary>
        /// Method to test Pop method successful
        /// </summary>
        [TestMethod]
        public void testPopSuccessful()
        {
            Stack<Point> stack = new Stack<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            stack.Push(element);
            stack.Push(element2);
            stack.Push(element3);

            Assert.IsTrue(stack.Pop() == element3);
        }

        /// <summary>
        /// Method to test Pop method Exception
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(ApplicationException))]
        public void testPopException()
        {
            Stack<Point> stack = new Stack<Point>();
            stack.Pop();
        }

        /// <summary>
        /// Method to test getSize method successful
        /// </summary>
        [TestMethod]
        public void testGetSize()
        {
            Stack<Point> stack = new Stack<Point>();
            Point element = new Point(0, 0);
            Point element2 = new Point(0, 1);
            Point element3 = new Point(0, 3);
            stack.Push(element);
            stack.Push(element2);
            stack.Push(element3);

            Assert.IsTrue(stack.GetSize() == 3);
        }

        /// <summary>
        /// Method to test IsEmpty successful
        /// </summary>
        [TestMethod]
        public void testIsEmpty()
        {
            Stack<Point> stack = new Stack<Point>();

            Assert.IsTrue(stack.IsEmpty());

            Point element = new Point(0, 0);
            stack.Push(element);

            Assert.IsFalse(stack.IsEmpty());
        }
    }
}

