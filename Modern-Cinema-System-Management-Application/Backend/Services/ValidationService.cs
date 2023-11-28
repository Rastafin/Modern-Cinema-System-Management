using Backend.Data;
using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Backend.Services
{
    public static class ValidationService
    {
        public static bool ValidateClientRegisterProcess(string name, string lastName, string birthday, string phoneNumber, string country, string city,
            string street, string houseNumber, string zipCode, out string message)
        {
            if(name ==  null || name.Length == 0 || lastName == null || lastName.Length == 0 || birthday == null
                || birthday.Length == 0 || phoneNumber == null || phoneNumber.Length == 0 || country == null
                || country.Length == 0 || city == null | city.Length == 0 || street == null
                || street.Length == 0 || houseNumber == null || houseNumber.Length == 0 || zipCode == null
                || zipCode.Length == 0)
            {
                message = "Not every form field is filled";
                return false;
            }

            if(name.Length > 40)
            {
                message = "Name field is too long";
                return false;
            }

            if (lastName.Length > 40)
            {
                message = "Last name field is too long";
                return false;
            }

            if (phoneNumber.Length != 9)
            {
                message = "Phone number is incorrect";
                return false;
            }

            if (country.Length > 40)
            {
                message = "Country field is too long";
                return false;
            }

            if (city.Length > 40)
            {
                message = "City field is too long";
                return false;
            }

            if (street.Length > 40)
            {
                message = "Street field is too long";
                return false;
            }

            if (!Regex.IsMatch(zipCode, @"^\d{2}-\d{3}$"))
            {
                message = "Invalid zip code format. Please use format '00-000'";
                return false;
            }

            if (!Regex.IsMatch(houseNumber, @"^[0-9a-zA-Z]+$"))
            {
                message = "Invalid house number format. Please use only alphanumeric characters";
                return false;
            }

            if (!DateTime.TryParseExact(birthday, "dd.MM.yyyy", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
            {
                message = "Invalid birthday format. Please use format 'dd/MM/yyyy'";
                return false;
            }

            if (parsedDate > DateTime.Now)
            {
                message = "Birthday cannot be in the future";
                return false;
            }

            message = string.Empty;
            return true;
        }

        public static bool ValidateUserRegisterProcess(string login, string password, string email, out string message)
        {
            if(login == null || login.Length  == 0 || password == null || password.Length == 0 || email == null || email.Length == 0)
            {
                message = "Not every form field is filled";
                return false;
            }

            if(login.Length < 5)
            {
                message = "Login must contain at least 5 characters";
                return false;

            }
            
            if (login.Length > 20)
            {
                message = "Login can contain max 20 characters";
                return false;

            }

            if(password.Length < 5)
            {
                message = "Password must contain at least 5 characters";
                return false;
            }

            if (login.Length > 20)
            {
                message = "Password can contain max 20 characters";
                return false;

            }

            if (!password.Any(char.IsDigit))
            {
                message = "Password must contain at least one digit";
                return false;
            }

            if(!IsValidEmail(email))
            {
                message = "Invalid email format";
                return false;
            }

            using(var context = new DataContext())
            {
                if(context.Users.Any(u => u.Login == login))
                {
                    message = "Login already exists";
                    return false;
                }

                if (context.Users.Any(u => u.Email == email))
                {
                    message = "Email already exists";
                    return false;
                }
            }
            message = string.Empty;
            return true;
        }

        public static bool IsValidEmail(string email)
        {
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);
                return addr.Address == email;
            }
            catch(Exception e)
            {
                return false;
            }
        }
    }
}
