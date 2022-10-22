namespace Övning3
{
    internal class PhotoBook
    {

        private int numPages;


        public PhotoBook()
        {
            this.numPages = 16;
        }

        public PhotoBook(int numPages)
        {
            this.numPages = numPages;
        }

        public int GetNumberPages()
        {
            return numPages;
        }

    }

    internal class BigPhotoBook
    {
        private int numPages;

        public BigPhotoBook()
        {
            this.numPages = 64;
        }

        public int GetNumberPages()
        {
            return this.numPages;
        }

    }

    internal class PhotoBookTest
    {
        public PhotoBookTest()
        {
            PhotoBook photobook = new PhotoBook();
            PhotoBook photobook24 = new PhotoBook(24);
            BigPhotoBook bigphotobook = new BigPhotoBook();

            Console.WriteLine($"Number of pages in photobook - {photobook.GetNumberPages()}\n");
            Console.WriteLine($"Number of pages in photobook24 - {photobook24.GetNumberPages()}\n");
            Console.WriteLine($"Number of pages in bigphotobook - {bigphotobook.GetNumberPages()}\n");

        }
    }

}