using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorsAndComparators
{
    public class Library : IEnumerable<Book>
    {
        public Library(params Book[] books)
        {
            Books = books.ToList();
        }

        public List<Book> Books { get; set; }

        public IEnumerator<Book> GetEnumerator()
        {
            return Books.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public class LibraryIterator : IEnumerator<Book>
        {

            private List<Book> books;
            private int currentIndex;

            public Book Current => books[currentIndex];

            object IEnumerator.Current => this.Current;

            

            public bool MoveNext() => ++this.currentIndex < this.books.Count;

            public void Reset()
            {
                currentIndex = -1;
            }
            public void Dispose()
            {
                throw new NotImplementedException();
            }
        }
    }
}
