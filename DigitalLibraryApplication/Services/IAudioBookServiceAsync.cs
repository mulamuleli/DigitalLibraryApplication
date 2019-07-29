using DigitalLibraryApplication.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.Services
{
    public interface IAudioBookServiceAsync
    {
        Task<IEnumerable<AudioBook>> GetAll();
        Task<AudioBook> GetById(Guid id);
        Task<AudioBook> Add(AudioBook audioBook);
        Task<AudioBook> Update(Guid id, AudioBook audioBook);
        Task Delete(Guid id);
    }
}
/*   
 *this class in a new implementation of AudioBookService, it has all the methods as the API one
 *  instean of returning IEnumerable<>, we ae wrapping everytjing into a task
 *   so implementation will stay the same
 *   */