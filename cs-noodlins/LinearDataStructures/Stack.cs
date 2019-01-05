using System;

namespace cs_noodlins {

    public class Stack<T> {
        private SinglyLinkedList<T> List;
        public int Size { get { return List.Size; } }

        public Stack(){
            List = new SinglyLinkedList<T>();
        }

        public bool IsEmpty() {
            return Size == 0;
        }

        public void Push(T data) {
            List.InsertFirst(data);
        }

        public T Pop() {
            var val = List.GetFirst();
            List.DeleteFirst();
            return val;
        }

        public T Peek(){
            return List.GetFirst();
        }

        public void Clear() {
            List.Clear();
        }
    }
}