using System;
using System.Collections.Generic;

namespace Classobject
{
    class Program
    //class is a keyword
    // program is a class name
    {
        string name;
        string email;
        int age;
        string fromLocation;
        string toLocation;
        int price;
    

        static void Main(string[] args)
        {
            List<Program> p = new List<Program>();

            /*string name="Anu";
            string email="Anu@gmail.com";
            int age=23;
            string fromLocation="KNR";
            string toLocation="HYD";
            int price=30000;
            Console.WriteLine("{0},{1},{2},{3},{4},{5}", name, email, age, fromLocation, toLocation,price);*/
            Program prog = new Program();
            prog.name = "Dotnet";
            prog.email = "dotnet@gmail.com";
            prog.age = 25;
            prog.fromLocation = "Hyderabad";
            prog.toLocation = "Karimangar";
            prog.price = 20000;
            p.Add(prog);
        }

           
            

            /*Console.WriteLine("name" + "email" + "age" + "fromLocation" + "toLocation" + "price");*/

            /*string[] arr = new string[] { "name", "email", "age" , "fromLocation", "toLocation", "price" };

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("prog: " + arr[i]);
            }*/

        }
        /*Program prog = new Program();
            prog.name = "Dotnet";
            prog.email = "dotnet@gmail.com";
            prog.age = 25;
            prog.fromLocation = "Hyderabad";
            prog.toLocation = "Karimangar";
            prog.price = 20000;*/


        }
    

