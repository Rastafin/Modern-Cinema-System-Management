using Backend.Model.Enums;
using System;
using System.Collections.Generic;
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

            message = string.Empty;
            return true;
        }
    }
}
