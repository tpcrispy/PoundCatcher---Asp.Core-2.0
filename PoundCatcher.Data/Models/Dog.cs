using System;
using System.Collections.Generic;
using System.Text;

namespace PoundCatcher.Data.Models
{
    public enum TagColor
    {
        Red, Blue, Yellow, Green
    }

    public class Dog
    {
        public int Id { get; set; }
        public int MicroChip { get; set; }
        public TagColor TagColor { get; set; }


        public string Name { get; set; }
        public string Color { get; set; }
        public string Breed { get; set; }

        public int OwnerId { get; set; }
        public virtual Owner Owner { get; set; }
    }
}
