using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Part_10._5_Student_Forms
{
    public class Student
    {
        private static Random generator = new Random();
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _studentNumber;


        public Student(string firstName, string lastName)
        {
            // Instance variables/feilds initialized here
            _firstName = firstName;
            _lastName = lastName;
            _studentNumber = generator.Next(100, 1000);
            GenerateEmail();
        }

        public string FirstName
        {
            get
            {
                return _firstName;
            }
            set
            {
                _firstName = value;
                GenerateEmail();
            }
        }

        public string LastName
        {
            get
            {
                return _lastName;
            }
            set
            {
                _lastName = value;
                GenerateEmail();
            }

        }

        public int StudentNumber
        {
            get
            {
                return _studentNumber;
            }
        }

        public override string ToString()
        {
            return _firstName + " " + _lastName;
        }
  
        private void GenerateEmail()
        {
            //first 3 of first name first 3 of last name student number and @ics4u.ca
            _email = _firstName.Substring(0, 3) + _lastName.Substring(0, 3) + _studentNumber + "@ics4u.ca";

        }

        public string Email
        {
            get
            {
                return _email;
            }
        }
    }
}
