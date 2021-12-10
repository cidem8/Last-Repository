using Entities.Concrete;
using System;

namespace WorkSpace
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string message = "WorkSpace!";
            Console.WriteLine(message);
            People people = new People();

            Person person = new Person();

            
            Console.ReadLine();
        }

    
    }
    public class People
    {

        //public string name = "Çiğdem";
        //public string surname = "ay";
        //public int birthYear = 1988;
        //public long TCNumber = 1234567890;


        public string Name { get; set; }
        public string Surname { get; set; }
        public int BirthDate { get; set; }
        public long TcNumber { get; set; }



    }
}
