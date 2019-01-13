using System;

namespace cs_noodlins {
    public class Queue<T> {
        private SinglyLinkedList<T> List;        

        public int Size { get { return List.Size; } }

        public Queue(){
            List = new SinglyLinkedList<T>();
        }

        public bool IsEmpty() => Size == 0;

        public void Enqueue(T data) => List.InsertLast(data);

        public T Dequeue() {
            var val = List.GetFirst();
            List.DeleteFirst();
            return val;
        }

        public T PeekFirst() => List.GetFirst();        

        public T PeekLast() => List.GetLast();

        public void Clear() => List.Clear();
    }
}