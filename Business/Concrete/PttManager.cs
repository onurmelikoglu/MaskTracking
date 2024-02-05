using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    {

        private IApplicantService applicantService; //constructor newlenince önce çalışır

        public PttManager(IApplicantService applicantService)
        {
            this.applicantService = applicantService;
        }
        public void GiveMask(Person person)
        {
            if (applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + " için maske verildi");
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ");
            }
        }
    }
}