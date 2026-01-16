using System;

namespace BiblioInheritance
{
    public class Book : Resource
    {
        // FIX: Change { get; get; } to { get; private set; }
        public string Author { get; private set; }
        public int PageCount { get; private set; }

        public Book(string title, string category, string author, int pageCount) : base(title, category)
        {
            this.Author = author;
            this.PageCount = pageCount;
        }
    }
}