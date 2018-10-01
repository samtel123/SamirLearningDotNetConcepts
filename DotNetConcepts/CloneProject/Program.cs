using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CloneProject
{
    class Program
    {
        static void Main(string[] args)
        {            
            Person p1 = new Person() { PersonName = "Mehul", Surname = "Shah"};
            p1.personAddress = new PersonAddress() { BuldName = "samkeet", StreetName = "anjani society" };
            Person p2 = (Person)p1.Clone();
            Console.WriteLine("before Person p1:{0} {1} {2} and p2:{3} {4} {5}", p1.PersonName,p1.Surname,p1.personAddress.BuldName, p2.PersonName,p2.Surname,p2.personAddress.BuldName);
            p1.PersonName = "samir"; p1.Surname = "damani"; p1.personAddress.BuldName = "sarvam heights"; p1.personAddress.StreetName = "aminpark";
            Console.WriteLine("after Person p1:{0} {1} {2} and p2:{3} {4} {5}", p1.PersonName, p1.Surname, p1.personAddress.BuldName, p2.PersonName, p2.Surname, p2.personAddress.BuldName);
            Console.ReadKey();
        }
    }

    public class Person : ICloneable
    {
        public string PersonName { get; set; }
        public string Surname { get; set; }
        public PersonAddress personAddress { get; set; }

        public Person()
        {
            
        }
        public Person(Person p)
        {
            this.PersonName = p.PersonName;
            this.Surname = p.Surname;
            this.personAddress = (PersonAddress)p.personAddress.Clone();
        }
        // deep clone 
        public object Clone()
        {
          //  return (object)new Person(this);
            //return (object)this.MemberwiseClone();
            Person p = (Person)this.MemberwiseClone();
            p.personAddress = (PersonAddress)this.personAddress.Clone();
            return p;

        }
    }

    public class PersonAddress : ICloneable
    {
        public string BuldName;
        public string StreetName;

        public PersonAddress()
        {
        }
        public PersonAddress(PersonAddress pa)
        {
            this.BuldName = pa.BuldName;
            this.StreetName = pa.StreetName;
        }

        public object Clone()
        {            
           // return (object)new PersonAddress(this);
            return (object)this.MemberwiseClone();
        }
    }
}
