using System;
using Xunit;

namespace cs_noodlins.tests
{

    public class StackTests{
        private readonly Stack<int> stack;

        public StackTests() {
            stack = new Stack<int>();
        }

        [Fact]
        public void ShouldPushFirst() {
            stack.Push(5);
            stack.Push(9);            
            Assert.Equal(9, stack.Peek());            
        }

        [Fact]
        public void ShouldPopFirst() {
            stack.Push(5);
            stack.Push(9);
            Assert.Equal(9, stack.Peek());
        }

        [Fact]
        public void ShouldClearAllValues() {
            stack.Push(5);
            stack.Push(9);
            Assert.False(stack.IsEmpty());
            stack.Clear();
            Assert.True(stack.IsEmpty());
        }  

        [Fact]
        public void ShouldReturnCorrectSize(){
            Assert.Equal(0, stack.Size);
            stack.Push(3);
            Assert.Equal(1, stack.Size);
            stack.Pop();
            Assert.Equal(0, stack.Size);
        } 
    }
}