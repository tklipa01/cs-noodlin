using System;
using Xunit;

namespace cs_noodlins {
    public class BinaryTreeTests {
        private readonly BinaryTree<int> symmetricTree;       
        private readonly BinaryTree<int> non_symmetricTree;       

        public BinaryTreeTests() {
            symmetricTree = new BinaryTree<int>(5);
            symmetricTree.InsertLeft(1);
            symmetricTree.InsertRight(1);
            symmetricTree.Left.InsertLeft(2);
            symmetricTree.Left.InsertRight(3);
            symmetricTree.Right.InsertLeft(3);
            symmetricTree.Right.InsertRight(2);


            non_symmetricTree = new BinaryTree<int>(5);
            symmetricTree.InsertLeft(1);
            symmetricTree.InsertRight(1);
            symmetricTree.Left.InsertLeft(2);
            symmetricTree.Left.InsertLeft(3);
            symmetricTree.Right.InsertLeft(5);
            symmetricTree.Right.InsertRight(2);
        }   

        [Fact]
        public void BinaryTreeIsSymmetric() {
            // Assert.True(symmetricTree.IsSymmetric());
            // Assert.False(non_symmetricTree.IsSymmetric());
        }
    }
}