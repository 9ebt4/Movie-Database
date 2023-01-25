using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Movie_Database
{
    //Build a Movie class with two member variables:  title and category. Both of these should be strings.
    public class Movie
    {
        public string Title { get; set; }
        public string Category { get; set; }
        //The class should also provide a constructor that accepts a title and category as parameters and uses the values passed in to initialize the member variables.
        public Movie(string _title, string _category)
        {
            Title= _title;
            Category= _category;
        }
        
    }
    
}
