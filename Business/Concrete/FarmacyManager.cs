using Business.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class FarmacyManager : ISupplierService
    {
        private IApplicantService _applicantService;

        public FarmacyManager(IApplicantService applicantService)
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {

            if (_applicantService.CheckPerson(person) == true)
            {
                Console.WriteLine(person.FirstName + " için maske verildi.");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske verilemedi!");
            }
        }

    }
}
