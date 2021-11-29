using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    public enum Gender
    {
        male = 1, female, transgender
    }
    class Beneficiary
    {
        private static int autoIncreament = 100; //field
        public int RegisterNo { get; set; }//property
        public string Name { get; set; }
        public long PhoneNo { get; set; }
        public string City { get; set; }
        public int Age { get; set; }
        public Gender Gender { get; set; }
        public List<Vaccination> VaccineDetails
        {
            get; set;
        }
        public Beneficiary(string name, long phoneNo, string city, int age, Gender gender)//constructor
        {
            this.Name = name;
            this.PhoneNo = phoneNo;
            this.City = city;
            this.Age = age;
            this.Gender = gender;
            this.RegisterNo = autoIncreament++;

        }
        public void VaccinDetails(int regNo)
        {
            if (this.RegisterNo == regNo)
            {
                if (VaccineDetails != null)
                {
                    foreach (Vaccination date in VaccineDetails)
                    {
                        Console.WriteLine($"Your Vaccinated dose  : {date.Vaccinationtype}");
                        Console.WriteLine($"Vaccinated Date: {date.VaccinatedDate}");
                    }
                }
            }

        }
        public void VaccinDueDate(int regNo)
        {
            if (this.RegisterNo == regNo)
            {
                if (VaccineDetails != null)
                {
                    foreach (Vaccination date in VaccineDetails)
                    {
                        if (VaccineDetails.Count == 1)
                        {
                            Console.WriteLine("Your Vaccinated dose : " + date.Vaccinationtype);
                            Console.WriteLine("Vaccinated Date: " + date.VaccinatedDate.AddDays(60));

                        }
                        else if (VaccineDetails.Count == 2)
                        {
                            Console.WriteLine("You have completed the vaccination course. Thanks for your participation in the vaccination drive.");
                            break;
                        }


                    }
                }
            }

        }
    }
}
