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
        public List<Reservation> Reservations { get; set; }

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
                catch (Exception ex)
                {
                    transaction.Rollback();
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
                    var client = context.Clients.FirstOrDefault(c => c.User.Id == userId);
                    return client;
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

    }
}
