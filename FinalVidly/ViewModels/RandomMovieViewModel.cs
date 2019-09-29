using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using FinalVidly.Models;

namespace FinalVidly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> customers { get; set; }
    }
}