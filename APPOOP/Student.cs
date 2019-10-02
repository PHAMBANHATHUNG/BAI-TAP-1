using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace APPOOP
{
    class Student
    {
        public Student(string stname)
        {
            this.name = stname;
        }
        public Student()
        {

        }
        private string name;

        public string StudentName
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public virtual void Talk()
        {
            if (StudentName.Equals("Minh"))
                MessageBox.Show("My name is" + this.StudentName + "Iam a college student");
            else if (StudentName.Equals("Dung"))
                MessageBox.Show("My name is" + this.StudentName + "iam a university student");
        }

    }
}