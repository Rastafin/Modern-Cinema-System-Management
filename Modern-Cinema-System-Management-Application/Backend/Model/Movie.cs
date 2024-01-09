using Backend.Data;
using Backend.Model.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Security.Cryptography;
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
        public MovieCategory? Category { get; set; }
        public List<Screening> Screenings { get; set; }

        public static Movie GetMovieByTitle(string title)
        {
            using (var context = new DataContext())
            {
                try
                {
                    return context.Movies.FirstOrDefault(m => m.Title == title);
                }
                catch (Exception ex)
                {
                    throw;
                }
            }
        }

        public static void AddNewMovie(Movie movie)
        {
            using (var context = new DataContext())
            {
                try
                {
                    context.Movies.Add(movie);
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    throw new Exception("Error in AddNewMovie method. " + ex.Message);
                }
            }
        }
    }
}
