using System;
using Xunit;
using System.Linq;
using System.Collections.Generic;

namespace cs_noodlins.tests
{
    public class BinarySearchTreeTests{
        private readonly BinarySearchTree<int> tree;                

        public static IEnumerable<object[]> testData = new List<object[]> {
            new object[] { new int[] {5,9,3,7,6,10,32,2} },
            new object[] { new int[] {-40,-60,-23,49,65,100,-34,2,0,-1,40} }
        };

        public BinarySearchTreeTests() {
            tree = new BinarySearchTree<int>(8);
        }        

        [Theory]
        [MemberData(nameof(testData))]
        public void BinarySearchTree_Find(int[] values) {
            foreach(var value in values){
                tree.Insert(value);
            }
            foreach(var value in values) {
                Assert.True(tree.Find(value));
            }
            Assert.False(tree.Find(101));
            Assert.False(tree.Find(4));
        }

        [Theory]
        [MemberData(nameof(testData))]
        public void BinarySearchTree_FindMinimumValue(int[] values) {
            foreach(var value in values) {
                tree.Insert(value);
            }
            Assert.Equal(values.Min(), tree.FindMinimumValue());
        }

        [Theory]
        [MemberData(nameof(testData))]
        public void BinarySearchTree_FindMaximumValue(int[] values) {
            foreach(var value in values) {
                tree.Insert(value);
            }
            Assert.Equal(values.Max(), tree.FindMaximumValue());
        }
    }
}