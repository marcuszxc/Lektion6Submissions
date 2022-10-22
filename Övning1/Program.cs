using ConsoleClasses;

namespace Övning1
{
    internal class Program
    {
        static void Main(string[] args)
        {

           List<Bok> BokList = Program.GetBooksAndSort();


           foreach (Bok b in BokList)
            {
                Console.WriteLine();
                b.ShowBok();
                Console.WriteLine();
            }


        }

        static public List<Bok> GetBooksAndSort()
        {

            List<Bok> GetBooks()
            {

                string[] userContext = { "Enter book title: ", "Enter the number of pages the book has.: ", "Enter the year of publication.: " };

                List<Bok> bokList = new List<Bok>();

                Bok book;

                while (true)
                {

                    string loopCheck = "";

                    Console.WriteLine("Please add a book to your library.");

                    book = new Bok(UserInput.AskForString(userContext[0]), UserInput.AskForInt(userContext[1]), UserInput.AskForInt(userContext[2]));

                    bokList.Add(book);


                    while (true)
                    {
                        loopCheck = UserInput.AskForString("Do you wanna add another book?(Yes/No): ").ToLower();

                        if (loopCheck == "yes" || loopCheck == "no")
                        {
                            break;
                        }
                    }

                    if (loopCheck == "no")
                    {
                        break;
                    }

                }

                return bokList;
            }

            List<Bok> SortBooks()
            {
                List<Bok> BokList = GetBooks();

                BokList = BokList.OrderBy(s => s.PublicationYear).Reverse().ToList();

                return BokList;

            }

            return SortBooks();

        }

    }

}
