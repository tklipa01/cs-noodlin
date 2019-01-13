using System;
using System.Collections.Generic;

namespace cs_noodlins {
    public class MaxHeap<T> where T : IComparable<T> {
        private T[] List;
        private int Size;

        public MaxHeap(int size = 10) {
            List = new T[size];
        }

        public void Insert(T value) {
            if(Size == List.Length) Array.Resize(ref List, Size * 2);

            List[Size] = value;
            Size++;

            HeapifyUp();
        }

        public bool IsEmpty(){
            return Size == 0;
        }

        public T Peek() {
            if(Size == 0) throw new IndexOutOfRangeException();
            return List[0];
        }

        public T Pop() {
            if(Size == 0) throw new IndexOutOfRangeException();
            var result = List[0];
            List[0] = List[Size - 1];
            Size--;
            HeapifyDown();
            return result;
        }

        private int GetParentIndex(int index) => (index - 1) / 2;
        private int GetLeftChildIndex(int index) => 2 * index + 1;
        private int GetRightChildIndex(int index) => 2 * index + 2;

        private bool IsRoot(int index) => index == 0;
        private bool HasLeftChild(int index) => GetLeftChildIndex(index) < Size;
        private bool HasRightChild(int index) => GetRightChildIndex(index) < Size;

        private T GetParent(int index) => List[GetParentIndex(index)];
        private T GetLeftChild(int index) => List[GetLeftChildIndex(index)];
        private T GetRightChild(int index) => List[GetRightChildIndex(index)];

        private void Swap(int firstIndex, int secondIndex) {
            var temp = List[firstIndex];
            List[firstIndex] = List[secondIndex];
            List[secondIndex] = temp;
        }

        private void HeapifyDown() {
            int index = 0;
            while(HasLeftChild(index)) {
                var largerIndex = GetLeftChildIndex(index);
                if(HasRightChild(index) && GetRightChild(index).CompareTo(GetLeftChild(index)) > 0){
                    largerIndex = GetRightChildIndex(index);
                }

                if(List[largerIndex].CompareTo(List[index]) < 0) {
                    break;
                }

                Swap(largerIndex, index);
                index = largerIndex;
            }
        }

        private void HeapifyUp() {
            var index = Size - 1;
            while(!IsRoot(index) && List[index].CompareTo(GetParent(index)) > 0) {
                var parentIndex = GetParentIndex(index);
                Swap(parentIndex, index);
                index = parentIndex;
            }
        }
    }
}