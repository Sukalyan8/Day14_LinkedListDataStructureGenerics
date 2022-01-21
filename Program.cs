using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //UC1_LinkedList number = new UC1_LinkedList();
            //number.Add(56);
            //number.Add(30);
            //number.Add(70);

            //UC2_LinkedList number = new UC2_LinkedList();
            //number.AddFirst(56);
            //number.AddFirst(30);
            //number.AddFirst(70);

            //UC3_LinkedList number = new UC3_LinkedList();
            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);

            //UC4_LinkedList number = new UC4_LinkedList();
            ////LinkedList<int> list = new LinkedList<int>();
            ////list.AddFirst(1);
            ////list.AddAfter(0,20);

            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);
            //number.AddAfter(2, 40);
            //int a = number.Length();
            //Console.WriteLine(a);

            //UC5_LinkedList number = new UC5_LinkedList();
            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);
            //number.AddAfter(2, 40);
            //int a = number.Length();
            //Console.WriteLine(a);
            //number.Pop();

            //UC6_LinkedList number = new UC6_LinkedList();
            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);
            //number.AddAfter(2, 40);
            //int a = number.Length();
            //Console.WriteLine(a);
            //number.Pop();
            //number.PopLast();

            //UC7_LinkedList number = new UC7_LinkedList();
            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);
            //number.AddAfter(2, 40);
            //number.Find(30);

            //UC8_LinkedList number = new UC8_LinkedList();
            //number.AddLast(56);
            //number.AddLast(30);
            //number.AddLast(70);
            //number.InsertAfter(30, 40);

            UC9_LinkedList number = new UC9_LinkedList();
            number.AddLast(56);
            number.AddLast(30);
            number.AddLast(70);
            number.InsertAfter(30, 40);
            number.remove(70);

        }
    }
}