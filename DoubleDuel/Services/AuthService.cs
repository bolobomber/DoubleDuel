using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
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

        public void Regestration(string login, string password)
        {

            if (context.Users.Where(usr => usr.Login == login)
                              .Select(usr => usr)
                              .FirstOrDefault() == null)
            {
                context.Add(new User()
                {
                    Login = login,
                    Password = password
                });
                context.SaveChanges();
                MessageBox.Show($"пользователь с именем {login} успешно зарегестрирован");
            }
            else
            {
                MessageBox.Show($"пользователь {login} уже есть попробуйте ввести другой логин");
            }
        }

        public User Authorization(string login, string password)
        {
            var user = context.Users.Where(usr => usr.Login == login && usr.Password == password)
                .Select(usr => usr).FirstOrDefault();

            if (user != null)
            {
                return user;
            }
            else
            {
                return null;
            }
        }
    }
}
