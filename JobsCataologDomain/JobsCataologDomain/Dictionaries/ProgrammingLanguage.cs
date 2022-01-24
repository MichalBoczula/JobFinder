﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace JobsCatalog.Domain.Dictionaries
{
    public class ProgrammingLanguage
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Image { get; set; }
    }
}
