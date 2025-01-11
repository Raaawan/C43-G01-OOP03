﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment3
{
    internal class Book
    {
        public string? Title {  get; set; }
        public string? Author { get; set; }
        public string? ISBN { get; set; }

        public Book(string? title, string? author, string? isbn) {
            Title = title;
            Author = author;
            ISBN = isbn;
        }
        public override string ToString()
        {
            return $"Title: {Title}\nAuthor: {Author}\nISBN: {ISBN}";
        }
    }
}
