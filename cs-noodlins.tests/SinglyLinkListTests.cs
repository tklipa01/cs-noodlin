using System;
using Xunit;

namespace cs_noodlins.tests
{
    public class SinglyLinkedListTests
    {
        private readonly SinglyLinkedList<int> list;

        public SinglyLinkedListTests(){
            list = new SinglyLinkedList<int>();
            list.InsertLast(0);
            list.InsertLast(1);
            list.InsertLast(2);
            list.InsertLast(3);
            list.InsertLast(4);
        }

        [Fact]
        public void ShouldGetFirstValue() {            
            Assert.Equal(0, list.GetFirst());
        }

        [Fact]
        public void ShouldGetLastValue() {            
            Assert.Equal(4, list.GetLast());
        }

        [Fact]
        public void ShouldGetValueAtIndex() {            
            Assert.Equal(2, list.GetAt(2));
        }

        [Fact]
        public void ShouldGetSize(){
            Assert.Equal(5, list.Size);
        }

        [Fact]        
        public void ShouldInsertAtBeginning()
        {
            list.InsertFirst(9);
            Assert.Equal(9, list.GetFirst());
        }

        [Fact]
        public void ShouldInsertAtEnd() {
            list.InsertLast(9);
            Assert.Equal(9, list.GetLast());
        }

        [Fact]
        public void ShouldInsertAfterIndex(){
            list.InsertAfter(2, 9);
            Assert.Equal(9, list.GetAt(3));
        }

        [Fact]
        public void ShouldDeleteBeginning(){
            list.DeleteFirst();
            Assert.NotEqual(0, list.GetFirst());
        }

        [Fact]
        public void ShouldDeleteEnd(){
            list.DeleteLast();
            Assert.NotEqual(4, list.GetLast());
        }

        [Fact]
        public void ShouldDeleteAtIndex(){
            list.DeleteAt(2);
            Assert.NotEqual(2, list.GetAt(2));
        }
    }
}
