using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApp.API.DTOs
{
    public class PhotoForCreationDto
    {
        public string Url { get; set; }
        public IFormFile File { get; set; }
        public string Description { get; set; }
        public DateTime DateAdded { get; set; }

        public string PublicId { get; set; }

        public PhotoForCreationDto()
        {
            DateAdded = DateTime.Now;
        }
    }
}
