using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class Students
    {
        string FirstName, LastName, Sex, CountryOfBirth;
        int StudentNumber, YearOfBirth;

        public Students(int studentNumber = 0  , string firstName = "", string lastName = "", string sex = "", string countryOfBirth = "", int yearOfBirth = 0)
        {
            StudentNumber = studentNumber;
            FirstName = firstName.ToUpper();
            LastName = lastName.ToUpper();
            Sex = sex.ToUpper();
            CountryOfBirth = countryOfBirth.ToUpper();
            YearOfBirth = yearOfBirth;
        }

        public bool SearchByNumber(int studentNumber)
        {
            if (studentNumber == StudentNumber)
                return true;
            else
                return false;
        }

        public bool SearchByYear(int yearOfBirth)
        {
            if (yearOfBirth == YearOfBirth)
                return true;
            else
                return false;
        }

        public void Edit(ChangedType changeType, object item)
        {
            switch (changeType)
            {
                case ChangedType.LastName:
                    LastName = item.ToString();
                    break;


                case ChangedType.CountryOfBirth:
                    CountryOfBirth = item.ToString();
                    break;

                case ChangedType.FirstName:
                    FirstName = item.ToString();
                    break;

                case ChangedType.StudentNumber:
                    StudentNumber = Convert.ToInt32(item);
                    break;

                case ChangedType.Sex:
                    Sex = item.ToString();
                    break;

                case ChangedType.YearOfBirth:
                    YearOfBirth = Convert.ToInt32(item);
                    break;

            }

        }

        public override string ToString()
        {
            return "________________________________________________ \n" +
                   "\n Student Number    : " + StudentNumber +
                   "\n FirstName    : " + FirstName +
                   "\n LastName   : " + LastName +
                   "\n Sex : " + Sex +
                   "\n Country  : " + CountryOfBirth +
                   "\n Year     : " + YearOfBirth +
                   "\n________________________________________________ \n";
        }

        public int GetStudentNumber()
        {
            return StudentNumber;
        }

    }
}
