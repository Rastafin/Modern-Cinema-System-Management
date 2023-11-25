using Backend.Data;
using Backend.Model.Enums;
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

        public void Register(Client client, User user)
        {
            try
            {
                ClientService.AddClientWithUser(client, user);
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public void Login(string login, string password)
        {
            try
            {
                ClientService.ValidateUser(login, password);
            }
            catch(Exception ex)
            {
                throw;
            }
        }

    }
}
