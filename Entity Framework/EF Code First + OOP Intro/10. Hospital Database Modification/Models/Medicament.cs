﻿namespace _10.Hospital_Database_Modification
{
    using System.ComponentModel.DataAnnotations;

    public class Medicament
    {
        [Key]
        public int Id { get; set; }
        [StringLength(30, MinimumLength = 4, ErrorMessage = "Invalid Name")]
        public string Name { get; set; }

        public int PatientId { get; set; }
        public virtual Patient Patient { get; set; }
    }
}
