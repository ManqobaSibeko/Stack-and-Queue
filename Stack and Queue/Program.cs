using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Stack_and_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue myQue = new Queue();
            Console.Write("What is your:    ");
            string name = Console.ReadLine();
            myQue.Enqueue("ziya");
            myQue.Enqueue("Find");
            myQue.Enqueue(name);
            


            int num = 1;


            while(num == 0 )
            {
                foreach (var item in myQue)
                {
                    Console.WriteLine(item);
                }
            }

            int q = myQue.Count - 1;

            foreach ( var item in myQue)
            {
                Console.WriteLine(item);
            }

           

            while(myQue.Count > q)
            {
                Console.Write("do you want to add yes/no :  ");
                string mill = Console.ReadLine();
                myQue.Dequeue();

                if (mill == "yes")
                {
                    foreach (var item in myQue)
                    {
                        Console.WriteLine(item);
                    }
                }
            }

            Console.WriteLine(" ");


            while (myQue.Count < 5)
            {

                Console.Write("add : ");
                string add = Console.ReadLine();
                myQue.Enqueue(add);
            }
            Console.WriteLine("");

            foreach (var item in myQue)
            {
                Console.WriteLine(item);
            }
                
            /*Console.Write("do you want to add yes/no");
            string mille = Console.ReadLine();
            myQue.Dequeue();

            if (mille == "yes")
            {
                foreach (var item in myQue)
                {
                    Console.WriteLine(item);
                }
            }*/
            Console.ReadLine();

        }
    }
}
