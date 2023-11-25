using Backend.Model;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Data
{
    public class ClientService
    {
        public static void AddClientWithUser(Client client, User user)
        {
            using (var context = new DataContext())
            {
                using var transaction = context.Database.BeginTransaction();

                try
                {
                    context.Users.Add(user);
                    context.SaveChanges();

                    client.UserId = user.Id;
                    context.Clients.Add(client);
                    context.SaveChanges();

                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static bool ValidateUser(string login, string password)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Login == login && x.Password == password);
                    return user != null;
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
