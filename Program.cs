using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinarySearchTree binarySearchTree = new BinarySearchTree();

           binarySearchTree.Add(20);
            binarySearchTree.Add(7);
            binarySearchTree.Add(6);
            binarySearchTree.Add(9);
            binarySearchTree.Add(3);
            binarySearchTree.Add(4);
            binarySearchTree.Add(8);
            binarySearchTree.Find(9);


        }

    }
}
