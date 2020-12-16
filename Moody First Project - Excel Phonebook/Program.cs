using System;
using System.Collections;
using System.Collections.Generic;
using Moody_First_Project___Excel_Phonebook;

namespace Moody_First_Project_Excel_Phonebook
{
    public class Program
    {

        
        static void Main(string[] args)
        {
            Console.WriteLine("Please choose the operation");
            Console.WriteLine("1) View the list");
            Console.WriteLine("2) Insert new Person");
            Console.WriteLine("3) Edit Person");
            Console.WriteLine("4) Delete Person");
            Console.WriteLine("5) Exit");


            Person person = new Person("Beyzanur"); 
            Person person1 = new Person("Enes");
            Person person2 = new Person("Saban");

            List<String> Names = new List<String>();
            Names.Add("Beyza");
            Names.Add("Elif");
            Names.Add("Saban");

            foreach (var name in Names)
            {
                Console.WriteLine(name);
            }
        }
    }
}

    
