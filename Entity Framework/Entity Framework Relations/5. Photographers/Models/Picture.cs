﻿namespace _5.Photographers.Models
{
    using System;
    using System.Collections.Generic;

    public class Picture
    {
        public Picture()
        {
            Albums = new HashSet<Album>();
        }

        public int Id { get; set; }

        public string Title { get; set; }

        public string Caption { get; set; }

        public string FileSystemPath { get; set; }

        public virtual ICollection<Album> Albums { get; set; }
    }
}
