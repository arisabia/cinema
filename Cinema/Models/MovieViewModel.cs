using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Cinema.Models
{
    public class MovieViewModel
    {
        public int Id { get; set; }
        [Required, DisplayName("Name"), StringLength(50, MinimumLength = 1)]
        public string Name { get; set; }
        [Required, DisplayName("Length"), MinLength(1)]
        public int Length { get; set; }
        [Required, DisplayName("Type"), StringLength(50)]
        public string Type { get; set; }
        [Required, DisplayName("Release Date "), DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
    }
}
