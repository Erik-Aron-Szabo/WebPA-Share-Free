﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Share_Free.Models
{
    public class PostModel
    {
        public int Id { get; set; }

        public string Username { get; set; }

        public string Title { get; set; }

        public string Description { get; set; }

        public DateTime Date { get; set; }

        public int CommentId { get; set; }


    }
}
