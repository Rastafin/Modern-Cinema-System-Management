﻿using Backend.Data;
using Backend.Model.Enums;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
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
        public Status Status { get; set; } = Status.Active;
        public Role Role { get; set; }
        public List<Reservation> Reservations { get; set; }
        public User(string login, string password, string email)
        {
            Login = login;
            Password = password;
            Email = email;
            Role = Role.User;
        }

        public User() { }


        public static bool CheckUserData(string login, string password, out int userId)
        {
            userId = -1;

            using (var context = new DataContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Login == login);

                    if (user != null &&  PasswordHasher.VerifyPassword(password, user.Password))
                    {
                        userId = user.Id;
                        return true;
                    }

                    return false;
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

        public static void ChangePassword(User user, string newPassword)
        {
            using (var context = new DataContext())
            {
                try
                {
                    if (user == null) throw new Exception();

                    var userToUpdate = context.Users.FirstOrDefault(u => u.Id == user.Id);

                    if (userToUpdate != null)
                    {
                        userToUpdate.Password = newPassword;
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static void ChangeUserStatus(User user)
        {
            using(var context = new DataContext())
            {
                try
                {
                    var userToUpdate = context.Users.FirstOrDefault(u => u.Id == user.Id);

                    if(userToUpdate != null)
                    {
                        if (userToUpdate.Status == Status.Active) { userToUpdate.Status = Status.Inactive; }
                        else if (userToUpdate.Status == Status.Inactive) { userToUpdate.Status = Status.Active; }
                        context.SaveChanges();
                    }
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }

        public static User GetUserByLogin(string login)
        {
            using(var context = new DataContext())
            {
                try
                {
                    var user = context.Users.FirstOrDefault(x => x.Login == login);
                    if (user == null) throw new Exception();
                    return user;
                }
                catch (Exception)
                {
                    throw;
                }
            }
        }
    }
}
