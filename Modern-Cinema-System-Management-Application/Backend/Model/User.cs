using Backend.Data;
using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string Email { get; set; } = null!;
        public Role Role { get; set; }

        public User(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
            Role = Role.User;
        }

        public User() { }


        public static bool ValidateUser(string login, string password, out int userId)
        {
            userId = -1;

            using (var context = new DataContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                    if(user != null) userId = user.Id;
                    return user != null;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static User GetUserByUserId(int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Id == userId);
                    return user!;
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
