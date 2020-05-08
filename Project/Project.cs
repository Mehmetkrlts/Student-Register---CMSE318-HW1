using Project.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Project
{
    class Project
    {
        static ListStudents listStudents = new ListStudents();

        static void addmenu()
        {
            string FirstName, LastName, Sex, CountryOfBirth;
            int StudentNumber, YearOfBirth;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n Enter the Student information below. \n");
            Console.ResetColor();
            Console.WriteLine("Student's First Name :  "); FirstName = Console.ReadLine();
            Console.WriteLine("Student's Last Name :  "); LastName = Console.ReadLine();
            Console.WriteLine("Student's Sex :  "); Sex = Console.ReadLine();
            Console.WriteLine("Student's Country of Birth :  "); CountryOfBirth = Console.ReadLine();
            Console.WriteLine("studentNumber"); StudentNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Student's Year of birth :  "); YearOfBirth = Convert.ToInt32(Console.ReadLine());

            listStudents.Add(new Students(StudentNumber, FirstName , LastName, Sex, CountryOfBirth, YearOfBirth));
        }

        static void searchmenu()
        {
            int option;
        ask:
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 9 to Go Back! \n");
            Console.ResetColor();
            Console.WriteLine("\n Choose an option to search by: \n  1-Student Number\n  2- Year of Birth ");
            option = Convert.ToInt32(Console.ReadLine());
            if (option == 9) { Console.Clear(); return; }

            switch (option)
            {
                case 1:
                    Console.WriteLine("\n Enter Student Number : ");
                    int StudentNumber = Convert.ToInt32(Console.ReadLine());
                    listStudents.Show(StudentNumber); break;

                case 2:
                    Console.WriteLine("\n Year of birth : ");
                    int YearOfBirth = Convert.ToInt32(Console.ReadLine());
                    listStudents.SearchByYear(YearOfBirth);
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("\n **************** Invalid Input . \t********\n");
                    goto ask;
            }
        }

        static void delete()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 9 to Go Back! \n");
            Console.ResetColor();
            Console.WriteLine("\n Enter the Student Number to Delete : ");
            int StudentNumber = Convert.ToInt32(Console.ReadLine()) ;
          if (StudentNumber == 9) { Console.Clear(); return; }
            Console.Clear();
            listStudents.Remove(StudentNumber);

        }

        static void editmenu()
        {
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 9 to Go Back ! \n");
            Console.ResetColor();
            Console.WriteLine("\n Enter Student Number : ");
            int StudentNumber = Convert.ToInt32(Console.ReadLine());
        if (StudentNumber ==  9) { Console.Clear(); return; }
        ask:
            Console.Clear();
            Console.WriteLine("_________________________________\n");
            Console.WriteLine("\n Choose the field to Edit " + StudentNumber + "\n\n 0- Student Number \n"
                + "1- First Name of Student\n "
                + " 2-Last Name of Student\n"
                + " 3- Sex\n"
                + " 4- Country of Birth\n"
                + " 5- Date of Birth\n");
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine("Press 9 to Go Back \n");
            Console.ResetColor();
            Console.WriteLine("______________________________\n");
            int field = Convert.ToInt32(System.Console.ReadLine());
            ChangedType Type = (ChangedType)field;
            if (field == 9) { Console.Clear(); return; }
            if (field < 0 || field > 6)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n ********************* Invalid Input . \t ***************\n");
                Console.ResetColor();
                goto ask;
            }

            if (field != 6)
            {
                Console.WriteLine("\nEnter the new value: "); object item = Console.ReadLine();
                listStudents.Edit(StudentNumber, Type, item);
            }

            else

                Console.WriteLine("Invalid Number \n \n ");

            

        }

       

        static void showall()
        {
            Console.WriteLine(listStudents.ToString());
        }

        static void Main(string[] args) 
        {
            int i = 0;
            Console.WriteLine("____________  WELCOME _____________\n");
        menu:                                                               // Menu
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.WriteLine(listStudents.Capacity());
            Console.ResetColor();
            Console.WriteLine("___________________________");
            Console.WriteLine(" Press 1 to ADD \n" +
                              " Press 2 to Search\n" +
                              " Press 3 to Delete\n" +
                              " Press 4 to Edit\n" +
                              " Press 5 to List All\n");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Press 0 to Exit! \n");
            if (Convert.ToBoolean(i))
                Console.WriteLine("Press 9 to Clear Text \n");
            Console.ResetColor();
            Console.WriteLine("______________________________________\n");
            i = 1;
            switch (Convert.ToInt32(Console.ReadLine()))
            {
                case 0: Environment.Exit(0); break;
                case 1:
                    addmenu();
                    break;
                case 2:
                    searchmenu();
                    break;
                case 3:
                    delete();
                    break;
                case 4:
                    editmenu();
                    break;
                case 5:
                    showall();
                    break;
                case 9: Console.Clear(); break;
                default: Console.WriteLine("Wrong Input"); break;
            }
            goto menu;
        }
    }


}
