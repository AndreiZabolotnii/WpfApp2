using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfApp2.Model;

namespace WpfApp2.Controller
{
    class UsersFactory
    {

        private List<User> users = new List<User>();


        public UsersFactory()
        {
            for(int i=0; i< 50; i++)
            users.Add(new User());
            User a = new User();
           
        }

        public List<User> getListOfUsers()
        {
            return users;
        }
      

    }
}
