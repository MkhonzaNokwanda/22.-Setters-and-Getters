using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Setters_and_Getters
{
    internal class Movie
    {
        public string title;
        public string director;
        public string rating;


        //Constructor
        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            rating = aRating;
        }
        public string Rating
        {
            get { 
                return rating; }
            set { 
                if value =="S" || value=="PG"|| value=="PG-13" || value == "R"{
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
                    
                }
        }
    }
}
