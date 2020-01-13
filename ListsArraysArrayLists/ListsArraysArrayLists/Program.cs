using System;
using System.Collections.Generic;

namespace ListsArraysArrayLists
{
    class Program
    {
        static void Main(string[] args)
        {
            //Lists
            //Lists are limited to just one type(int, string, double,etc)
            List<int> list = new List<int> { 2,4,6,8,10,12,14,16,18,20};
            list.Add(1); //adds 1 to list { 2,4,6,8,10,12,14,16,18,20,1}
            list.Add(3); // adds 3 to list { 2,4,6,8,10,12,14,16,18,20,1,3}
            list.Sort();//sorts list { 1,2,3,4,6,8,10,12,14,16,18,20}
            list.Reverse();//reverses order of list {20,18,16,14,12,10,8,6,4,3,2,1}
            list.Remove(4);//removes 4 from list {20,18,16,14,12,10,8,6,3,2,1}
            list.RemoveRange(0, 2); // removes 2 numbers starting from index 0 {16,14,12,10,8,6,4,3,2,1}
            /*foreach (int li in list)
            {
                Console.WriteLine(li);
            }*/
            Console.WriteLine(list.Contains(5)); //returns true if list contains 5 else returns false

            int index = list.FindIndex(i => i == 6); //returns index of 6 which is 5
            Console.WriteLine(index); //use list[5] to display value at index 5 of list
            list.RemoveAt(0);//removes value at index 0 which is 16

            list.ForEach(k => Console.WriteLine(k));


            //ArrayLists
            //ArrayLists can take multiple types
            Console.WriteLine();
            System.Collections.ArrayList arrayList = new System.Collections.ArrayList();
            arrayList.Add(0);//adding number 0 to arrayList
            arrayList.Add("Coding is real fun");
            arrayList.Add(new Number { num = 9 });

            foreach (object obj in arrayList)
            {
                Console.WriteLine(obj);
            }
        }

        public class Number
        {
            public int num { set; get; }

            public override string ToString()
            {
                return num.ToString();
            }
        }
    }
}
