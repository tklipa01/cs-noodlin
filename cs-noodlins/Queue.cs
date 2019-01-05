using System;

namespace cs_noodlins {
    public class Queue<T> {
        private SinglyLinkedList<T> list;        

        public int Size { get { return list.Size; } }

        public Queue(){
            list = new SinglyLinkedList<T>();
        }

        public bool IsEmpty() {
            return list.Size == 0;
        }

        public void Enqueue(T data) {
            list.InsertLast(data);
        }

        public T Dequeue() {
            var val = list.GetFirst();
            list.DeleteFirst();
            return val;
        }

        public T PeekFirst() {
            return list.GetFirst();
        }

        public T PeekLast() {
            return list.GetLast();
        }

        public void Clear(){
            list.Clear();
        }
    }
}