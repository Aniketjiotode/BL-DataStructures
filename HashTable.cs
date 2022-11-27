using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DateStructures
{
    class HashTable<K, V>
    {

        // 11  33  44 45 67 87  34 54 87 98 43
        public static List<KeyValuePair<K,V>>[] FillHashtable(int[] dataArray)

        {
            List<KeyValuePair<K, V>>[] slot = new List<KeyValuePair<K,V>>[11];//
            
            //creating Objects of Ordered List
            for (int i = 0; i < slot.Length; i++)
            {
                slot[i] = new List<int>();
            }
            //Filling the Objects
            for (int i = 0; i < dataArray.Length; i++)//4
            {
                int Index = dataArray[i] % 11;// 44%11=0
                slot[Index].Add(dataArray[i]);
            }
            return slot;
        }

        public static bool search(List<int>[] slot, int number)//55
        {
            int Index = number % 11;// 55%11=0
            return slot[Index].Contains(number);
        }
        public static void DisplayHashTable(List<int>[] slot)
        {
            Console.WriteLine("Elements at each index.....");
            for (int i = 0; i < slot.Length; i++)
            {
                Console.Write(i + " --> " + slot[i] + "\n");
            }

        }
        public static int[] FileToArray(String file)
        {
            string[] array = file.Split(" ");
            int number;
            List<int> list = new List<int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (int.TryParse(array[i], out number))
                {
                    list.Append(number);
                }
            }
            int[] result = new int[list.Size()];
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = list.peek(i);
            }
            return result;

        }
    }
}
