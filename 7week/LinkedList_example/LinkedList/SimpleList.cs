using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
   class Node //노드를 활용해서 Linked List를 구현하는 클래스
    {
        public int Data; //data가 담겨있는 곳
        public Node Next; //Next point에 대한 참조위치다

        public Node(int data)
        {
            Data = data;
            Next = null;
        }

        public Node(int data, SimpleList list)
        {
            Data = data;
            Next = null;
            list.Append(this); //this를 통해서 내가 생성될떄 바로 들어가지도록 함.
            //this가 
        }


    }
    class SimpleList
    {
        private Node head = null; //딱히 권한에 대한 것을 안적었기에 private이다.
        public string Print()
        {
            if (head == null) return "Empty\r\n";
            string st = "";
            for (Node n = head; n != null; n = n.Next)
            {
                st += n.Data.ToString() + "\r\n";
            }
            st += "-END-\r\n";
            return st;
        }
        public void Add_at_header(Node node)
        {
            node.Next = head;
            head = node;
        }

        public void Clear()
        {
            head = null;
        }

        public void Append(Node node)
        {
            if (head == null)
            {
                node.Next = null;
                head = node;
            }
            else
            {
                Node lastNode = GetLastNode();
                lastNode.Next = node;
                node.Next = null;
            }
        }

        private Node GetLastNode()
        {
            if (head == null)
                return null;
            else
            {
                Node node = head;
                while (node.Next != null)
                {
                    node = node.Next;
                }
                return node;
            }
        }

        public void Remove(Node n)
        {
            for (Node before_node = head; before_node != null; before_node = before_node.Next)
            {
                if (before_node.Next == n) before_node.Next = n.Next;
            }
            n.Next = null;
        }
        public Node FindNodeOfData(int data)
        {
            for (Node n = head; n != null; n = n.Next)
            {
                if (n.Data == data) return n;
            }
            return null;
        }

        //public SimpleList Reverse()
        //{

        //}

    }
}
