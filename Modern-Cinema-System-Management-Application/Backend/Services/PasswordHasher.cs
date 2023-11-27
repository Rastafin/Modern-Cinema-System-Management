﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Backend.Services
{
    public static class PasswordHasher
    {
        public static string HashPassword(string password)
        {
            using(var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return Convert.ToBase64String(hashedBytes);
            }
        }

        public static bool VerifyPassword(string enteredPassword, string hashedPassword)
        {
            using(var sha256 = SHA256.Create())
            {
                byte[] hashedBytes = sha256.ComputeHash(System.Text.Encoding.UTF8.GetBytes(enteredPassword));
                string enteredHashedPassword = Convert.ToBase64String(hashedBytes);
                return enteredHashedPassword.Equals(hashedPassword);
            }
        }
    }
}
