using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB5_Nlog
{
    public class DeveloperAttribute : System.Attribute
    {
        string firstname;
        string lastname;
        string patronymic;

        public DeveloperAttribute(string firstname, string patronymic, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.patronymic = patronymic;
        }


        public virtual string Firstname
        {
            get { return firstname; }
        }

        public virtual string Lastname
        {
            get { return lastname; }
        }

        public virtual string Patronymic
        {
            get { return patronymic; }
        }
    }
}
