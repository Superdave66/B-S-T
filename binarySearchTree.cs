using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    class BinarySearchTree
    {
        public Node Root { get; set; }
        public bool Add(int value)
        {
            Node before = null, after = this.Root;
            while(after != null)
            {
                before = after;
                if (value < after.Data)
                {
                    after = after.leftNode;
                }
                else if (value > after.Data)
                {
                    after = after.RightNode;
                }

                else
                {
                    return false;
                }

            }
            Node newNode = new Node();
            newNode.Data = value;
                if (this.Root== null)
            {
                this.Root = newNode;
            }
            else
            {
                if (value < before.Data)
                {
                    before.leftNode = newNode;
                }
                else
                {
                    before.RightNode = newNode;

                }
            }
            return true;
        }
        public Node Find (int value )
        {
            return this.Find(value);
            
        }




    }
}
