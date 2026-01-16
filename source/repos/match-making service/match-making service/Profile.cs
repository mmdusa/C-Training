using System;

namespace DatingProfile
{
    public class Profile
    {
        // 2. Add the requested fields here
        private string name;
        private int age;
        private string city;
        private string country;
        private string pronouns;
        private string[] hobbies;
        public Profile(string name , int age , string city , string country , string pronouns = "they/them")
        {
            this.name = name;
            this.age = age;
            this.city = city;
            this.country = country;
            this.pronouns = pronouns;

            // Initialize hobbies as an empty array so it isn't null
            this.hobbies = new string[0];
        }
        public void SetHobbies(string[] hobbies)
        {
            this.hobbies = hobbies;
        }
        public string ViewProfile()
        {
            string bio = $"Name: {name}\nAge: {age}\nCity: {city}\nCountry: {country}\nPronouns: {pronouns}";
            bio += "\nHobbies:";
            foreach (string hobby in this.hobbies)
            {
                bio += $"\n-{hobby}";

            }
            return bio;
        }
       


    }
}