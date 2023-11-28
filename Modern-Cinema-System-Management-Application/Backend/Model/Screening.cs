using Backend.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
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
                        .ToList();
                }
                catch(Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
