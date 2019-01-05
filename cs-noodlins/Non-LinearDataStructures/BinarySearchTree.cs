using System;
using System.Collections.Generic;

namespace cs_noodlins {
    public class BinarySearchTree<T> where T: IComparable<T> {
        public T Data;
        private BinarySearchTree<T> Left;
        private BinarySearchTree<T> Right;

        public BinarySearchTree(T value) {
            Data = value;
        }

        public void Insert(T value) {            
            if(value.CompareTo(Data) < 0 && Left != null){
                Left.Insert(value);
            } else if(value.CompareTo(Data) < 0){
                Left = new BinarySearchTree<T>(value);
            } else if(value.CompareTo(Data) >= 0 && Right != null) {
                Right.Insert(value);
            } else {
                Right = new BinarySearchTree<T>(value);
            }
        }

        public bool Find(T value) {
            if(value.CompareTo(Data) < 0 && Left != null) {
                Console.WriteLine(Data);
                return Left.Find(value);
            } else if(value.CompareTo(Data) > 0 && Right != null) {
                Console.WriteLine(Data);
                return Right.Find(value);
            }            
            return value.CompareTo(Data) == 0;
        }        

        public T FindMinimumValue() {
            if(Left != null){
                return Left.FindMinimumValue();
            } else {
                return Data;
            }
        }

        public T FindMaximumValue() {
            if(Right != null){
                return Right.FindMaximumValue();
            } else {
                return Data;
            }
        }

        public void DFSPreOrder() {
            Console.WriteLine(Data);
            if(Left != null){
                Left.DFSPreOrder();
            }
            if(Right != null) {
                Right.DFSPreOrder();
            }
        }

        public void DFSInOrder() {
            if(Left != null) {
                Left.DFSInOrder();
            }
            Console.WriteLine(Data);
            if(Right != null){
                Right.DFSInOrder();
            }
        }

        public void DFSPostOrder() {
            if(Left != null) {
                Left.DFSInOrder();
            }            
            if(Right != null){
                Right.DFSInOrder();
            }
            Console.WriteLine(Data);
        }

        private void Clear() {
            Data = default(T);
            Left = null;
            Right = null;
        }
    }
}