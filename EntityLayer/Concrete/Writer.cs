﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concrete
{
    public class Writer
    {
        [Key]
        public int WriterID { get; set; }

        public string WriterName { get; set; }

        public string WriterAbout { get; set; }

        public string WriterImage { get; set; }

		public string WriterMail { get; set; }

        public string WriterPassword { get; set; }

        public bool Writerstatus { get; set; }

		public ICollection<Blog> Blogs { get; set; }


	}
}
