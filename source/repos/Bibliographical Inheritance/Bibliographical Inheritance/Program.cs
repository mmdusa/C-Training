using System;

namespace BiblioInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Resource test = new Resource("The Great Gatsby", "Novel");

            // 2. Call GetInfo to see the initial details
            test.GetInfo();

            // 3. Call UpdateStatus to change it from "Available" to "Out"
            test.UpdateStatus();

            // 4. Print the new status to confirm it changed
            Console.WriteLine($"New Status: {test.Status}");
            Book CodeBook = new Book(
              "Code: The Hidden Language of Computer Hardware and Software", // Title
              "Non-Fiction",     // Category
              "Charles Petzold", // Author
              396                // PageCount
            );
            CodeBook.GetInfo();
            Periodical p = new Periodical("Wired", "Technology", "Monthly");
            p.UpdateStatus();
            Console.WriteLine(p.Status);
            Video v = new Video("Ex Machina", "Alex Garland", "Sci-Fi", 108, "On-Demand");
            v.GetInfo();

        }
    }
}