using System;
using Xunit;

namespace cs_noodlins.tests
{
    public class QueueTests{
        private readonly Queue<int> queue;

        public QueueTests() {
            queue = new Queue<int>();
        }

        [Fact]
        public void ShouldEnqueAtEnd() {
            queue.Enqueue(3);
            queue.Enqueue(5);  
            Assert.False(queue.IsEmpty());          
            Assert.Equal(5, queue.PeekLast());                        
        }     

        [Fact]
        public void ShouldDequeueAtBeginning() {
            queue.Enqueue(3);
            queue.Enqueue(5);
            Assert.False(queue.IsEmpty());
            Assert.Equal(3, queue.PeekFirst());
        }

        [Fact]
        public void ShouldClearAllValues() {
            queue.Enqueue(3);
            queue.Enqueue(5);
            Assert.False(queue.IsEmpty());
            queue.Clear();
            Assert.True(queue.IsEmpty());
        }      

        [Fact]
        public void ShouldReturnCorrectSize(){
            Assert.Equal(0, queue.Size);
            queue.Enqueue(3);
            Assert.Equal(1, queue.Size);
            queue.Dequeue();
            Assert.Equal(0, queue.Size);
        }   
    }
}