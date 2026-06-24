using InheritanceConsoleApp;

class Program
{
   static void Main(string[] args)
    {
        FictionBook objFictionBook = new FictionBook("monika", "BERt, Random", 56.789,"uv");
        //objFictionBook.Author = "Monika";
        //objFictionBook.Price = 25000.44;
        //objFictionBook.Title = "BERT , LLM";
        //objFictionBook.Genre = "fosojsd";

        objFictionBook.DisplayInfo();
    }
}
