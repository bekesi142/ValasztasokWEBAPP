﻿using System.ComponentModel.DataAnnotations;

namespace ValasztasokWebfeladat.Models
{
    public class Part
    {

        [Key]
        public string RovidNev { get; set; }
        public string TeljesNev { get; set; }
        public ICollection<Jelolt> Jeloltek { get; set; }


    }
}
