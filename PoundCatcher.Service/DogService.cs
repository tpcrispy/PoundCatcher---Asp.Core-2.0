using PoundCatcher.Data;
using System;
using PoundCatcher.Data.Models;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace PoundCatcher.Service
{
    public class DogService : IDog
    {
        private readonly ApplicationDbContext _context;

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Dog> GetBasicDogs()
        {
            return _context.Dogs.Include(x => x.Owner);
        }
        
    }
}
