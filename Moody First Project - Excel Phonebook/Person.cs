using System;
using System.Collections.Generic;
using System.Text;

namespace Moody_First_Project___Excel_Phonebook
{
    public class Person
    {
        public Person(string name, string surname)
        {

            mName = name;

            mSurname = surname;

        }

        public Person(string v)
        {
            this.v = v;
        }

        public Person()
        {
        }

        private string mName;

        private string mSurname;
        private string v;

        public string Name
        {
            get { return mName; }
            set { mName = value; }
        }

        public string Surname
        {
            get { return mSurname; } 
            set { mSurname = value; }
        }

    }
}
