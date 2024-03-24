﻿using System;

namespace FobumCinema.Data.Entities
{
    public class Movie
    {
        public int Id { get; set; }

        public string Title { get; set; }

        public string Genre { get; set; }

        public string Img { get; set; }

        public string Description { get; set; }

        public string Duration { get; set; }

        public int CinemaId { get; set; }

        public Cinema Cinema { get; set; }

        public List<Screening> Screenings { get; set; }

        public bool IsMarked { get; set; }
    }
}
