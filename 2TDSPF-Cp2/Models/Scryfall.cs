using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace _2TDSPF_Cp2.Models
{
    public class Scryfall
    {

        public string? Image { get; set; }
        public string? Name { get; set; }
        public string? Type { get; set; }
        public string? Description { get; set; }
        public string? Stats { get; set; }
        public string? Artist { get; set; }
        public string? News { get; set; }

    }
}
