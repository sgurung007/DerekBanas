using DerekBanas.derekInterface;
using DerekBanas.derekPolymorphism;
using System;
using System.Collections;

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

        }
    }
}
