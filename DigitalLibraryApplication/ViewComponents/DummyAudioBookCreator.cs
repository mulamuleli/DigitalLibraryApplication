using DigitalLibraryApplication.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DigitalLibraryApplication.ViewComponents
{
    public class DummyAudioBookCreator: ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(int numOfAudioBooks)
        {
            List<AudioBook> items = new List<AudioBook>();

            for (var i = 0; i < numOfAudioBooks; i++)
            {
                items.Add(new AudioBook
                {
                    Id = Guid.NewGuid(),
                    Title = String.Format("Dummy Book number {0}", i),
                    Subtitle = "Dummy Book subtitle",
                    Summary = "Dummy Book summary"
                });
            }

            return View(items);

        }
    }
}
