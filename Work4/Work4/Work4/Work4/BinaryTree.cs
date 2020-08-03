using System;
using System.Collections.Generic;
using System.Text;

namespace Work4
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public bool insert(int value)
        {
            Node before = null, after = this.Root;

            while (after != null)
            {
                before = after;
                if (value < after.Data)
                    after = after.LeftNode;
                else if (value > after.Data)
                    after = after.RightNode;
                else
                {
                    return false;
                }
            }

            Node newNode = new Node();
            newNode.Data = value;

            if (this.Root == null)
                this.Root = newNode;
            else
            {
                if (value < before.Data)
                    before.LeftNode = newNode;
                else
                    before.RightNode = newNode;
            }

            return true;
        }

        public void preOrder(Node parent)
        {
            if (parent != null)
            {
                Console.Write(parent.Data + " ");
                preOrder(parent.LeftNode);
                preOrder(parent.RightNode);
            }
        }

        public void inOrder(Node parent)
        {
            if (parent != null)
            {
                inOrder(parent.LeftNode);
                Console.Write(parent.Data + " ");
                inOrder(parent.RightNode);
            }
        }

        public void postOrder(Node parent)
        {
            if (parent != null)
            {
                postOrder(parent.LeftNode);
                postOrder(parent.RightNode);
                Console.Write(parent.Data + " ");
            }
        }
    }

}
