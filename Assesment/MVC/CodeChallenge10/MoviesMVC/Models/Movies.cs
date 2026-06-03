using System;

namespace MoviesMVC.Models
{
    public class Movies
    {
        public int Mid { get; set; }
        public string MovieName { get; set; }
        public string DirectorName { get; set; }
        public DateTime DateOfRelease { get; set; }
    }
}