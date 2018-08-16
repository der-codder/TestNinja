using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests.Fundamentals
{
    [TestFixture]
    public class StackTests
    {
        [Test]
        public void Count_EmptyStack_ReturnsZero()
        {
            var stack = new Stack<int>();
            
            Assert.That(stack.Count, Is.EqualTo(0));
        }

        [Test]
        public void Push_WhenCalled_AddsItemToTheStack()
        {
            var stack = new Stack<object>();

            stack.Push(new object());
            
            Assert.That(stack.Count, Is.EqualTo(1));
        }

        [Test]
        public void Push_ArgumentIsNull_ThrowsArgumentNullException()
        {
            var stack = new Stack<object>();
            
            Assert.That(() => stack.Push(null),
                Throws.ArgumentNullException);
        }

        [Test]
        public void Pop_StackContainsItems_ReturnsLastElement()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            
            var result = stack.Pop();
            
            Assert.That(result, Is.EqualTo(1));
        }

        [Test]
        public void Pop_StackContainsItems_RemovesLastElement()
        {
            var stack = new Stack<int>();
            stack.Push(1);
            
            stack.Pop();
            
            Assert.That(stack.Count, Is.EqualTo(0));
        }
        
        [Test]
        public void Pop_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<object>();
            
            Assert.That(() => stack.Pop(),
                Throws.InvalidOperationException);
        }

        [Test]
        public void Peek_StackContainsItems_ReturnsLastElementAndDoesNotChangingCount()
        {
            var stack = new Stack<string>();
            stack.Push("test");

            var result = stack.Peek();

            Assert.That(result, Is.EqualTo("test"));
            Assert.That(stack.Count, Is.EqualTo(1));
        }
        
        [Test]
        public void Peek_EmptyStack_ThrowsInvalidOperationException()
        {
            var stack = new Stack<object>();
            
            Assert.That(() => stack.Peek(),
                Throws.InvalidOperationException);
        }
    }
}
