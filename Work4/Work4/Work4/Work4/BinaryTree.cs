using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Work4
{
    class BinaryTree
    {
        public Node Root { get; set; }

        public bool insert(int value)
        {
            Node previous = null;
            Node next = this.Root;

            while (next != null)
            {
                previous = next;

                if (value < next.Data)
                {
                    next = next.LeftNode;
                }
                else if (value > next.Data)
                {
                    next = next.RightNode;
                }
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
                if (value < previous.Data)
                {
                    previous.LeftNode = newNode;
                }
                else
                {
                    previous.RightNode = newNode;
                }
            }

            return true;
        }

        public String preOrder(Node node)
        {

            ArrayList list = new ArrayList();

            preOrderAux(list, node);

            String finalList = "[ ";


            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    finalList += list[i] + ", ";
                }
                else
                {
                    finalList += list[i];
                }
            }

            finalList += " ]";

            return finalList;

        }

        private ArrayList preOrderAux(ArrayList list, Node node)
        {
            if (node != null)
            {
                list.Add(node.Data);
                preOrderAux(list, node.LeftNode);
                preOrderAux(list, node.RightNode);
            }

            return list;

        }

        public String inOrder(Node node)
        {

            ArrayList list = new ArrayList();

            inOrderAux(list, node);

            String finalList = "[ ";

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    finalList += list[i] + ", ";
                }
                else
                {
                    finalList += list[i];
                }
            }

            finalList += " ]";

            return finalList;

        }

        private ArrayList inOrderAux(ArrayList list, Node node)
        {
            if (node != null)
            {
                inOrderAux(list, node.LeftNode);
                list.Add(node.Data);
                inOrderAux(list, node.RightNode);
            }

            return list;

        }

        public String postOrder(Node node)
        {

            ArrayList list = new ArrayList();

            postOrderAux(list, node);

            String finalList = "[ ";

            for (int i = 0; i < list.Count; i++)
            {
                if (i != list.Count - 1)
                {
                    finalList += list[i] + ", ";
                }
                else
                {
                    finalList += list[i];
                }
            }

            finalList += " ]";

            return finalList;

        }

        private ArrayList postOrderAux(ArrayList list, Node node)
        {
            if (node != null)
            {
                inOrderAux(list, node.LeftNode);
                inOrderAux(list, node.RightNode);
                list.Add(node.Data);
            }

            return list;

        }

    }

}
