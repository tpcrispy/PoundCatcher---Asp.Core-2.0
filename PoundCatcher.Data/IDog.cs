using PoundCatcher.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace PoundCatcher.Data
{
    public interface IDog
    {
        IEnumerable<Dog> GetBasicDogs(); 
    }
}
