﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleksa_Subasic_98_20_BookStore.Models
{
    class Book
    {
        public string? ImagePath { get; set; }
        public string? Title {  get; set; }
        public string? Author { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
    }
}