//Lena Lindblad
//HT2018-DA204B-88221
//Project 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenTheTeams
{
    //Class for players email and phone
    public class ContactData
    {
        private string email;
        private string phone;

        //Constructor
        public ContactData()
        {

        }

        public ContactData(string email, string phone)
        {
            Initialize();
            this.email = email;
            this.phone = phone;
        }

        //Properties
        public string Phone
        {
            get { return phone; }

            set { phone = value; }
        }

        public string Email
        {
            get { return email; }

            set { email = value; }
        }
        private void Initialize()
        {
            email = string.Empty;
            phone = string.Empty;
        }
    }
}