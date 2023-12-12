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
    [Table("Reservations")]
    public class Reservation
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey("ClientId")]
        public int? ClientId { get; set; }
        public Client? Client { get; set; }

        [ForeignKey("ScreeningId")]
        public int? ScreeningId { get; set; }
        public Screening? Screening { get; set; }

        public string? Seat { get; set; }

        public static List<string> GetReservedSeatsForScreening(int screeningId)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Reservations
                        .Where(s => s.ScreeningId == screeningId)
                        .Select(s => s.Seat)
                        .ToList();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static void MakeReservationForScreening(int clientId, int screeningId, List<string> listOfSeats)
        {
            using (var context = new DataContext())
            {
                try
                {
                    foreach(string seat in listOfSeats)
                    {
                        Reservation reservation = new Reservation
                        {
                            ClientId = clientId,
                            ScreeningId = screeningId,
                            Seat = seat
                        };

                        context.Reservations.Add(reservation);
                    }

                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }
    }
}
