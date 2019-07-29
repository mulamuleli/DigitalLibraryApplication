using DigitalLibraryApplication.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.Services
{
    public class AudioBookService : IAudioBookService
    {
        private readonly DigitalLibraryContext _context;

        public AudioBookService(DigitalLibraryContext context)
        {
            _context = context;
        }

        public AudioBook Add(AudioBook audioBook)
        {
            throw new NotImplementedException();
        }

        public void Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<AudioBook> GetAll()
        {

            return _context.AudioBooks
                .Include(x => x.Author)
                .Include(x => x.Narator)
                .Include(x => x.Publisher)
                .ToList();
        }

        public AudioBook GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public AudioBook Update(Guid id, AudioBook audioBook)
        {
            throw new NotImplementedException();
        }
    }


}
