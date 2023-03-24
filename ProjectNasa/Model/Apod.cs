﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectNasa.Model
{
    public class Apod
    {
        public string Copyright { get; set; }
        public DateOnly Date { get; set; }
        public string Explanation { get; set; }
        public string Hdurl { get; set; }
        public string MediaType { get; set; }
        public string ServiceVersion { get; set; }
        public string Title { get; set; }
        public string Url { get; set; }
    }
}
