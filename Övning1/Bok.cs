namespace Övning1
{
    internal class Bok
    {
        private string title;
        private int numberOfPages;
        private int publicationYear;

        public Bok(string title, int numberOfPages, int publicationYear)
        {
            this.title = title;
            this.numberOfPages = numberOfPages;
            this.publicationYear = publicationYear;
        }

        public void ShowBok() 
        {
            Console.WriteLine($"Book titel: {this.title} | Number of Pages: {this.NumberOfPages} | PublicationYear: {this.publicationYear}");
        }

        public string Title
        {
            get { return title; }
            set { title = value; }
        }

        public int NumberOfPages
        {
            get { return numberOfPages; }
            set { numberOfPages = value; }
        }

        public int PublicationYear
        {
            get { return publicationYear; }
            set { publicationYear = value; }
        }

        
    }
}
