using Business.Concrete;
using Entities.Concrete;

namespace WorkPlace
{
    public class Program
    {
        static void Main(string[] args)
        {
            Person person1 = new Person();
            person1.FirstName = "Engin";
            person1.LastName = "Demiroğ";
            person1.DateOfBirthYear = 1985;
            person1.NationalIdentity = 123;

            Person person2 = new Person();
            person2.FirstName = "Hasan";
            person2.LastName = "Demiroğ";
            person2.DateOfBirthYear = 1996;
            person2.NationalIdentity = 123;


            PttManager pttManager = new PttManager(new PersonManager());
            pttManager.GiveMask(person1 );

            FarmacyManager farmacyManager = new FarmacyManager(new PersonManager());
            farmacyManager.GiveMask(person2);



            Console.ReadLine(); 
            Console.ReadLine(); 


        }
    }
}
