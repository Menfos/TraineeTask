using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TraineeTasks
{
    class Program
    {
        static void Main(string[] args)
        {
            MyLinkedList<int> myList = new MyLinkedList<int>();
            myList.AddFirst(0);
            myList.AddFirst(1);
            myList.AddFirst(2);
            myList.AddFirst(3);
            myList.AddFirst(23);

            myList.PrintAllValues();

            myList.Reverse();

            myList.PrintAllValues();
            Console.WriteLine("+++++++++++++++++++++++++++");

            Rectangle rect1 = new Rectangle(new Point(0,0), new Point(3,2));
            Rectangle rect2 = new Rectangle(new Point(3,1), new Point(5,2));

            Console.WriteLine(rect1.IntersectWith(rect2));

            Rectangle OverlapedRect = rect1.OverlapedArea(rect2);
            Console.WriteLine(OverlapedRect.GetArea);


            Console.ReadLine();
        }
    }
}
