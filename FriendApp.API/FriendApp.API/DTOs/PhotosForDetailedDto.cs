﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FriendApp.API.DTOs
{
    public class PhotosForDetailedDto
    {
        public int Id { get; set; }
        public string Url { get; set; }

        public string Description { get; set; }

        public DateTime DateAdded { get; set; }

        public bool IsMain { get; set; }

        public bool IsApproved { get; set; }
    }
}
