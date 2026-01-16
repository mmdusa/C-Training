using System;

namespace BiblioInheritance
{
    public class Periodical : Resource
    {
        // 1. Create the new string property 'Period'
        public string Period { get; private set; }

        // 2. Define the constructor with 3 arguments
        // We pass title and category to the base (Resource) constructor
        public Periodical(string title, string category, string period) : base(title, category)
        {
            // Set the specific Period property
            this.Period = period;
        }
    }
}