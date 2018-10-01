using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace CloneProject
{
    public class CloneList
    {

        private static void Main()
        {
            Console.WriteLine(DateTime.Now.ToTraceDateTime());
            new CloneList().func2();
            //new Class1().func1();
            Console.ReadKey();
        }
        
        void func1()
        {
            int[] myintArray = new int[] { 10, 20, 30 };
            int[] newintArray = (int[])myintArray.Clone();
            IEnumerable<int> result = from x in myintArray where x > 10 select x;
            var myresult = myintArray.Where(x => x > 10);
            Console.WriteLine("----- original array ---------");
            myintArray.ToList().ForEach(x => Console.Write(x + ","));
            Console.Write("\n----- clone array ---------\n");
            newintArray.ToList().ForEach(x => Console.Write(x + ","));
            
            
        }

        void func2()
        {
            List<Person> lstPerson = new List<Person>();

            lstPerson.Add(new Person() { PersonName = "nk", Surname = "damani" });
            lstPerson[0].personAddress = new PersonAddress() { BuldName = "samkeet", StreetName = "anjanisoc" };
            lstPerson.Add(new Person() { PersonName = "samir", Surname = "damani" });
            lstPerson[1].personAddress = new PersonAddress() { BuldName = "sarvam", StreetName = "vishwamitri" };
           // lstPerson.ForEach(x => Console.WriteLine(x.PersonName + " " + x.Surname ));
            PrintList(lstPerson);
            List<Person> lstPerson1 =  (List<Person>)lstPerson.ToClone();
            //lstPerson1.ForEach(x => Console.WriteLine(x.PersonName + " " + x.Surname));
            PrintList(lstPerson1);
            List<Person> lstPerson2 = new List<Person>(lstPerson1);
            //lstPerson2.ForEach(x => Console.WriteLine(x.PersonName + " " + x.Surname));
            PrintList(lstPerson2);

            lstPerson2.First().PersonName = "Sameeer";
            lstPerson2.First().personAddress.StreetName = "nehru nagar";
            lstPerson2.First().personAddress.BuldName = "3, samkit";


            Console.WriteLine(" ------- after change in 1 st ------------");
            PrintList(lstPerson); PrintList(lstPerson1); PrintList(lstPerson2);


            List<Student> stud1 = new List<Student>();
            stud1.Add(new Student() { id = 1, name = "samir" });
            stud1.Add(new Student() { id = 2, name = "mihir" });
            List<Student> stud2 = stud1.ToClone() as List<Student>;
            stud1.ForEach(x => Console.WriteLine("{0} {1}", x.id, x.name));
            stud2.ForEach(x=>Console.WriteLine("{0} {1}",x.id,x.name));
            Console.WriteLine("\n\n\n");
            stud1.First().id = 7; stud1.First().name = "kamal";
            stud1.ForEach(x => Console.WriteLine("stud 1 {0} {1}", x.id, x.name));
            Console.WriteLine("\n");
            stud2.ForEach(x => Console.WriteLine("stud 2 {0} {1}", x.id, x.name));
            

           // Console.ReadKey();
            
        }

        //we need to use extension method to clone a list object 

        void PrintList(List<Person> lstPerson)
        {
            lstPerson.ForEach(x=>Console.WriteLine("Name : {0} {1}, Address : {2},{3}",x.PersonName,x.Surname,x.personAddress.BuldName,x.personAddress.StreetName));
        }


    }

    class Student : ICloneable
    {
        internal int id;
        internal string name;

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
    