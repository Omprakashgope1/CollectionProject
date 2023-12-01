using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionClass
{
    internal class Book
    {
        SortedList<int, int[]> book;
        public Book()
        {
            book = new SortedList<int, int[]>();
        }
        public void AddChapterToTheBook(int chapter,int first,int last)
        {
            book.Add(chapter, new int[] { first, last });
        }
        public SortedList<int, int[]> getIndex()
        {
            return book;
        }
    }
}
