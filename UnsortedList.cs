using System;

namespace DataStructures.UnOrderedList
{
    public class UnsortedList
    {
        private Node head;
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }
      
      
        //correct
        public bool Append(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }

            Node t = head;
            while (t.next != null)
            {
                t = t.next;
            }
            t.next = n;
            return true;
        }
        //correct
        public int Pop()
        {
            if (head == null)
            {
                throw new NullReferenceException("List is Empty");
            }
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            int obj = t.data;
            if (head.next==null)
            {
                head = null;
            }
            p.next = null;
            return obj;
        }
        public int peek(int ind)
        {
            if (head == null)
            {
                return (int)default;
            }
            if (ind == 0)
                return head.data;
            Node t = head;
            while (ind > 0 && t.next != null)
            {
                ind--;
                t = t.next;
            }
            if (ind == 0)
                return t.data;
            return (int)default;
        }
        //correct
        public int peek()
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head, p = head;
            while (t.next != null)
            {
                p = t;
                t = t.next;
            }
            int obj = t.data;
            return obj;
        }
        //correct
        public bool Search(int data)
        {
            if (head == null)
                throw new NullReferenceException("empty List");
            Node t = head;
            while (t != null)
            {
                if (t.data.Equals(data))
                    return true;
                t = t.next;
            }
            return false;
        }
        //correct
        public bool IsEmpty()
        {
            if (head == null)
            return true;
            return false;
        }
        //correct
        public int Size()
        {
            if (head == null)
                return 0;
            Node t = head; int count = 0;
            while (t != null)
            {
                count++;//4
                t = t.next;
            }
            return count;
        }
        //correct
        public bool Add(int data)
        {
            Node n = new Node(data);
            if (head == null)
            {
                head = n;
                return true;
            }
            n.next = head;
            head = n;
            return true;
        }
        //correct
        public override string ToString()
        {
            if (head == null)
            {

                return null;
            }
            Node t = head;
            string s = "";
            while (t != null)
            {
                s = s + t.data + " ";
                t = t.next;
            }
            return s;
        }
        //correct
        public int Index(int data)
        {
            int count = -1;
            if (head == null)
                return -1;
            Node t = head;
            while (t != null)
            {
                count++;
                if (t.data.Equals(data))
                    return count;
                t = t.next;

            }
            return -1;
        }
        public bool Insert(int ind, int data)// 2 , 75
        {
            Node n = new Node(data);
            if (ind == 0)
            {
                n.next = head;
                head = n;
                return true;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)// 2 
            {
                ind--;//0
                pre = t;// 
                t = t.next;
            }
            if (ind == 0)
            {
                pre.next = n;
                n.next = t;
                return true;
            }
            throw new NullReferenceException("index is not in range");
        }
        //correct
        public bool Remove(int input)// 30
        {
            if (head == null)
                return false;
            if (head.next == null)
                head = null;
            Node t = head, pre = null;
            while (t != null)
            {
                if (t.data==input)// input =30
                {
                    pre.next = t.next;
                    return true;
                }
                pre = t;
                t = t.next;
            }
            return false;
        }
        public int Pop(int ind)
        {
            int obj;
            if (ind == 0)
            {
                obj = head.data;
                head = head.next;
                return obj;
            }
            Node t = head, pre = null;
            while (ind > 0 && t != null)
            {
                ind--;
                pre = t;
                t = t.next;
            }


            if (ind == 0)
            {
                pre.next = t.next;
                obj = t.data;
                return obj;
            }
            throw new NullReferenceException("index is not range");


        }
        public int[] intoArray()
        {
            int size = Size();
            int[] array = new int[size];
            for (int i = 0; i < size; i++)
            {
                array[i] = peek(i);
            }
            return array;
        }
    }
}