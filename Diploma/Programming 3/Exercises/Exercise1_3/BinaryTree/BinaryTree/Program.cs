using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            BinaryTree btree = new BinaryTree();
            btree.Root = new Node(1);
            btree.Root.Left = new Node(2);
            btree.Root.Right = new Node(3);
            btree.Root.Left.Left = new Node(4);
            btree.Root.Right.Right = new Node(5);
            btree.Root.Left.Left.Right = new Node(6);
            btree.Root.Right.Right.Right = new Node(7);
            btree.Root.Right.Right.Right.Right = new Node(8);

            // create a new cvalue for each Node
            // add data to each Node
            // display value
            btree.Root.Left.Value = new object();
            btree.Root.Left.Value = 20;
            Console.WriteLine("Root Left-" + btree.Root.Left.Value);

            btree.Root.Right.Value = new object();
            btree.Root.Right.Value = 30;
            Console.WriteLine("Root Right-" + btree.Root.Right.Value);
        }
    }
}
