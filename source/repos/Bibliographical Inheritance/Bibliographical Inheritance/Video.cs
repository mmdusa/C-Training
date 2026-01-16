using System;

namespace BiblioInheritance
{
    public class Video : Resource
    {
        public string Director { get; private set; }
        public int Runtime { get; private set; }
        public string MediaType { get; private set; }

        public Video(string title, string category, string director, int runtime, string mediaType) : base(title, category)
        {
            this.Director = director;
            this.Runtime = runtime;
            this.MediaType = mediaType;
        }

        // Override GetInfo to include the new properties
        public override void GetInfo()
        {
            // 1. Run the original logic (Title, Category, Status)
            base.GetInfo();

            // 2. Add the video-specific logic
            Console.WriteLine($"Director: {Director}");
            Console.WriteLine($"Runtime: {Runtime}");
            Console.WriteLine($"MediaType: {MediaType}");
        }
    }
}