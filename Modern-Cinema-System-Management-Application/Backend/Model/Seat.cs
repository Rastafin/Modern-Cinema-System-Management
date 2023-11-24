using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Seats")]
    public class Seat
    {
        [Key]
        public int Id { get; set; }
        public bool IsBooked { get; set; } = false;
        public List<Reservation> Reservations { get; set; }

        [ForeignKey("RoomId")]
        public int RoomId { get; set; }
        public Room Room { get; set; } = null!;
    }
}
