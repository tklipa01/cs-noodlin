using System;
using cs_noodlins;

namespace cs_noodlins_run
{
    class Program
    {
        static void Main(string[] args)
        {                         
            var a = new BinaryTree<string>("a");
            a.InsertLeft("b");
            a.InsertRight("c");   
            var b = a.Left;
            var c = a.Right;
            c.InsertLeft("d");
            c.InsertRight("e");
            var d = c.Left;
            var e = c.Right;
            Console.WriteLine("DFS In Order");
            a.DFSInOrder();
            Console.WriteLine("DFS Pre Order");
            a.DFSPreorder();
            Console.WriteLine("DFS Post Order");
            a.DFSPostOrder();
            Console.WriteLine("BFS");
            a.BFS();
        }
    }
}
