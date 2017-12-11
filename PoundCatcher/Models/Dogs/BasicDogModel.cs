using PoundCatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PoundCatcher.Models.Dogs
{
    public class BasicDogModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string OwnersName { get; set; }
        public int MicroChip { get; set; }
        public TagColor TagColor { get; set; }

    }
}
