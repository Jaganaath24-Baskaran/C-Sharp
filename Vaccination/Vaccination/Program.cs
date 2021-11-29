using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vaccination
{
    class CovidVaccination
    {
        private static List<Beneficiary> UserDetails = new List<Beneficiary>();
        public static void Main(string[] args)
        {
            string choice;
            CovidVaccination covidObj = new CovidVaccination();//object
            do
            {
                Console.WriteLine("Application For Vaccination Drive");
                Console.WriteLine("1.Beneficiary Registration \n2.Vaccination \n3.Exit");
                Console.WriteLine("Choose the option : ");
                var option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        covidObj.BeneficiaryRegistration();//method/function

                        break;
                    case 2:
                        covidObj.Vaccin();

                        break;
                    case 3:
                        Environment.Exit(-1);
                        break;

                }
                Console.WriteLine("Type 'yes' to continue or 'no' to exit. ");
                choice = Console.ReadLine().ToLower();
            } while (choice == "yes");

        }
        public void BeneficiaryRegistration()//method creating
        {
            Console.WriteLine("Enter Your Name :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter Your Phone Number:");
            long PhoneNo = long.Parse(Console.ReadLine());
            Console.WriteLine("Enter Your City:");
            string City = Console.ReadLine();
            Console.WriteLine("Enter Your Age:");
            int Age = int.Parse(Console.ReadLine());
            Console.WriteLine("1.Male \n2.Female \n3.Transgender");
            Gender Gender = (Gender)int.Parse(Console.ReadLine());
            Beneficiary add = new Beneficiary(Name, PhoneNo, City, Age, Gender);//object create
            UserDetails.Add(add);//add object in user list
            Console.WriteLine("Registration Successfull.");
            Console.WriteLine("Your Registration ID: " + add.RegisterNo);
        }
        public void Vaccin()
        {
            string choice;
            Console.Write("Enter the Registratin ID: ");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine();
            foreach (Beneficiary data in UserDetails)
            {
                if (id == data.RegisterNo)
                {
                    do
                    {
                        Console.WriteLine("1.Take Vaccination \n2.Vaccination History \n3.Next Due Date \n4.Exit");
                        Console.Write("Choose your option : ");
                        int option = int.Parse(Console.ReadLine());
                        switch (option)
                        {
                            case 1:
                                Console.WriteLine("1.Covid-Shield \n2.Covaxin \n3.sputnic");
                                Console.WriteLine("Select Your Dose(1-3): ");
                                VaccinType vacType = (VaccinType)int.Parse(Console.ReadLine());

                                Vaccination user = new Vaccination(vacType, DateTime.Now);
                                if (data.VaccineDetails == null)
                                {

                                    data.VaccineDetails = new List<Vaccination>();
                                }
                                data.VaccineDetails.Add(user);
                                Console.WriteLine("Successfully vaccinated!...");
                                break;

                            case 2:
                                foreach (Beneficiary history in UserDetails)
                                {
                                    if (history.VaccineDetails != null)
                                    {
                                        history.VaccinDetails(id);
                                    }
                                }
                                break;

                            case 3:
                                foreach (Beneficiary Duedate in UserDetails)
                                {
                                    Duedate.VaccinDueDate(id);
                                }
                                break;

                            case 4:
                                Environment.Exit(-1);
                                break;

                            default:
                                Console.WriteLine("Please Choose Correct option.....!");
                                break;
                        }
                        Console.WriteLine("Type 'yes' to continue or 'no' to exit.");
                        choice = Console.ReadLine().ToLower();

                    } while (choice == "yes");

                }


            }


        }
    }
}