﻿using BigSchooll.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BigSchooll.ViewModels
{
    public class CourseViewModel
    {
        [Required]
        public string Place { set; get; }
        [Required]
        [FutureDate]
        public string Date { set; get; }
        [Required]
        [ValidTime]
        public string Time { set; get; }
        [Required]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        public DateTime GetDateTime ()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }   
    }
}