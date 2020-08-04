using System;
using System.Collections.Generic;
using System.Text;

namespace LabEleven
{
    public class Movie
    {
        private string _title;

        private string _category;

        public string Title
        {
            get { return _title; }
        }

        public string Category
        {
            get { return _category; }
        }

        public Movie(string title, string category)
        {
            this._title = title;
            this._category = category;
        }
    }
}
