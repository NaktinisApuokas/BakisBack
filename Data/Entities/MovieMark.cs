﻿namespace FobumCinema.Data.Entities
{
    public class MovieMark
    {
        public int Id { get; set; }
        public int MovieId { get; set; }
        public Movie Movie { get; set; }
        public string Username { get; set; }
    }
}
