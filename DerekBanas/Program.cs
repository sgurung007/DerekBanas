using DerekBanas.derekInterface;
using DerekBanas.derekPolymorphism;
using System;
using System.Collections;
using System.Collections.Generic;

namespace DerekBanas
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes = {new Circle(5),
            new Rectangle(4,5)};

            foreach(Shape s in shapes)
            {
                s.GetInfo();
                Console.WriteLine("{0} Area : {1:f2}",
                    s.Name, s.Area());

                Circle testCirc = s as Circle;
                if (testCirc == null)
                {
                    Console.WriteLine("this is not circle");
                }

                if(s is Circle)
                {
                    Console.WriteLine("this isn't a Rectangle");
                }
            }

            Vehicle buick = new Vehicle("Buick",
                4, 160);

            if(buick is IDrivable)
            {
                buick.Move();
                buick.Stop();
            }
            else
            {
                Console.WriteLine($"The {0} can't be driver",
                    buick.Brand);
            }

            IElectronicDevice TV = TVRemote.GetDevice();

            PowerButton powBut = new PowerButton(TV);

            powBut.Execute();
            powBut.Undo();

            Console.WriteLine("*************************************************");

            ArrayList aList = new ArrayList();
            aList.Add("Bob");
            aList.Add(40);

            Console.WriteLine(aList.Count);

            Console.WriteLine(aList.Capacity);
            ArrayList aList2 = new ArrayList();
            aList2.AddRange(new Object[] { "mike",
            "Sally","Egg"});

            foreach(Object obj in aList2)
            {
                Console.WriteLine(obj);
            }

            aList.AddRange(aList2);

            foreach(Object obj in aList)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine("*************************");
            aList2.Sort();
            aList2.Reverse();

            foreach(Object obj in aList2)
            {
                Console.WriteLine(obj);
            }

            aList2.Insert(1, "suraj");
            Console.WriteLine("*************************");
            foreach (Object obj in aList2)
            {
                Console.WriteLine(obj);
            }
            ArrayList range = aList2.GetRange(0, 2);
            Console.WriteLine("*************************");
            foreach (Object obj in range)
            {
                Console.WriteLine(obj);
            }

            Console.WriteLine(range.IndexOf("suraj"));
            string[] customers = { "Bob", "Sally", "Sue" };
            ArrayList custArrayList = new ArrayList();

            custArrayList.AddRange(customers);

            foreach(string s in custArrayList)
            {
                Console.WriteLine(s);
            }


            //Dictionary
            Dictionary<string, string> superheroes =
                new Dictionary<string, string>();

            superheroes.Add("pitam bahadur gurung","surperman");
            superheroes.Add("laxmi prajapati", "wonder women");
            superheroes.Add("suraj gurung", "gas man");

            Console.WriteLine("***********************");

            Console.WriteLine(" Count: {0}", superheroes.Count);

            Console.WriteLine("pitam bahadur gurung: {0}",
                superheroes.ContainsKey("pitam bahadur gurung"));

            foreach(KeyValuePair<string,string> item in superheroes)
            {
                Console.WriteLine("{0}:{1}",
                    item.Key,
                    item.Value);
            }

            //Queue: first in firs out
            Queue queue = new Queue();

            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            queue.Dequeue();

            foreach(object o in queue)
            {
                Console.WriteLine(o);
            }

            object[] numArray = queue.ToArray();

            foreach (object o in numArray)
            {
                Console.WriteLine(o);
            }





        }
    }
}
