using System;
using System.Collections.Generic;
using System.Linq;
using cs_noodlins;

namespace cs_noodlins_run
{
    static class Program
    {
        static void Main(string[] args)
        {                         
            // var a = new BinaryTree<string>("a");
            // a.InsertLeft("b");
            // a.InsertRight("c");   
            // var b = a.Left;
            // var c = a.Right;
            // c.InsertLeft("d");
            // c.InsertRight("e");
            // var d = c.Left;
            // var e = c.Right;
            // Console.WriteLine("DFS In Order");
            // a.DFSInOrder();
            // Console.WriteLine("DFS Pre Order");
            // a.DFSPreorder();
            // Console.WriteLine("DFS Post Order");
            // a.DFSPostOrder();
            // Console.WriteLine("BFS");
            // a.BFS();

            // var symmetricTree = new BinaryTree<int>(5);
            // symmetricTree.InsertLeft(1);
            // symmetricTree.InsertRight(1);
            // symmetricTree.Left.InsertLeft(2);
            // symmetricTree.Left.InsertRight(3);
            // symmetricTree.Right.InsertLeft(3);
            // symmetricTree.Right.InsertRight(2);

            // symmetricTree.BFS();

            // var array = new int[] {1,2,3,4,5,6,7,8,9,10};
            // Console.WriteLine($"11: {Program.BinarySearch(array,11, 0, array.Length)}");
            // Console.WriteLine($"4: {Program.BinarySearch(array,4, 0, array.Length)}");

            // var addOne = Program.AddOne(new int[] { 9,9,9});            
            // foreach(var i in addOne) {
            //     Console.Write(i);
            // }
 
            // Console.WriteLine(Program.LongestConsecutiveCharacter("AABCDDBBBEA"));

            // Console.WriteLine(Program.ReverseWords("The cat jumped over the fence"));

            // Console.WriteLine(HasAllUniqueCharacter("The cat"));

            // var matrix = new int[,] { {1,1,1,1}, {0,1,1,1}, {1,1,0,1}, {1,1,1,1}};

            // ZeroRowColumn(matrix);   
            // for (int i = 0; i < matrix.GetLength(0); i++) {
            //     for (int j = 0; j < matrix.GetLength(1); j++)
            //     {
            //         Console.Write(matrix[i,j] + "\t");
            //     }
            //     Console.WriteLine();
            // }  

            // Console.WriteLine(Compress("aaaaabbfffddd"));   

            // Console.WriteLine(fib(13));    

            Console.WriteLine(fact(4));
        }

        public static bool BinarySearch(int[] arr, int valueToFind, int left, int right) {
            if(left > right){
                return false;
            }
            var mid = (left + right) / 2;
            if(valueToFind > mid) {
                return BinarySearch(arr, valueToFind, mid + 1, right);
            } else if(valueToFind < mid) {
                return BinarySearch(arr, valueToFind, left, mid - 1);
            } else {
                return mid == valueToFind;
            }        
        }

        public static int[] AddOne(int[] arr) {
            var carry = true;
            var result = new int[arr.Length];
            for(var i = arr.Length - 1; i >= 0; i--){
                if(!carry){
                    result[i] = arr[i];
                    continue;
                }
                if(arr[i] == 9){
                    result[i] = 0;
                    carry = true;
                    continue;
                } 
                result[i] = arr[i] + 1;
                carry = false;
            }
            if(carry){
                var expandedArr = new int[result.Length + 1];
                for(var i = 0; i < expandedArr.Length; i++) {
                    if(i == 0) {
                        expandedArr[i] = 1;
                        continue;
                    }
                    expandedArr[i] = result[i - 1];
                }
                return expandedArr;
            }            
            return result;
        }

        public static string LongestConsecutiveCharacter(string str) {            
            var maxChar = str[0];
            var maxCount = 1;
            var currentCount = 1;            
            for(var i = 1; i < str.Length; i++) {
                if(str[i] == str[i - 1]){
                    currentCount++;
                } else {
                    if(currentCount > maxCount){
                        maxChar = str[i-1];
                        maxCount = currentCount;
                        currentCount = 0;
                    }
                }
            }
            return maxChar.ToString() + maxCount.ToString();
        }

        public static string ReverseWords(string str) {
            var words = str.Split(" ");
            var start = 0;
            var end = words.Length - 1;

            while(start <= end) {
                var temp = words[start];
                words[start] = words[end];
                words[end] = temp;
                start++;
                end--; 
            }

            return String.Join(" ", words);
        }        

        public static bool HasAllUniqueCharacter(string str) {            
            var checkList = new HashSet<char>();
            foreach(var letter in str.ToLower()) {
                if(!checkList.Add(letter)){
                    return false;
                }
            }
            return true;
        }

        public static void ZeroRowColumn(int[,] matrix) {
            var coords = new List<int[]>();            
            for(var row = 0; row < matrix.GetLength(0); row++) {
                for(var col = 0; col < matrix.GetLength(1); col++){
                    if(matrix[row,col] == 0){
                        coords.Add(new int[] {row, col});                                        
                    }                    
                }
            }            
            foreach(var coord in coords) {
                for(var x = 0; x < matrix.GetLength(0); x++){
                    matrix[x, coord[1]] = 0;
                }
                for(var y = 0; y < matrix.GetLength(1); y++){
                    matrix[coord[0], y] = 0;
                }
            }
        }

        public static string Compress(string str) {
            if(str.Length == 0)  return "";
            var compressedStr = "";
            var letterCounter = 1;
            for(var i = 1; i < str.Length; i++){
                if(str[i] == str[i - 1]) {
                    letterCounter++;
                    continue;
                }
                var letter = str[i - 1];
                compressedStr += letter.ToString() + letterCounter.ToString();
                letterCounter = 1;
            }
            if(compressedStr.Length < str.Length) {
                return compressedStr;
            }
            return str;
        }

        public static int fib(int num) {
            if(num == 0) return 0;
            if(num == 1) return 1;
            return fib(num - 2) + fib(num-1);
        }
        public static int fact(int num) {
            if(num == 0) return 1;
            if(num == 1) return 1;
            return num * fact(num - 1);
        }
    }
}
