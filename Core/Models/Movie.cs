using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Length { get; set; }
        public string Type { get; set; }
        public DateTime ReleaseDate { get; set; }
    }
}
