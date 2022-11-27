using System;

namespace DataStructures
{
    class Queue<T>
    {
        int capacity;
        T[] obj;
        int front = -1, rear = -1;
        public Queue(int capacity)
        {
            this.capacity = capacity;
            obj = new T[capacity];
        }
        public bool Enqueue(T data)// 77
        {
            if (rear == capacity - 1)// 4  5-1=4   
            {
                Console.WriteLine("Que is Full");
                return false;
            }
            if (rear == -1)// 1
                front++;// 0
            obj[++rear] = data;// 4
            return true;
        }
        public T Dequeue()
        {
            if (front == -1)// 0
            {
                Console.WriteLine("que is empty");
                return default(T);
            }
            T ob = obj[front++];//20    front =5
            if (front > rear) // 5>4
                front = rear = -1;
            return ob;
        }
        public bool IsEmpty()
        {
            if (rear == -1)
                return true;
            else return false;
        }
        public int Size()
        {
            if (rear == -1)
            {
                return 0;
            }
            return rear - front + 1;
        }
        public override string ToString()
        {
            String s = "";
            for (int i = front; i <= rear && front != -1; i++)
            {
                s = s + obj[i] + " ";

            }
            return s;
        }
    }
}