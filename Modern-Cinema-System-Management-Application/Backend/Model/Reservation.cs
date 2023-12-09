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
    }
}
