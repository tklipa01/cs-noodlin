using System;

namespace cs_noodlins
{
    public class SinglyLinkedList<T> {
        private Node<T> Head;
        private Node<T> Tail;
        private int _size;
        public int Size { 
            get { return _size; } 
            private set {
                if(value < 0) {
                    throw new ArgumentException("Size cannot be < 0");
                }
                _size = value;
            }
        }

        public T GetFirst() {
            return Head.data;
        }

        public T GetLast() {
            return Tail.data;
        }        

        public T GetAt(int index) {
            return GetNodeAt(index).data;
        }

        public void InsertFirst(T data){ 
            var newNode = new Node<T>(data);

            if(CreateHeadIfNotExists(newNode)){
                return;
            }

            newNode.next = Head;
            Head = newNode;
            Size++;
        }

        public void InsertLast(T data){
            var newNode = new Node<T>(data);

            //If this is the first node
            if(CreateHeadIfNotExists(newNode)){
                return;
            }


            Tail.next = newNode;
            Tail = newNode;
            Size++;
        }

        public void InsertAfter(int index, T data){
            var newNode = new Node<T>(data);
            
            if(CreateHeadIfNotExists(newNode)){
                return;
            }

            var node = GetNodeAt(index);            
            newNode.next = node.next; 
            node.next = newNode; 
            Size++;

            //If we insert at the end of the list 
            if(index == Size - 1){
                Tail = newNode;
            }                          
        } 

        public void DeleteFirst() {
            Head = Head.next;
            Size--;
        } 

        public void DeleteLast() {
            var previousNode = GetNodeAt((Size - 1) - 1);
            previousNode.next = null;
            Tail = previousNode;
            Size--;
        }

        public void DeleteAt(int index){
            var nodeToDelete = GetNodeAt(index);

            //If we're deleting the head
            if(index == 0){
                Head = nodeToDelete.next;
                Size--;
                return;
            }  

            var previous = GetNodeAt(index - 1);
            previous.next = nodeToDelete.next;
            Size--;
        }     

        public void PrintList() {
            Print(Head);
        }    

        private bool CreateHeadIfNotExists(Node<T> newNode) {
            if(Head == null){
                Head = newNode;
                Tail = Head;
                Size++;
                return true;
            }
            return false;
        }          

        private Node<T> GetNodeAt(int index) {
            var current = Head;
            for(var i = 0; i < index; i++){
                if(current.next == null){
                    throw new IndexOutOfRangeException();
                }
                current = current.next;
            }
            return current;
        }

        private void Print(Node<T> current) {            
            Console.Write(current.data);
            if(current.next != null){
                Console.Write(", ");
                Print(current.next);
                return;
            }
            Console.WriteLine("");
        }        
    }    

    class Node<T> {
        public T data;
        public Node<T> next; 

        public Node(T data) {
            this.data = data;
            next = null;
        }       
    }
}
