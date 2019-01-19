using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C0723560
{
    class Program
    {
        static void Main(string[] args)
        {
            Studentinformation _Mary = new Studentinformation("Mary", 3.8, 20);
            Studentinformation _john = new Studentinformation("john", 3.8, 20);
            Studentinformation _Mark = new Studentinformation("Mark", 3.8, 20);
            Studentinformation _Steven = new Studentinformation("Steven", 3.8, 20);
            Studentinformation _Cindy = new Studentinformation("Cindy", 3.8, 20);


            var StudentList = new List<Studentinformation>();
            StudentList.Add(_Mary);
            StudentList.Add(_john);
            StudentList.Add(_Mark);
            StudentList.Add(_Steven);
            StudentList.Add(_Cindy);

            foreach (var student in StudentList)
            {
                Console.WriteLine(student.name);
            }

        
        }

    }


    class Studentinformation
    {


        public string name;

        public double GPA;
        int attendance;
        public Studentinformation(string aname, double cGPA, int dattendance)

        {
            name = aname;

            GPA = cGPA;
            attendance = dattendance;
        }


    }

    class StudentList
    {
       public void CICS()
        {
            
        }
    }

}