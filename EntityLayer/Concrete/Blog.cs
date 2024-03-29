﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Blog
    {
        public int BlogId { get; set; }
        public string BlogTitle { get; set; }
        public string BlogContent { get; set; }
        public string BlogThumbnailImage { get; set; }
        public string BlogImage { get; set; }
        public DateTime CreateDate { get; set; }
        public bool BlogStatus { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }
        public int? WriterId { get; set; }
        public virtual Writer Writer { get; set; }

        public List<Comment> Comment { get; set; }
    }
}
