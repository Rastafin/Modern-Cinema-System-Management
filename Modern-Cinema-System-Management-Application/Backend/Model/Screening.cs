﻿using Backend.Data;
using Backend.Model.Enums;
using Backend.Services;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Screenings")]
    public class Screening
    {
        [Key]
        public int Id { get; set; }
        public string StartTime { get; set; }
        public List<Reservation> Reservations { get; set; }

        [ForeignKey("MovieId")]
        public int MovieId { get; set; }
        public Movie Movie { get; set; }

        [ForeignKey("RoomId")]
        public int RoomId { get; set; }
        public Room Room { get; set; }
        public bool? IsManuallyDeleted { get; set; } = false;

        public static Screening GetScreeningFromId(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var screening = context.Screenings
                        .Include(r => r.Room)
                        .Where(r => r.IsManuallyDeleted == false)
                        .FirstOrDefault(r => r.Id == screeningId);

                    if (screening == null) throw new Exception();

                    return screening;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetScreeningFromId method. " + ex.Message);
                }
            }
        }

        public static List<Screening> GetAllScreeningsWithRoomsAndMovies()
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Screenings
                        .Include(s => s.Room)
                        .Include(s => s.Movie)
                        .Where(r => r.IsManuallyDeleted == false)
                        .OrderBy(s => s.StartTime)
                        .ToList();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<string> GetMovieHoursOnSelectedDate(int movieId, string date, User user)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var screenings = context.Screenings
                        .Include(s => s.Room)
                        .Include(s => s.Movie)
                        .Where(r => r.IsManuallyDeleted == false)
                        .Where(s => s.MovieId == movieId)
                        .OrderBy(s => s.StartTime)
                        .ToList();

                    var currentTime = DateTime.Now.TimeOfDay;

                    if(user.Role == Role.Employee || user.Role == Role.Admin)
                    {
                        var movieHours = screenings
                        .Where(s => ParsingService.ParseStartDate(s.StartTime) == date)
                        .Select(s => ParsingService.ParseStartTime(s.StartTime))
                        .ToList();

                        return movieHours;
                    }
                    else
                    {
                        var movieHours = screenings
                        .Where(s => ParsingService.ParseStartDate(s.StartTime) == date)
                        .Select(s => ParsingService.ParseStartTime(s.StartTime))
                        .Where(movieHour => TimeSpan.Parse(movieHour) >= currentTime.Add(TimeSpan.FromMinutes(30)))
                        .ToList();

                        return movieHours;
                    }              
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
        
        public static int GetRoomIdOnSelectedDate(string dateWithHour, int movieId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Screenings
                        .Where(s => s.StartTime == dateWithHour && s.MovieId == movieId && s.IsManuallyDeleted == false)
                        .Select(s => s.RoomId)
                        .FirstOrDefault();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static int GetScreeningIdFromDateAndMovie(string dateWithHour, int movieId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Screenings
                        .Where(s => s.StartTime == dateWithHour && s.MovieId == movieId && s.IsManuallyDeleted == false)
                        .Select(s => s.Id)
                        .FirstOrDefault();
                }
                catch
                {
                    throw;
                }
            }
        }

        public static bool CheckIfEverySeatForScreeningIsBooked(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    List<string> seatsForScreening = Reservation.GetReservedSeatsForScreening(screeningId); 
                    Screening screening = GetScreeningFromId(screeningId);

                    if(seatsForScreening.Count == ((int)screening.Room.Capacity))
                    {
                        return true;
                    }

                    return false;
                }
                catch(Exception ex)
                {
                    throw new Exception("Error in CkechIfEverySeatForScreeningIsBooked method. " + ex.Message);
                }
            }
        }

        public static List<Screening> GetCurrentScreenings()
        {
            using (var context = new DataContext())
            {
                try
                {
                    DateTime today = ParsingService.ParseStringToDateTime(DateTime.Today.ToString("yyyy-MM-dd"));

                    List<Screening> allScreenings = context.Screenings
                        .Include(s => s.Movie)
                        .Include(s => s.Room)
                        .Where(r => r.IsManuallyDeleted == false)
                        .ToList();

                    List<Screening> currentScreenings = new List<Screening>();

                    foreach(Screening screening in allScreenings)
                    {
                        if(ParsingService.ParseStringToDateTime(
                            ParsingService.ParseStartDate(screening.StartTime)) >= today)
                        {
                            currentScreenings.Add(screening);
                        }
                    }

                    return currentScreenings;
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in GetCurrentScreenings method. " + ex.Message);
                }
            }
        }

        public static void DeleteScreeningWithReservations(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    Screening screening = context.Screenings.FirstOrDefault(r => r.Id == screeningId && r.IsManuallyDeleted == false)!;

                    if (screening == null) throw new Exception("This screening does not exist. ");

                    List<Reservation> reservationsToDelete = context.Reservations
                        .Where(r => r.ScreeningId == screening.Id && r.IsDeleted == false)
                        .ToList();

                    foreach(Reservation reservation in reservationsToDelete)
                    {
                        if(reservation.IsDeleted == false)
                        {
                            reservation.IsDeleted = true;
                        }
                    }

                    screening.IsManuallyDeleted = true;

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in DeleteScreeningWithReservations method. " + ex.Message);
                }
            }
        }
    }
}
