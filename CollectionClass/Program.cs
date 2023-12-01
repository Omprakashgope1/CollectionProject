namespace CollectionClass
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            book.AddChapterToTheBook(1, 1, 4);
            book.AddChapterToTheBook(2, 5, 10);
            book.AddChapterToTheBook(3, 12, 16);
            book.AddChapterToTheBook(4,13,18);
            book.AddChapterToTheBook(5,19,23);
            book.AddChapterToTheBook(6,25,29);
            book.AddChapterToTheBook(7,30,33);
            book.AddChapterToTheBook(8,35,39);
            book.AddChapterToTheBook(9,40,44);
            book.AddChapterToTheBook(10,45,48);
            book.AddChapterToTheBook(11,50,54);
            book.AddChapterToTheBook(12,55,60);
            SortedList<int, int[]> index = book.getIndex();
            int totalChapter = index.Count;
            int[] lastChapterpages = index[totalChapter];
            int lastPage = lastChapterpages[1];
            Console.WriteLine("Enter the page you are reading");
            int k = Convert.ToInt32(Console.ReadLine());
            foreach(var chapter in index)
            {
                int[] temp = chapter.Value;
                if (temp[0] > k)
                {
                    Console.WriteLine("The chapter left after this are : " + (totalChapter - chapter.Key + 1));
                    break;
                }
                else if(k >= temp[0] && k <= temp[1]) 
                {
                    Console.WriteLine("The number of chapters left after this chapter are : " + (totalChapter - chapter.Key));
                    break;
                }

            }
        }
    }
}
