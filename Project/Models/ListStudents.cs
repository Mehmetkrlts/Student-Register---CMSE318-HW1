using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Models
{
    class ListStudents
    {
        List<Students> list;

        //INIT LIST WITH 10 STUDENT OBJECTS
        public ListStudents()
        {
            list = new List<Students>
            {
                new Students(111111,"Mehmet","Karlıtaş","Male","Cyprus",1998),
                new Students(222222,"Fuat","Tarik İslam","Male","Turkey",1993),
                new Students(333333,"Süleyman","Bilmem","Male","Germany",1995),
                new Students(444444,"Ceyda","Adıgüzel","Female","Uk",1999),
                new Students(555555,"Ayşe","Güzel","Female","Japan",1998),
                new Students(666666,"Esra","Gizemsoy","Female","Germany",1997),
                new Students(777777,"Fatma","Gül","Female","Turkey",1993),
                new Students(888888,"Selin","Derli","Female","Cyprus",1996),
                new Students(999999,"Tolga","Bacavuz","Male","Cyprus",2000),
                new Students(123456,"Cagri","Zengin","Male","Germany",1997),
            };
        }

        public void Add(Students item) 
        {
            //CHECK FULL
            if (list.Count == 100)
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n***********\t LIST IS FULL.\t***********\n");
                Console.ResetColor();
            }
            else
            {
                list.Add(item);
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\n**********       " + item.GetStudentNumber() + " ADDED.      ***********\n");
                Console.ResetColor();
            }
        }

        public string Capacity()
        {
            return "*********** LIST CAPACITY: " + list.Count + "/100. ***********\n";
        }

         public Students SearchByNumber(int StudentNumber)
          {
              foreach (Students item in list)      //  for (int i = 0; i < list.Count; i++)
              {                                    //  {
                  if (item.SearchByNumber(StudentNumber))     //    if (list[i].SearchByNumber(StudentNumber)
                      return item;                 //        return list[i];
              }                                    //  }
              Console.Clear();
              Console.BackgroundColor = ConsoleColor.DarkRed;
              Console.WriteLine("\n***********\t" + StudentNumber + " NOT FOUND.\t***********\n");
              Console.ResetColor();
              return null;
          }   

       
            public void SearchByYear(int YearOfBirth)
        {
            bool control = true;
            foreach (Students item in list)
            {
                if (item.SearchByYear(YearOfBirth))
                {
                    Console.WriteLine(item);
                    control = false;
                }

            }
            if (control)
            {
                Console.Clear();
                Console.BackgroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("\n***********\t" + YearOfBirth + " Not Found.\t***********\n");
                Console.ResetColor();

            }
            return;
        }
        public void Show(int StudentNumber)
        {
            Console.WriteLine(SearchByNumber(StudentNumber));

            //foreach (Students item in list)     //for (int i = 0; i < list.Count; i++)
            //{                                   //{
            //    if (item.SearchByNumber(StudemtNumber))    //    if (list[i].SaerchByNumber(StudentNumber))
            //        Console.WriteLine(item);    //        Console.WriteLine(list[i]);
            //}                                   //}     

        }
        public void Remove(int StudentNumber) // Student Remove function
        {
            Students get = SearchByNumber(StudentNumber);
            if (get != null)  //get? = not null
            {
                list.Remove(get);
                Console.BackgroundColor = ConsoleColor.Green;
                Console.WriteLine("\n***********\t" + StudentNumber + " DELETED.\t***********\n");
                Console.ResetColor();
            }
        }
        public void Edit(int StudentNumber, ChangedType changeType, object newItem)
        {
            Students get = SearchByNumber(StudentNumber);
            get?.Edit(changeType, newItem);
            Console.Clear();
            Console.BackgroundColor = ConsoleColor.Green;
            Console.WriteLine("\n***********\tOPERATION SUCCESS\t***********\n");
            Console.ResetColor();
        }

        public override string ToString()
        {
            string all = "";

            foreach (Students item in list)    //for (int i = 0; i < list.Count; i++)
            { all += item.ToString(); }        //all += list[i].ToString();

            return all;

        }
    }
}
