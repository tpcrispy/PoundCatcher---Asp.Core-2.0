using PoundCatcher.Data;
using System;

namespace PoundCatcher.Service
{
    public class DogService : IDog
    {
        private readonly ApplicationDbContext _context;

        public DogService(ApplicationDbContext context)
        {
            _context = context;
        }
    }
}
