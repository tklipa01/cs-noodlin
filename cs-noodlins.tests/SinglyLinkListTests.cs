using System;
using Xunit;

namespace cs_noodlins.tests
{
    public class SinglyLinkedListTests
    {
        private readonly SinglyLinkedList<int> list;

        public SinglyLinkedListTests(){
            list = new SinglyLinkedList<int>();
            list.InsertEnd(0);
            list.InsertEnd(1);
            list.InsertEnd(2);
            list.InsertEnd(3);
            list.InsertEnd(4);
        }

        [Fact]        
        public void ListShouldInsertAtBeginning()
        {
            list.InsertBeginning(3);
            Assert.Equal(3, list.GetFirst());
        }
    }
}
