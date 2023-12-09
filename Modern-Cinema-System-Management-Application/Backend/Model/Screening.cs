using Backend.Data;
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

        public static List<Screening> GetAllScreeningsWithRoomsAndMovies()
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Screenings
                        .Include(s => s.Room)
                        .Include(s => s.Movie)
                        .OrderBy(s => s.StartTime)
                        .ToList();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }

        public static List<string> GetMovieHoursOnSelectedDate(int movieId, string date)
        {
            using (var context = new DataContext())
            {
                try
                {
                    var screenings = context.Screenings
                        .Include(s => s.Room)
                        .Include(s => s.Movie)
                        .Where(s => s.MovieId == movieId)
                        .OrderBy(s => s.StartTime)
                        .ToList();

                    var movieHours = screenings
                        .Where(s => ParsingService.ParseStartDate(s.StartTime) == date)
                        .Select(s => ParsingService.ParseStartTime(s.StartTime))
                        .ToList();

                    return movieHours;

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
                        .Where(s => s.StartTime == dateWithHour && s.MovieId == movieId)
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
                        .Where(s => s.StartTime == dateWithHour && s.MovieId == movieId)
                        .Select(s => s.Id)
                        .FirstOrDefault();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
