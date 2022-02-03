using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DoubleDuel.DAL;
using DoubleDuel.DAL.Entities;

namespace DoubleDuel.Services
{
    public class AuthService
    {
        public DoubleDuelsContext context;
          
        public AuthService()
        {
            context = new DoubleDuelsContext();
        }
        /*
        public void Regestration(string login, string password)
        {   
            this.context.Add(new User()
            {
                Login = login,
                Password = password
            });
        */
    }
}
