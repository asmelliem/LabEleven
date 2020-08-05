using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Movie
    {
        private string title;

        private string category;

        public string Title
        {
            get { return title; }
        }

        public string Category
        {
            get { return category; }
        }

        public Movie(string title, string category)
        {
            this.title = title;
            this.category = category;
        }
    }
}
