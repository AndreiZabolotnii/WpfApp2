using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp2.Model
{
    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }


        public User()
        {
            Id = Randomizer.GetRandomNumber(1, 10000);
            Name = "NameDefault";
            Department = "DepDefault";
        }


        public string Details
        {
            get
            {
                return String.Format("{0} - {1} is from {2} department",this.Id, this.Name, this.Department);
            }
        }

    }   
}
