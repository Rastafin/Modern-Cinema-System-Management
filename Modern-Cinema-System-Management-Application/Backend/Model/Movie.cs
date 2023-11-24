﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backend.Model
{
    [Table("Movies")]
    public class Movie
    {
        [Key]
        public int Id { get;set; }
        public string? Title { get; set; }
        public string? Description { get; set; }
        public int? Duaration { get; set; }
        public string? Director { get; set; }
        public string? ReleaseDate { get; set; }
        public string? WithdrawalDate { get; set; }
        public string? ImageFileName { get; set; }
        public bool IsArchived { get; set; } = false;
        public List<Screening> Screenings { get; set; }

    }
}