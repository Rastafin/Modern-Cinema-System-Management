using Backend.Data;
using Backend.Model.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Clients")]
    public class Client : Person
    {

        public Client() { }

        public Client(string name, string lastName, string birthday, Sex sex, string phoneNumber, string country, string city,
            string street, string houseNumber, string zipCode)
        {
            Name = name;
            LastName = lastName;
            Birthday = birthday;
            Sex = sex;
            PhoneNumber = phoneNumber;
            Country = country;
            City = city;
            Street = street;
            HouseNumber = houseNumber;
            ZipCode = zipCode;
        }


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
                catch (Exception)
                {
                    transaction.Rollback();
                    throw;
                }
            }
        }

        public static void UpdateClient(Client updatedClient)
        {
            using (var context = new DataContext())
            {       
                try
                {
                    Client? existingClient = context.Clients.Include(r => r.User).FirstOrDefault(c => c.Id == updatedClient.Id);

                    if (existingClient == null) throw new Exception();

                    context.Entry(existingClient).CurrentValues.SetValues(updatedClient);
                    context.Entry(existingClient.User).CurrentValues.SetValues(updatedClient.User);
                    context.SaveChanges();
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static Client GetClient(int userId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Clients.Include(r => r.User)
                        .FirstOrDefault(c => c.User.Id == userId);
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

        public static List<Client> GetClients()
        {
            using(var context = new DataContext())
            {
                try
                {
                    return context.Clients.Include(r => r.User)
                        .ToList();
                }
                catch(Exception)
                {
                    throw;
                }
            }
        }

    }
}
