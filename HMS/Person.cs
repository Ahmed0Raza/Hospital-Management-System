using System.Data;

namespace HMS
{
    abstract class Person
    {
        protected string id;
        protected string name;
        protected string address;
        protected string age;
        protected string phone;
        protected string gender;
        protected string bloodgroup;
        protected string cnic;
        public string ID
        {
            get { return id; }
            set { id = value;  }
        }

        public string CNIC
        {
            get { return cnic; }
            set { cnic = value; }
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Address
        {
            get { return address; }
            set { address = value; }
        }

        public string Age
        {
            get { return age; }
            set { age = value; }
        }

      

        public string Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        public string Gender
        {
            get { return gender; }
            set { gender = value; }
        }
        public string Blood { get { return bloodgroup; } set { bloodgroup = value; } }


        public abstract void Add();
        public abstract void Update();
        public abstract void Delete();
        
    }
}
