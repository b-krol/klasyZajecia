using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace klasyiobiekty.przykladyklas
{
    internal class Book
    {

        public string title { get; private set; } = string.Empty;
        public string? author { get; private set; }
        public DateTime? publicationDate { get; private set; }
        public int? amountOfPages { get; private set; }
        public List<string> languages { get; private set; }
        public int amountOfLanguages { get; private set; }

        //konstruktory
        public Book(string title, string author, DateTime publicationDate, int amountOfPages, List<string> languages)
        {
            this.title = title;
            this.author = author;
            this.publicationDate = publicationDate;
            this.amountOfPages = amountOfPages;
            this.languages = languages;
            this.amountOfLanguages = languages.Count;
        }

        public Book(string title, string author, DateTime publicationDate, int amountOfPages, int amountOfLanguages)
        {
            this.title = title;
            this.author = author;
            this.publicationDate = publicationDate;
            this.amountOfPages = amountOfPages;
            this.amountOfLanguages = amountOfLanguages;
        }

        public TimeSpan? lifeTime()
        {
            return DateTime.Now - publicationDate;
        }

        public void addLanguage(string language)
        {
            languages.Add(language);
        }
        public void addLanguages(List<string> languages)
        {
            this.languages.AddRange(languages);
        }
        public void removeLanguage(string language)
        {
            languages.Remove(language);
        }
        public void removeLanguages(List<string> languages)
        {
            foreach(string language in languages)
            {
                languages.Remove(language);
            }
        }
    }
}
