using System;
using System.Collections.Generic;

namespace cs_noodlins {
    public class BinaryTree<T> where T : IComparable<T> {        
        public T Data;
        public BinaryTree<T> Left;
        public BinaryTree<T> Right;
        public BinaryTree(T value) {
            Data = value;      
        }

        public void InsertLeft(T value) {
            if(Left == null){
                Left = new BinaryTree<T>(value);
            } else {
                //Insert new node here and push down current node
                var newNode = new BinaryTree<T>(value);
                newNode.Left = Left;
                Left = newNode;
            }
        }

        public void InsertRight(T value) {
            if(Right == null){
                Right = new BinaryTree<T>(value);
            } else {
                //Insert new node here and push down current node
                var newNode = new BinaryTree<T>(value);
                newNode.Right = Right;
                Right = newNode;
            }
        }

        //DFS Operations
        public void DFSPreorder() {
            Console.WriteLine(Data);
            if(Left != null){
                Left.DFSPreorder();
            }

            if(Right != null){
                Right.DFSPreorder();
            }
        }

        public void DFSInOrder() {
            if(Left != null){
                Left.DFSInOrder();
            }

            Console.WriteLine(Data);

            if(Right != null){
                Right.DFSInOrder();
            }
        }

        public void DFSPostOrder() {
            if(Left != null) {
                Left.DFSPostOrder();
            }

            if(Right != null) {
                Right.DFSPostOrder();
            }

            Console.WriteLine(Data);
        }

        //BFS
        public void BFS() {
            var queue = new Queue<BinaryTree<T>>();
            queue.Enqueue(this);
            while(!queue.IsEmpty()) {
                var currentNode = queue.Dequeue();
                Console.WriteLine(currentNode.Data);
                if(currentNode.Left != null){
                    queue.Enqueue(currentNode.Left);
                }

                if(currentNode.Right != null){
                    queue.Enqueue(currentNode.Right);
                }
            }
        }

        public bool IsSymmetric() => IsMirror(Left, Right);

        private bool IsMirror(BinaryTree<T> left, BinaryTree<T> right) {
            if(left == null || right == null) {
                return left == null && right == null;                
            }
            return left.Data.CompareTo(right.Data) == 0 && IsMirror(left.Left, right.Right) && IsMirror(left.Right, right.Left);
        }
    }
}