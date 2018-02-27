using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Auth0_Test.Models
{
    public class Book
    {
        private string author;
        private string title;
        private bool ageRestriction;

        public string Author
        {
            get { return author; }
            set { author = value; }
        }
        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public bool AgeRestriction
        {
            get { return ageRestriction; }
            set { ageRestriction = value; }
        }

        public int BookId { get; set; }

        public Book (string writer, string ttl, bool restricted)
        {
            author = writer;
            title = ttl;
            ageRestriction = restricted;
        }
    }
}
