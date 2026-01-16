using System;

namespace BiblioInheritance
{
    // FIX 1: Class name should be Resource, not Book
    public class Resource
    {
        public string Title
        { get; private set; }

        public string Category
        { get; private set; }

        // FIX 2: Setter must be 'protected', not 'private'
        public string Status
        { get; protected set; }

        public Resource(string title, string category)
        {
            // FIX 3: Assign the parameters to the properties
            this.Title = title;
            this.Category = category;

            this.Status = "Available";
        }

        public virtual void UpdateStatus()
        {
            // FIX 4: Add logic to switch statuses
            if (Status == "Available")
            {
                Status = "Out";
            }
            else
            {
                Status = "Available";
            }
        }
        public virtual void GetInfo()
        {
            Console.WriteLine($"Title: {Title}");
            Console.WriteLine($"Category: {Category}");
            Console.WriteLine($"Status: {Status}");
        }
    }
}